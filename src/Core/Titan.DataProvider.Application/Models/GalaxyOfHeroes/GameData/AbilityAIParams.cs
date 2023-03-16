using System.Collections.Generic;

namespace Titan.DataProvider.Application.Models.GalaxyOfHeroes.GameData
{
    public class AbilityAIParams
    {
        public string? PreferredAllyTargetingRuleId { get; set; }
        public string? PreferredEnemyTargetingRuleId { get; set; }
        public bool RequireEnemyPreferredTargets { get; set; }
        public bool RequireAllyTargets { get; set; }
        public List<string> PreferredAllyTargetingRuleIdList { get; set; } = new();
        public List<string> PreferredEnemyTargetingRuleIdList { get; set; } = new();

    }
}
