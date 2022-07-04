using SWSH_OWRNG_Generator.Core.Encounters;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class EncounterLookup : Form
    {
        private static MainWindow MainWindow;

        private readonly static EncounterData Encounters = new();
        public EncounterLookup(MainWindow f)
        {
            InitializeComponent();
            this.SelectedGame.SelectedIndex = 0;
            foreach (string SpeciesName in Encounters.Data.Keys)
            {
                this.SelectedSpecies.Items.Add(SpeciesName);
            }
            MainWindow = f;
        }

        private void PopulateEncounterDataTable(object sender, System.EventArgs e)
        {
            if (SelectedSpecies.SelectedItem != null)
            {
                string SpeciesName = (string)SelectedSpecies.SelectedItem;
                PkmInfo Data = Encounters.Data[SpeciesName];

                if (Data != null)
                {
                    if (Data.Encounters != null)
                    {
                        List<PkmResult> Results = new();
                        foreach (EncounterDetails Encounter in Data.Encounters)
                        {
                            if (Encounter.Game! != (string)SelectedGame.SelectedItem) continue;
                            bool Item = false;
                            int FixedIVs = 0;
                            bool AbilityLocked = false;
                            bool ShinyLocked = false;
                            List<string> EggMoves = new();
                            string Ability = "-";
                            string Slot = "-";
                            string Level = (Encounter.Level[0] == Encounter.Level[1]) ? $"{Encounter.Level[0]}" : $"{Encounter.Level[0]} - {Encounter.Level[1]}";
                            if (Data.Item != null && Encounter.EncounterType! != "Static") Item = (bool)Data.Item;
                            if (Data.EggMoves != null) EggMoves = (List<string>)Data.EggMoves;
                            if (Encounter.FixedIVs != null) FixedIVs = (int)Encounter.FixedIVs;
                            if (Encounter.LockedAbility != null) AbilityLocked = (bool)Encounter.LockedAbility;
                            if (Encounter.Ability != null) Ability = Encounter.Ability.ToString();
                            if (Encounter.Slots != null) Slot = $"{Encounter.Slots[0]} - {Encounter.Slots[1]}";
                            if (Encounter.ShinyLocked != null) ShinyLocked = (bool)Encounter.ShinyLocked;

                            Results.Add(
                                new PkmResult
                                {
                                    Species = SpeciesName,
                                    EncounterType = Encounter.EncounterType!,
                                    Item = Item,
                                    EggMoveCount = EggMoves.Count,
                                    Level = Level,
                                    Slots = Slot,
                                    FixedIVs = FixedIVs,
                                    Weather = Encounter.Weather,
                                    Location = Encounter.Location,
                                    LockedAbility = AbilityLocked,
                                    ShinyLocked = ShinyLocked,
                                    Ability = Ability,
                                }
                            );
                        }
                        BindingSource Source = new() { DataSource = Results };
                        EncounterLookupResults.DataSource = Source;
                        EncounterLookupResults.Columns["EggMoves"].Visible = false;
                        EncounterLookupResults.Columns["Game"].Visible = false;
                        Source.ResetBindings(false);
                    }
                }
            }
        }

        private void EncounterLookupResults_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MainWindow.CheckHeldItem.Checked = (bool)EncounterLookupResults[1, e.RowIndex].Value;
            MainWindow.InputEMs.Text = EncounterLookupResults[3, e.RowIndex].Value.ToString();
            MainWindow.CheckIsAbilityLocked.Checked = (string)EncounterLookupResults[4, e.RowIndex].Value != "-";

            string[] LevelSubs = ((string)EncounterLookupResults[5, e.RowIndex].Value).Split(" - ");
            string LevelMin = LevelSubs[0], LevelMax;
            if (LevelSubs.Length == 2)
            {
                LevelMax = LevelSubs[1];
            }
            else
            {
                LevelMax = LevelSubs[0];
            }
            MainWindow.InputLevelMin.Text = LevelMin;
            MainWindow.InputLevelMax.Text = LevelMax;

            string[] SlotsSubs = ((string)EncounterLookupResults[6, e.RowIndex].Value).Split(" - ");
            string SlotMin = "0", SlotMax = "99";
            if (SlotsSubs.Length == 2)
            {
                SlotMin = SlotsSubs[0];
                SlotMax = SlotsSubs[1];
            }
            MainWindow.InputSlotMin.Text = SlotMin;
            MainWindow.InputSlotMax.Text = SlotMax;

            string EncounterType = (string)EncounterLookupResults[8, e.RowIndex].Value;
            bool Static = false, Hidden = false;
            if (EncounterType == "Static") Static = true;
            else if (EncounterType == "Hidden") Hidden = true;

            bool Fishing = false, Weather = false;
            string WeatherType = (string)EncounterLookupResults[9, e.RowIndex].Value;
            switch (WeatherType)
            {
                case "Fishing":
                    Fishing = true;
                    break;

                case "Normal Weather":
                case "All Weather":
                    break;

                default:
                    Weather = true;
                    break;
            }
            MainWindow.CheckFishing.Checked = Fishing;
            MainWindow.CheckWeather.Checked = Weather;
            MainWindow.CheckStatic.Checked = Static;
            MainWindow.CheckHidden.Checked = Hidden && !Fishing;

            MainWindow.CheckIsAbilityLocked.Checked = (bool)EncounterLookupResults[11, e.RowIndex].Value;
            MainWindow.CheckShinyLocked.Checked = (bool)EncounterLookupResults[12, e.RowIndex].Value;
            MainWindow.InputFlawlessIVs.Text = EncounterLookupResults[13, e.RowIndex].Value.ToString();
        }
    }
}
