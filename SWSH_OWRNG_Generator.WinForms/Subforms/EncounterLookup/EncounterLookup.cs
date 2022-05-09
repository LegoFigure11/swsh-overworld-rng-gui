using System.Collections.Generic;
using System.Windows.Forms;


namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class EncounterLookup : Form
    {
        private readonly static Core.EncounterData Encounters = new();
        public EncounterLookup()
        {
            InitializeComponent();
            this.SelectedGame.SelectedIndex = 0;
            foreach (string SpeciesName in Encounters.Data.Keys)
            {
                this.SelectedSpecies.Items.Add(SpeciesName);
            }

        }

        private void PopulateEncounterDataTable(object sender, System.EventArgs e)
        {
            if (SelectedSpecies.SelectedItem != null)
            {
                string SpeciesName = (string)SelectedSpecies.SelectedItem;
                Core.PkmInfo Data = Encounters.Data[SpeciesName];

                if (Data != null)
                {
                    if (Data.Encounters != null)
                    {
                        List<Core.PkmResult> Results = new();
                        foreach (Core.EncounterDetails Encounter in Data.Encounters)
                        {
                            if (Encounter.Game! != (string)SelectedGame.SelectedItem) continue;
                            bool Item = false;
                            int FixedIVs = 0;
                            bool AbilityLocked = false;
                            List<string> EggMoves = new();
                            string Ability = "-";
                            string Slot = "-";
                            string Level = (Encounter.Level[0] == Encounter.Level[1]) ? $"{Encounter.Level[0]}" : $"{Encounter.Level[0]} - {Encounter.Level[1]}";
                            if (Data.Item != null && Encounter.EncounterType! != "Static") Item = (bool)Data.Item;
                            if (Data.EggMoves != null) EggMoves = (List<string>)Data.EggMoves;
                            if (Encounter.FixedIVs != null) FixedIVs = (int)Encounter.FixedIVs;
                            if (Encounter.AbilityLocked != null) AbilityLocked = (bool)Encounter.AbilityLocked;
                            if (Encounter.Ability != null) Ability = Encounter.Ability.ToString();
                            if (Encounter.Slots != null) Slot = $"{Encounter.Slots[0]} - {Encounter.Slots[1]}";

                            Results.Add(
                                new Core.PkmResult
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
                                    AbilityLocked = AbilityLocked,
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
    }
}