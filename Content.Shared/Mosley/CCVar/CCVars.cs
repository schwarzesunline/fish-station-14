using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared.Mosley.CCVar;

[CVarDefs]
public sealed class CCVars
{
    /*
 * FleshCult
 */

    public static readonly CVarDef<int> FleshCultMinPlayers =
        CVarDef.Create("fleshcult.min_players", 25);

    public static readonly CVarDef<int> FleshCultMaxCultist =
        CVarDef.Create("fleshcult.max_cultist", 6);

    public static readonly CVarDef<int> FleshCultPlayersPerCultist =
        CVarDef.Create("fleshcult.players_per_cultist", 7);
}
