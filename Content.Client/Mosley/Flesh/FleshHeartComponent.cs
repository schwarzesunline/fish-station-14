using Content.Shared.Mosley.Flesh;

namespace Content.Client.Mosley.Flesh;

[RegisterComponent]
public sealed partial class FleshHeartComponent : Component
{
    [DataField("finalState")]
    public string? FinalState = "underpowered";
}
