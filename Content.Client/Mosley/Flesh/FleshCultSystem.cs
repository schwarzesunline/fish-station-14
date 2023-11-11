using Content.Shared.Mosley.Flesh;
using Content.Client.Antag;
using Content.Shared.StatusIcon.Components;

namespace Content.Client.Mosley.Flesh;

public sealed class FleshCultSystem : AntagStatusIconSystem<FleshCultistComponent>
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<FleshCultistComponent, GetStatusIconsEvent>(GetFleshIcon);
    }

    private void GetFleshIcon(EntityUid uid, FleshCultistComponent comp, ref GetStatusIconsEvent args)
    {
        GetStatusIcon(comp.CultistFleshStatusIcon, ref args);
    }
}
