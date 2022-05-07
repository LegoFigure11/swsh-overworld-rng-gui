using System.Collections.Generic;
using System.Windows.Forms;


namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class EncounterLookup : Form
    {
        private readonly static Core.EncounterInfo EncounterInfo = new();
        public EncounterLookup()
        {
            InitializeComponent();
            this.SelectedGame.SelectedIndex = 0;
            foreach(string SpeciesName in EncounterInfo.Data.Keys)
            {
                this.SelectedSpecies.Items.Add(SpeciesName);
            }
            
        }

        private void SelectedSpecies_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string SpeciesName = (string)SelectedSpecies.SelectedItem;
            Core.PkmInfo Data = EncounterInfo.Data[SpeciesName];
            
            
            if (Data != null)
            {
                bool Item = false;
                List<string> EggMoves = new();
                if (Data.Item != null) Item = (bool)Data.Item;
                if (Data.EggMoves != null) EggMoves = (List<string>)Data.EggMoves;

                List<Core.PkmInfo> Results = new();
                Results.Add(
                    new Core.PkmInfo
                    {
                        Species = SpeciesName,
                        Item = Item,
                        EggMoveCount = EggMoves.Count
                    }
                );
                BindingSource Source = new() { DataSource = Results };
                EncounterLookupResults.DataSource = Source;
                EncounterLookupResults.Columns["EggMoves"].Visible = false;
                Source.ResetBindings(false);
            }
        }
    }
}
