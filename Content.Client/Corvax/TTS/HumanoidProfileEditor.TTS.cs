using System.Linq;
using Content.Client.Corvax.TTS;
using Content.Shared.Corvax.TTS;
using Content.Shared.Preferences;
using Robust.Shared.Random;
using Content.Corvax.Interfaces.Client;

namespace Content.Client.Preferences.UI;

public sealed partial class HumanoidProfileEditor
{
    private TTSManager _ttsMgr = default!;
    private TTSSystem _ttsSys = default!;
    private List<TTSVoicePrototype> _voiceList = default!;
    private readonly List<string> _sampleText = new()
    {
        "Съешь же ещё этих мягких французских булок, да выпей чаю.",
        "Клоун, прекрати разбрасывать банановые кожурки офицерам под ноги!",
        "Капитан, вы уверены что хотите назначить клоуна на должность главы персонала?",
        "Эс Бэ! Тут человек в сером костюме, с тулбоксом и в маске! Помогите!!"
    };

    private void InitializeVoice()
    {

        _ttsSys = _entMan.System<TTSSystem>();
        _voiceList = _prototypeManager
            .EnumeratePrototypes<TTSVoicePrototype>()
            .Where(o => o.RoundStart)
            .OrderBy(o => Loc.GetString(o.Name))
            .ToList();

        _voiceButton.OnItemSelected += args =>
        {
            _voiceButton.SelectId(args.Id);
            SetVoice(_voiceList[args.Id].ID);
        };

        _voicePlayButton.OnPressed += _ => { PlayTTS(); };
    }

    private void UpdateTTSVoicesControls()
    {
        if (Profile is null || _voiceList is null)
            return;

        _voiceButton.Clear();

        var firstVoiceChoiceId = 0;
        for (var i = 0; i < _voiceList.Count; i++)
        {
            var voice = _voiceList[i];
            if (!HumanoidCharacterProfile.CanHaveVoice(voice, Profile.Sex))
                continue;

            var name = Loc.GetString(voice.Name);
            _voiceButton.AddItem(name, i);

            if (firstVoiceChoiceId == 0)
            {
                firstVoiceChoiceId = i;
                _voiceButton.SetItemDisabled(_voiceButton.GetIdx(i), true);
            }
        }

        var voiceChoiceId = _voiceList.FindIndex(x => x.ID == Profile.Voice);
        if (voiceChoiceId == -1)
            voiceChoiceId = firstVoiceChoiceId;

        _voiceButton.TrySelectId(voiceChoiceId);
        SetVoice(_voiceList[voiceChoiceId].ID);
    }


    private void PlayTTS()
    {
        if (_previewDummy is null || Profile is null || _ttsMgr is null || _sampleText.Count == 0)
            return;

        string sampleText = IoCManager.Resolve<IRobustRandom>().Pick(_sampleText);
        if (sampleText is null)
            return;

        try
        {
            _ttsMgr.RequestTTS(_previewDummy.Value, sampleText, Profile.Voice);
        }
        catch (Exception ex)
        {

        }
    }
}
