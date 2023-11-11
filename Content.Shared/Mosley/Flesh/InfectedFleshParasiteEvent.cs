using Content.Shared.Actions;

namespace Content.Shared.Mosley.Flesh;

public readonly struct EntityInfectedFleshParasiteEvent
{
    public readonly EntityUid Target;

    public EntityInfectedFleshParasiteEvent(EntityUid target)
    {
        Target = target;
    }
};

public sealed partial class ZombifySelfActionEvent : InstantActionEvent { };
