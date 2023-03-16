using System.Collections.Generic;

namespace Titan.DataProvider.Application.Models.GalaxyOfHeroes.GameData
{
    public class RecommendedSquad
    {
        public string? DescriptionKey { get; set; }
        public string? Thumbnail { get; set; }
        public string? Name { get; set; }
        public Requirement? ShowRequirement { get; set; }
        public Requirement? HideRequirement { get; set; }
        public ActionLink? ActionLink { get; set; }
        public string? Id { get; set; }
        public List<string> UnitDefId { get; set; } = new();
    }
}
