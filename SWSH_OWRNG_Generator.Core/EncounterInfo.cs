using System.Text.Json;

namespace SWSH_OWRNG_Generator.Core
{
    public class EncounterData
    {
        private readonly static string FileName = "EncounterData.json";
        private readonly static string JsonString = File.ReadAllText(FileName);
        public readonly Dictionary<string, PkmInfo> Data = JsonSerializer.Deserialize<Dictionary<string, PkmInfo>>(JsonString)!;
    }

    public class PkmInfo
    {
        public bool? Item { get; set; }
        public IList<string>? EggMoves { get; set; }
        public IList<EncounterDetails>? Encounters { get; set; }

    }

    public class EncounterDetails
    {
        public string? Game { get; set; }
        public string? EncounterType { get; set; }
        public string? Weather { get; set; }
        public string? Location { get; set; }
        public int[]? Level { get; set; }
        public int[]? Slot { get; set; }
        public bool? AbilityLocked { get; set; }
        public int? Ability { set; get; }
        public int? FixedIVs { get; set; }
    }

    public class PkmResult : EncounterDetails
    {
        public string? Species { get; set; }
        public bool? Item { get; set; }
        public IList<string>? EggMoves { get; set; }
        public int? EggMoveCount { get; set; }
    }
}
