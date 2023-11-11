using Content.Server.Mosley.Flesh;
using JetBrains.Annotations;
using Robust.Shared.Utility;

namespace Content.Server.Mosley.Objectives;

[RegisterComponent]
public sealed partial class CreateFleshHeartConditionComponent : Component
{
    public bool IsFleshHeartFinale(FleshHeartComponent comp)
    {
        return comp.State == FleshHeartSystem.HeartStates.Disable;
    }
}
