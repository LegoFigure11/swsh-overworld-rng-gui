using System.Text.Json;

namespace SWSH_OWRNG_Generator.Core
{
    public class EncounterInfo
    {
        private readonly static string FileName = "EncounterData.json";
        private readonly static string JsonString = File.ReadAllText(FileName);
        public readonly Dictionary<string, PkmInfo> Data = JsonSerializer.Deserialize<Dictionary<string, PkmInfo>>(JsonString)!;
    }

    public class PkmInfo
    {
        public string? Species { get; set; }
        public bool? Item { get; set; }
        public IList<string>? EggMoves { get; set; }
        public int? EggMoveCount { get; set; }
    }
}
