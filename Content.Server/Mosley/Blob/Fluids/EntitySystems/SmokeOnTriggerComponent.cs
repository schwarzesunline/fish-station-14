using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Audio;

namespace Content.Server.Mosley.Blob.Fluids.EntitySystems;

[RegisterComponent]
public sealed partial class SmokeOnTriggerComponentFluidComponent : Component
{
    [DataField("spreadAmount"), ViewVariables(VVAccess.ReadWrite)]
    public int SpreadAmount = 20;

    [DataField("time"), ViewVariables(VVAccess.ReadWrite)]
    public float Time = 20f;

    [DataField("smokeColor")]
    public Color SmokeColor = Color.Black;

    [DataField("smokeReagents")]
    public List<ReagentQuantity> SmokeReagents = new();

    [DataField("sound")]
    public SoundSpecifier Sound = new SoundPathSpecifier("/Audio/Effects/smoke.ogg");
}
