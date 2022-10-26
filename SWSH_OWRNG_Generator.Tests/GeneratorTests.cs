using FluentAssertions;
using SWSH_OWRNG_Generator.Core;
using SWSH_OWRNG_Generator.Core.OWRNG.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SWSH_OWRNG_Generator.Tests;

public sealed class GeneratorTests
{
    private static readonly uint TSV = Core.Util.Common.GetTSV(1337, 1390);
    private const int ShinyRolls = 3;
    private const int MarkRolls = 3;
    private const uint EggMoveCount = 4;
    private const uint KOs = 500;
    private const string Ignore = "Ignore";
    private readonly static uint[] MinIVs = { 0, 0, 0, 0, 0, 0 };
    private readonly static uint[] MaxIVs = { 31, 31, 31, 31, 31, 31 };
    private readonly static IProgress<int> Progress = new Progress<int>();


    [Theory]
    [InlineData(0x69CABBA9ECABBA9Eu, 0xCABBA9ECABBA9E69u)]
    public void GenerateStatic(in ulong s0, in ulong s1)
    {
        Core.Overworld.Filter Filters = new()
        {
            TSV = TSV,
            ShinyRolls = ShinyRolls,
            MarkRolls = MarkRolls,
            MinIVs = MinIVs,
            MaxIVs = MaxIVs,
            Weather = false,
            Static = true,
            Fishing = false,
            Hidden = false,
            ShinyLocked = false,
            AbilityLocked = false,
            DesiredShiny = Ignore,
            DesiredMark = Ignore,
            DesiredAura = Ignore,
            DesiredNature = Ignore
        };
        List<Frame> Frames = Generator.Generate(s0, s1, 1000, 0, Progress, Filters, 0);
        Frames.Should().NotBeNull();
        Frames.Where(f => f.Shiny != "No").Count().Should().Be(0);
        Frames.Where(f => f.Mark == "Rare").Count().Should().Be(1);
        Frames.Where(f => f.Mark == "Uncommon").Count().Should().Be(36);
        Frames.Where(f => f.Advances == "869" && f.PID == "770397FE" && f.EC == "87036D68" && f.Ability == 1 && f.Nature == "Jolly" && f.HP == 29 && f.Atk == 0 && f.Def == 1 && f.SpA == 30 && f.SpD == 30 && f.Spe == 0 && f.Mark == "Upbeat").Count().Should().Be(1);
    }

    [Theory]
    [InlineData(0xAAAAAAAAAAAAAAAAu, 0x50C1AB1ECABBA6E5u)]
    public void GenerateSymbol(in ulong s0, in ulong s1)
    {
        Core.Overworld.Filter Filters = new()
        {
            TSV = TSV,
            ShinyRolls = ShinyRolls,
            MarkRolls = MarkRolls,
            MinIVs = MinIVs,
            MaxIVs = MaxIVs,
            Weather = false,
            Static = false,
            Fishing = false,
            Hidden = false,
            HeldItem = false,
            ShinyLocked = false,
            AbilityLocked = false,
            CuteCharm = false,
            DesiredShiny = Ignore,
            DesiredMark = Ignore,
            DesiredAura = Ignore,
            DesiredNature = Ignore,
            LevelMin = 34,
            LevelMax = 36,
            SlotMin = 0,
            SlotMax = 99,
            EggMoveCount = EggMoveCount,
            KOs = KOs,
            FlawlessIVs = 0
        };

        List<Frame> Frames = Generator.Generate(s0, s1, 60000, 0, Progress, Filters, 0);
        Frames.Should().NotBeNull();
        Frames.Where(f => f.Shiny != "No" && f.Brilliant == "Y").Count().Should().Be(3);
        Frames.Where(f => f.PID == "4ED54E82" && f.EC == "5C7EDFDF").Count().Should().Be(3);
        Frames.Where(f => f.PID == "4ED54E82" && f.EC == "5C7EDFDF" && f.Slot == 94 && f.Level == 36 && f.HP == 31 && f.Atk == 31 && f.Def == 11 && f.SpA == 11 && f.SpD == 21 && f.Spe == 21 && f.Mark == "Peeved").Count().Should().Be(1);

        Frames = Generator.Generate(s0, s1, 5000, 50000, Progress, Filters, 0);
        Frames.Where(f => f.Shiny != "No").Count().Should().Be(10);
    }
}