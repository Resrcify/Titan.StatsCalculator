using System.Collections.Generic;

namespace Titan.DataProvider.Application.Models.GalaxyOfHeroes.GameData
{
    public class UnitTierDef
    {
        public UnitTier Tier { get; set; }
        public StatDef? BaseStat { get; set; }
        public List<string> EquipmentSet { get; set; } = new();
    }
}
