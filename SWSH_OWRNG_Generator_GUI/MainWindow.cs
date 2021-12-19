using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator_GUI
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        public MainWindow()
        {
            string build = String.Empty;
#if DEBUG
            var date = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly().Location);
            build = $" (dev-{date:yyyyMMdd})";
#endif
            var v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "SwSh OWRNG Generator GUI v" + v.Major + "." + v.Minor + "." + v.Build + build;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InputTID.Text = Properties.Settings.Default.TID;
            InputSID.Text = Properties.Settings.Default.SID;
            CheckShinyCharm.Checked = Properties.Settings.Default.ShinyCharm;
            CheckMarkCharm.Checked = Properties.Settings.Default.MarkCharm;

            SelectedMark.SelectedIndex = 0;
            SelectedShiny.SelectedIndex = 0;

            // Set Tab Indexes Manually
            // This will make life easier when adding more fields later on
            // (aka Lego can't find the button that made this nice to do)
            InputState0.TabIndex = 0;
            InputState1.TabIndex = InputState0.TabIndex + 1;
            InputTID.TabIndex = InputState1.TabIndex + 1;
            InputSID.TabIndex = InputTID.TabIndex + 1;
            InputMaxAdv.TabIndex = InputSID.TabIndex + 1;
            hpMin.TabIndex = InputMaxAdv.TabIndex + 1;
            hpMax.TabIndex = hpMin.TabIndex + 1;
            atkMin.TabIndex = hpMax.TabIndex + 1;
            atkMax.TabIndex = atkMin.TabIndex + 1;
            defMin.TabIndex = atkMax.TabIndex + 1;
            defMax.TabIndex = defMin.TabIndex + 1;
            spaMin.TabIndex = defMax.TabIndex + 1;
            spaMax.TabIndex = spaMin.TabIndex + 1;
            spdMin.TabIndex = spaMax.TabIndex + 1;
            spdMax.TabIndex = spdMin.TabIndex + 1;
            speMin.TabIndex = spdMax.TabIndex + 1;
            speMax.TabIndex = speMin.TabIndex + 1;
            hpMinFilter.TabIndex = speMax.TabIndex + 1;
            hpMaxFilter.TabIndex = hpMinFilter.TabIndex + 1;
            atkMinFilter.TabIndex = hpMaxFilter.TabIndex + 1;
            atkMaxFilter.TabIndex = atkMinFilter.TabIndex + 1;
            defMinFilter.TabIndex = atkMaxFilter.TabIndex + 1;
            defMaxFilter.TabIndex = defMinFilter.TabIndex + 1;
            spaMinFilter.TabIndex = defMaxFilter.TabIndex + 1;
            spaMaxFilter.TabIndex = spaMinFilter.TabIndex + 1;
            spdMinFilter.TabIndex = spaMaxFilter.TabIndex + 1;
            spdMaxFilter.TabIndex = spdMinFilter.TabIndex + 1;
            speMinFilter.TabIndex = spdMaxFilter.TabIndex + 1;
            speMaxFilter.TabIndex = speMinFilter.TabIndex + 1;
            SelectedMark.TabIndex = speMaxFilter.TabIndex + 1;
            SelectedShiny.TabIndex = SelectedMark.TabIndex + 1;
            CheckShinyCharm.TabIndex = SelectedShiny.TabIndex + 1;
            CheckStatic.TabIndex = CheckShinyCharm.TabIndex + 1;
            CheckMarkCharm.TabIndex = CheckStatic.TabIndex + 1;
            CheckFishing.TabIndex = CheckMarkCharm.TabIndex + 1;
            CheckWeather.TabIndex = CheckFishing.TabIndex + 1;
            CheckHeldItem.TabIndex = CheckWeather.TabIndex + 1;
            CheckIsAbilityLocked.TabIndex = CheckHeldItem.TabIndex + 1;
            CheckTIDSIDFinder.TabIndex = CheckIsAbilityLocked.TabIndex + 1;
            InputFlawlessIVs.TabIndex = CheckTIDSIDFinder.TabIndex + 1;
            InputKOCount.TabIndex = InputFlawlessIVs.TabIndex + 1;
            InputEMs.TabIndex = InputKOCount.TabIndex + 1;
            InputLevelMin.TabIndex = InputKOCount.TabIndex + 1;
            InputLevelMax.TabIndex = InputLevelMin.TabIndex + 1;
            InputSlotMin.TabIndex = InputLevelMax.TabIndex + 1;
            InputSlotMax.TabIndex = InputSlotMin.TabIndex + 1;
            ButtonSearch.TabIndex = InputSlotMax.TabIndex + 1;
            Results.TabIndex = ButtonSearch.TabIndex + 1;
            RetailAdvancesTrackerInitialInput.TabIndex = Results.TabIndex + 1;
            RetailAdvancesTrackerMaxInput.TabIndex = RetailAdvancesTrackerInitialInput.TabIndex + 1;
            RetailAdvancesTrackerGenerateButton.TabIndex = RetailAdvancesTrackerMaxInput.TabIndex + 1;
            RetailAdvancesTrackerSequenceInput.TabIndex = RetailAdvancesTrackerGenerateButton.TabIndex + 1;
            ButtonUpdateStates.TabIndex = RetailAdvancesTrackerSequenceInput.TabIndex + 1;
        }

        private void HpMinFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "0";
            hpMax.Clear();
            hpMax.Text = "0";
        }

        private void Filter_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 31) textBox.Text = "31";
            }

            else
            {
                textBox.Text = "0";
            }

        }

        private void LevelSlot_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 99) textBox.Text = "99";
            }
        }

        private void IVs_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 31) textBox.Text = "31";
            }
        }

        private void TIDSID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 0xFFFF) textBox.Text = "65535";
            }

            if (textBox.Name == "InputTID")
            {
                Properties.Settings.Default.TID = InputTID.Text;
            }
            else
            {
                Properties.Settings.Default.SID = InputSID.Text;
            }

            Properties.Settings.Default.Save();
        }

        private void SaveCheckbox_CheckChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "CheckShinyCharm":
                    Properties.Settings.Default.ShinyCharm = checkBox.Checked;
                    break;

                case "CheckMarkCharm":
                    Properties.Settings.Default.MarkCharm = checkBox.Checked;
                    break;
            }
            Properties.Settings.Default.Save();
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string stat = label.Name;

            switch (stat)
            {
                case "hpFilter":
                    hpMin.Text = "0";
                    hpMax.Text = "31";
                    break;

                case "atkFilter":
                    atkMin.Text = "0";
                    atkMax.Text = "31";
                    break;

                case "defFilter":
                    defMin.Text = "0";
                    defMax.Text = "31";
                    break;

                case "spaFilter":
                    spaMin.Text = "0";
                    spaMax.Text = "31";
                    break;

                case "spdFilter":
                    spdMin.Text = "0";
                    spdMax.Text = "31";
                    break;

                case "speFilter":
                    speMin.Text = "0";
                    speMax.Text = "31";
                    break;
            }
        }

        private void HpMaxFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "31";
            hpMax.Clear();
            hpMax.Text = "31";
        }

        private void AtkMinFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "0";
            atkMax.Clear();
            atkMax.Text = "0";
        }

        private void AtkMaxFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "31";
            atkMax.Clear();
            atkMax.Text = "31";
        }

        private void CheckStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStatic.Checked)
            {
                InputLevelMax.ReadOnly = true;
                InputLevelMin.ReadOnly = true;
                InputSlotMax.ReadOnly = true;
                InputSlotMin.ReadOnly = true;
                InputEMs.ReadOnly = true;
                InputKOCount.ReadOnly = true;
                CheckHeldItem.Enabled = false;
            }
            else
            {
                InputLevelMax.ReadOnly = false;
                InputLevelMin.ReadOnly = false;
                InputSlotMax.ReadOnly = false;
                InputSlotMin.ReadOnly = false;
                InputEMs.ReadOnly = false;
                InputKOCount.ReadOnly = false;
                CheckHeldItem.Enabled = true;
            }

        }


        private void DefMinFilter_Click(object sender, EventArgs e)
        {
            defMin.Clear();
            defMin.Text = "0";
            defMax.Clear();
            defMax.Text = "0";
        }



        private void SpaMinFilter_Click(object sender, EventArgs e)
        {
            spaMin.Clear();
            spaMin.Text = "0";
            spaMax.Clear();
            spaMax.Text = "0";
        }

        private void DefMaxFilter_Click(object sender, EventArgs e)
        {
            defMin.Clear();
            defMin.Text = "31";
            defMax.Clear();
            defMax.Text = "31";
        }

        private void SpaMaxFilter_Click(object sender, EventArgs e)
        {
            spaMin.Clear();
            spaMin.Text = "31";
            spaMax.Clear();
            spaMax.Text = "31";
        }

        private void SpdMinFilter_Click(object sender, EventArgs e)
        {
            spdMin.Clear();
            spdMin.Text = "0";
            spdMax.Clear();
            spdMax.Text = "0";
        }

        private void SpdMaxFilter_Click(object sender, EventArgs e)
        {
            spdMin.Clear();
            spdMin.Text = "31";
            spdMax.Clear();
            spdMax.Text = "31";
        }

        private void SpeMinFilter_Click(object sender, EventArgs e)
        {
            speMin.Clear();
            speMin.Text = "0";
            speMax.Clear();
            speMax.Text = "0";
        }

        private void SpeMaxFilter_Click(object sender, EventArgs e)
        {
            speMin.Clear();
            speMin.Text = "31";
            speMax.Clear();
            speMax.Text = "31";
        }


        private void InputStatePaste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V || e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert)
            {
                string NewText = "";

                foreach (char a in Clipboard.GetText())
                {
                    if ((a >= 'a' && a <= 'f') || (a >= 'A' && a <= 'F') || (a >= '0' && a <= '9'))
                    {
                        NewText += char.ToUpper(a);
                    }
                }

                if (NewText != "")
                {
                    Clipboard.SetText(NewText);
                }
                else
                { Clipboard.Clear(); }
            }
        }

        private void HexInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "";

            s += e.KeyChar;

            byte[] b = Encoding.ASCII.GetBytes(s);

            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                if (!(((0x30 <= b[0]) && (b[0] <= 0x39)) ||
                      ((0x41 <= b[0]) && (b[0] <= 0x46)) ||
                      ((0x61 <= b[0]) && (b[0] <= 0x66))))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void DecInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "";

            s += e.KeyChar;

            byte[] b = Encoding.ASCII.GetBytes(s);

            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                if (!(((0x30 <= b[0]) && (b[0] <= 0x39)) ||
                      (('z' <= b[0]) && (b[0] <= 'a')) ||
                      (('Z' <= b[0]) && (b[0] <= 'A'))))
                {
                    e.Handled = true;
                }
            }
        }

        private void BinInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "";

            s += e.KeyChar;

            byte[] b = Encoding.ASCII.GetBytes(s);

            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                if (!(('0' <= b[0]) && (b[0] <= '1')))
                {
                    e.Handled = true;
                }
            }
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            Pad(InputState0, '0', 16);
            Pad(InputState1, '0', 16);
            Pad(InputTID, '0', 5);
            Pad(InputSID, '0', 5);
            Pad(InputSlotMin, '0', 1);
            Pad(InputSlotMax, '0', 1);
            Pad(InputLevelMin, '0', 1);
            Pad(InputLevelMax, '0', 1);
            ulong s0 = UInt64.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = UInt64.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
            if (s0 == 0)
            {
                InputState0.Text = "1";
                Pad(InputState0, '0', 16);
                s0 = 1;
            }
            if (s1 == 0)
            {
                InputState1.Text = "1";
                Pad(InputState1, '0', 16);
                s1 = 1;
            }
            ulong advances = UInt64.Parse(InputMaxAdv.Text);
            if (advances == 0)
            {
                InputMaxAdv.Text = "1";
                advances = 1;
            }
            uint TID = UInt16.Parse(InputTID.Text);
            uint SID = UInt16.Parse(InputSID.Text);
            uint SlotMin = UInt16.Parse(InputSlotMin.Text);
            uint SlotMax = UInt16.Parse(InputSlotMax.Text);
            uint LevelMin = UInt16.Parse(InputLevelMin.Text);
            uint LevelMax = UInt16.Parse(InputLevelMax.Text);
            uint KOCount = UInt16.Parse(InputKOCount.Text);
            uint EMCount = UInt16.Parse(InputEMs.Text);
            uint FlawlessIVs = UInt16.Parse(InputFlawlessIVs.Text);
            bool ShinyCharm = CheckShinyCharm.Checked;
            bool MarkCharm = CheckMarkCharm.Checked;
            bool Weather = CheckWeather.Checked;
            bool Static = CheckStatic.Checked;
            bool Fishing = CheckFishing.Checked;
            bool HeldItem = CheckHeldItem.Checked;
            bool IsAbilityLocked = CheckIsAbilityLocked.Checked;
            bool TIDSIDSearch = CheckTIDSIDFinder.Checked;
            string DesiredMark = (string)SelectedMark.SelectedItem;
            string DesiredShiny = (string)SelectedShiny.SelectedItem;
            uint[] MinIVs = { UInt16.Parse(hpMin.Text), UInt16.Parse(atkMin.Text), UInt16.Parse(defMin.Text), UInt16.Parse(spaMin.Text), UInt16.Parse(spdMin.Text), UInt16.Parse(speMin.Text) };
            uint[] MaxIVs = { UInt16.Parse(hpMax.Text), UInt16.Parse(atkMax.Text), UInt16.Parse(defMax.Text), UInt16.Parse(spaMax.Text), UInt16.Parse(spdMax.Text), UInt16.Parse(speMax.Text) };
            int[] WrongIVs = new int[6];
            string message = "";
            string[] stats = { "HP", "Atk", "Def", "SpA", "SpD", "Spe" };
            int err = 0;

            for (int i = 0; i < MinIVs.Length; i++)
            {
                if (MinIVs[i] > MaxIVs[i])
                {
                    message += $"Error in stat filter: {stats[i]}!\n";
                    err = 1;
                }
            }

            if (err != 0)
            {
                message += "\nMin IV filter cannot be greater than Max IV filter!";
                string caption = "Error!";
                DialogResult result;
                result = MessageBox.Show(message, caption);
                return;
            }

            ButtonSearch.Text = "Calculating...";
            ButtonSearch.Enabled = false;

            Results.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            Results.Rows.Clear();
            Results.Columns["TID"].Visible = TIDSIDSearch;
            Results.Columns["SID"].Visible = TIDSIDSearch;
            Results.Columns["Level"].Visible = !Static;
            Results.Columns["Slot"].Visible = !Static;
            Results.Columns["Brilliant"].Visible = !Static;
            Results.Columns["Ability"].Visible = !IsAbilityLocked;

            progressBar1.Value = 0;
            progressBar1.Maximum = (int)advances;
            progressBar1.Step = progressBar1.Maximum / 100;

            var progress = new Progress<int>(v =>
            {
                progressBar1.PerformStep();
            });

            List<Frame> Frames = await Task.Run(() => Generator.Generate(
                s0, s1, advances, TID, SID, ShinyCharm, MarkCharm, Weather, Static, Fishing, HeldItem, DesiredMark, DesiredShiny,
                LevelMin, LevelMax, SlotMin, SlotMax, MinIVs, MaxIVs, IsAbilityLocked, EMCount, KOCount, FlawlessIVs, TIDSIDSearch, progress
            ));
            BindingSource Source = new BindingSource { DataSource = Frames };
            Results.DataSource = Source;
            Source.ResetBindings(false);


            progressBar1.Value = progressBar1.Maximum;
            ButtonSearch.Text = "Search!";
            ButtonSearch.Enabled = true;
        }

        private void Pad(object sender, char s, int length)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.PadLeft(length, s);
        }

        private string RetailAdvancesGeneratorString = String.Empty;
        private ulong RetailS0 = 1;
        private ulong RetailS1 = 1;
        private uint RetailInitial;
        private async void RetailAdvancesTrackerGenerateButton_Click(object sender, EventArgs e)
        {
            Pad(InputState0, '0', 16);
            Pad(InputState1, '0', 16);
            ulong s0 = UInt64.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = UInt64.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
            if (s0 == 0)
            {
                InputState0.Text = "1";
                Pad(InputState0, '0', 16);
                s0 = 1;
            }
            if (s1 == 0)
            {
                InputState1.Text = "1";
                Pad(InputState1, '0', 16);
                s1 = 1;
            }
            RetailS0 = s0;
            RetailS1 = s1;
            uint Initial = UInt32.Parse(RetailAdvancesTrackerInitialInput.Text);
            RetailInitial = Initial;
            uint Max = UInt32.Parse(RetailAdvancesTrackerMaxInput.Text);

            RetailAdvancesTrackerGenerateButton.Text = "Calculating...";
            RetailAdvancesTrackerGenerateButton.Enabled = false;
            RetailAdvancesTrackerSequenceInput.ReadOnly = true;

            RetailAdvancesTrackerProgressBar.Value = 0;
            RetailAdvancesTrackerProgressBar.Maximum = (int)(Initial + Max);
            RetailAdvancesTrackerProgressBar.Step = RetailAdvancesTrackerProgressBar.Maximum / 100;

            var progress = new Progress<int>(v =>
            {
                RetailAdvancesTrackerProgressBar.PerformStep();
            });

            RetailAdvancesGeneratorString = await Task.Run(() => Generator.GenerateRetailSequence(s0, s1, Initial, Max, progress));

            RetailAdvancesTrackerProgressBar.Value = RetailAdvancesTrackerProgressBar.Maximum;
            RetailAdvancesTrackerGenerateButton.Text = "Generate Pattern";
            RetailAdvancesTrackerGenerateButton.Enabled = true;
            RetailAdvancesTrackerSequenceInput.ReadOnly = false;
        }

        private void RetailAdvancesTrackerSequenceInput_TextChanged(object sender, EventArgs e)
        {
            List<int> res = new List<int>();
            string Text = RetailAdvancesTrackerSequenceInput.Text;
            int m = RetailAdvancesGeneratorString.Length;
            int l = Text.Length;
            if (l >= 5)
            {
                for (int i = 0; i < m; i++)
                {
                    int index = RetailAdvancesGeneratorString.IndexOf(Text, i);
                    if (index == -1) break;
                    res.Add(index);
                    i = index;
                }
                RetailAdvancesTrackerNumResultsLabel.Text = $"Possible Results: {res.Count} (Inputs: {l})";
                if (res.Count == 1)
                {
                    uint num = (uint)res[0] + (uint)Text.Length + RetailInitial;
                    RetailAdvancesTrackerNumResultsLabel.Text = $"Possible Results: 1 (Advances: {num} | Inputs {l})";
                    Xoroshiro go = new Xoroshiro(RetailS0, RetailS1);
                    for (int i = 0; i < num; i++)
                        go.next();

                    RetailAdvancesTrackerResultState0.Text = go.state0.ToString("X16");
                    RetailAdvancesTrackerResultState1.Text = go.state1.ToString("X16");
                }
            }
            else
            {
                RetailAdvancesTrackerNumResultsLabel.Text = $"Possible Results: Needs at least 5 inputs (Inputs: {l})";
            }
        }

        private void ButtonUpdateStates_Click(object sender, EventArgs e)
        {
            InputState0.Text = RetailAdvancesTrackerResultState0.Text;
            InputState1.Text = RetailAdvancesTrackerResultState1.Text;
        }

        private void SeedFinderMenu_Click(object sender, EventArgs e)
        {
            using (SeedFinder form1 = new SeedFinder())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.InputState0.Text = form1.State0;
                    this.InputState1.Text = form1.State1;
                }
            }
        }

        private void CheckTIDSIDFinder_CheckedChanged(object sender, EventArgs e)
        {
            bool check = this.CheckTIDSIDFinder.Checked;
            this.LabelTID.Enabled = !check;
            this.InputTID.Enabled = !check;
            this.LabelSID.Enabled = !check;
            this.InputSID.Enabled = !check;
            this.SelectedShiny.Enabled = !check;
            this.LabelShiny.Enabled = !check;
        }
    }
}
