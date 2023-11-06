using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Mosley.Blob;

[NetworkedComponent]
public abstract partial class SharedBlobbernautComponent : Component
{
    [DataField("color")]
    public Color Color = Color.White;
}
