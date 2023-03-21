namespace SWSH_OWRNG_Generator.Core.Overworld
{
    public class Filter
    {
        public uint TSV { get; set; }
        public bool TIDSIDSearch { get; set; }
        public int ShinyRolls { get; set; }
        public int MarkRolls { get; set; }
        public bool Weather { get; set; }
        public bool Static { get; set; }
        public bool Fishing { get; set; }
        public bool Hidden { get; set; }
        public bool HeldItem { get; set; }
        public bool CuteCharm { get; set; }
        public bool AbilityLocked { get; set; }
        public bool ShinyLocked { get; set; }
        public string? DesiredMark { get; set; }
        public string? DesiredShiny { get; set; }
        public string? DesiredNature { get; set; }
        public string? DesiredAura { get; set; }
        public uint LevelMin { get; set; }
        public uint LevelMax { get; set; }
        public uint SlotMin { get; set; }
        public uint SlotMax { get; set; }
        public uint EggMoveCount { get; set; }
        public uint KOs { get; set; }
        public uint FlawlessIVs { get; set; }
        public uint[]? MinIVs { get; set; }
        public uint[]? MaxIVs { get; set; }
        public bool MenuClose { get; set; }
        public bool Is3Segment { get; set; }
    }
}
