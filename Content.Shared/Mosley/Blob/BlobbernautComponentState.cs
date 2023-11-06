using Robust.Shared.Serialization;

namespace Content.Shared.Mosley.Blob;

[Serializable, NetSerializable]
public sealed class BlobbernautComponentState : ComponentState
{
    public Color Color;
}
