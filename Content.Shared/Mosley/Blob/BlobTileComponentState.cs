using Robust.Shared.Serialization;

namespace Content.Shared.Mosley.Blob;

[Serializable, NetSerializable]
public sealed class BlobTileComponentState : ComponentState
{
    public Color Color;
}
