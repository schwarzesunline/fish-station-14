using Content.Server.Mosley.Blob;
using Content.Shared.Mind;
using Robust.Shared.Audio;

namespace Content.Server.Mosley.GameTicking.Rules.Components;

[RegisterComponent, Access(typeof(BlobRuleSystem), typeof(BlobCoreSystem), typeof(BlobObserverSystem))]
public sealed partial class BlobRuleComponent : Component
{
    public List<(EntityUid mindId, MindComponent mind)> Blobs = new(); //BlobRoleComponent

    public BlobStage Stage = BlobStage.Default;

    [DataField("alertAodio")]
    public SoundSpecifier? AlertAudio = new SoundPathSpecifier("/Audio/Announcements/attention.ogg");
}


public enum BlobStage : byte
{
    Default,
    Begin,
    Medium,
    Critical,
    TheEnd
}
