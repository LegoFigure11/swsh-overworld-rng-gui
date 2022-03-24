using Microsoft.Toolkit.Uwp.Notifications;
using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator_GUI
{
    public partial class MainWindow : Form
    {
        public static SBBReader SwitchConnection = new();
        public MainWindow()
        {
            string build = String.Empty;
#if DEBUG
            var date = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly().Location);
            build = $" (dev-{date:yyyyMMdd})";
#endif
            var v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "SwSh OWRNG Generator GUI v" + v.Major + "." + v.Minor + "." + v.Build + build;

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchIPInput.Text = Properties.Settings.Default.SwitchIP;
            InputTID.Text = Properties.Settings.Default.TID;
            InputSID.Text = Properties.Settings.Default.SID;
            CheckShinyCharm.Checked = Properties.Settings.Default.ShinyCharm;
            CheckMarkCharm.Checked = Properties.Settings.Default.MarkCharm;

            SelectedMark.SelectedIndex = 0;
            SelectedShiny.SelectedIndex = 0;
            SelectedNature.SelectedIndex = 0;

            // Set Tab Indexes Manually
            // This will make life easier when adding more fields later on
            // (aka Lego can't find the button that made this nice to do)
            InputState0.TabIndex = 0;
            InputState1.TabIndex = InputState0.TabIndex + 1;
            InputTID.TabIndex = InputState1.TabIndex + 1;
            InputSID.TabIndex = InputTID.TabIndex + 1;
            InputInitialAdv.TabIndex = InputSID.TabIndex + 1;
            InputMaxAdv.TabIndex = InputInitialAdv.TabIndex + 1;
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
            hpJudgeFilter.TabIndex = hpMaxFilter.TabIndex + 1;
            atkMinFilter.TabIndex = hpJudgeFilter.TabIndex + 1;
            atkMaxFilter.TabIndex = atkMinFilter.TabIndex + 1;
            atkJudgeFilter.TabIndex = atkMaxFilter.TabIndex + 1;
            defMinFilter.TabIndex = atkJudgeFilter.TabIndex + 1;
            defMaxFilter.TabIndex = defMinFilter.TabIndex + 1;
            defJudgeFilter.TabIndex = defMaxFilter.TabIndex + 1;
            spaMinFilter.TabIndex = defJudgeFilter.TabIndex + 1;
            spaMaxFilter.TabIndex = spaMinFilter.TabIndex + 1;
            spaJudgeFilter.TabIndex = spaMaxFilter.TabIndex + 1;
            spdMinFilter.TabIndex = spaJudgeFilter.TabIndex + 1;
            spdMaxFilter.TabIndex = spdMinFilter.TabIndex + 1;
            spdJudgeFilter.TabIndex = spdMaxFilter.TabIndex + 1;
            speMinFilter.TabIndex = spdJudgeFilter.TabIndex + 1;
            speMaxFilter.TabIndex = speMinFilter.TabIndex + 1;
            speJudgeFilter.TabIndex = speMaxFilter.TabIndex + 1;
            SelectedMark.TabIndex = speJudgeFilter.TabIndex + 1;
            SelectedShiny.TabIndex = SelectedMark.TabIndex + 1;
            SelectedNature.TabIndex = SelectedShiny.TabIndex + 1;
            CheckShinyCharm.TabIndex = SelectedNature.TabIndex + 1;
            CheckStatic.TabIndex = CheckShinyCharm.TabIndex + 1;
            CheckMarkCharm.TabIndex = CheckStatic.TabIndex + 1;
            CheckFishing.TabIndex = CheckMarkCharm.TabIndex + 1;
            CheckWeather.TabIndex = CheckFishing.TabIndex + 1;
            CheckHeldItem.TabIndex = CheckWeather.TabIndex + 1;
            CheckIsAbilityLocked.TabIndex = CheckHeldItem.TabIndex + 1;
            CheckTIDSIDFinder.TabIndex = CheckIsAbilityLocked.TabIndex + 1;
            CheckCuteCharm.TabIndex = CheckTIDSIDFinder.TabIndex + 1;
            CheckShinyLocked.TabIndex = CheckCuteCharm.TabIndex + 1;
            InputFlawlessIVs.TabIndex = CheckShinyLocked.TabIndex + 1;
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
            sensBox.TabIndex = ButtonUpdateStates.TabIndex + 1;
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

        private void SetToZero_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
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

                switch (textBox.Name)
                {
                    case "hpMin":
                    case "hpMax":
                        JudgeFilterCompareIVs(UInt16.Parse(hpMin.Text), UInt16.Parse(hpMax.Text), hpJudgeFilter);
                        break;

                    case "atkMin":
                    case "atkMax":
                        JudgeFilterCompareIVs(UInt16.Parse(atkMin.Text), UInt16.Parse(atkMax.Text), atkJudgeFilter);
                        break;

                    case "defMin":
                    case "defMax":
                        JudgeFilterCompareIVs(UInt16.Parse(defMin.Text), UInt16.Parse(defMax.Text), defJudgeFilter);
                        break;

                    case "spaMin":
                    case "spaMax":
                        JudgeFilterCompareIVs(UInt16.Parse(spaMin.Text), UInt16.Parse(spaMax.Text), spaJudgeFilter);
                        break;

                    case "spdMin":
                    case "spdMax":
                        JudgeFilterCompareIVs(UInt16.Parse(spdMin.Text), UInt16.Parse(spdMax.Text), spdJudgeFilter);
                        break;

                    case "speMin":
                    case "speMax":
                        JudgeFilterCompareIVs(UInt16.Parse(speMin.Text), UInt16.Parse(speMax.Text), speJudgeFilter);
                        break;
                }
            }
        }

        private void JudgeFilterCompareIVs(uint min, uint max, ComboBox box)
        {
            box.SelectedIndexChanged -= this.JudgeFilter_SelectedIndexChanged;
            if (min == 0 && max == 0)
            {
                box.SelectedIndex = 0;
            }
            else if (min >= 1 && min <= 15 && max >= 1 && max <= 15)
            {
                box.SelectedIndex = 1;
            }
            else if (min >= 16 && min <= 25 && max >= 16 && max <= 25)
            {
                box.SelectedIndex = 2;
            }
            else if (min >= 26 && min <= 29 && max >= 26 && max <= 29)
            {
                box.SelectedIndex = 3;
            }
            else if (min == 30 && max == 30)
            {
                box.SelectedIndex = 4;
            }
            else if (min == 31 && max == 31)
            {
                box.SelectedIndex = 5;
            }
            else
            {
                box.SelectedIndex = -1;
            }
            box.SelectedIndexChanged += this.JudgeFilter_SelectedIndexChanged;
        }

        private void FlawlessIVs_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 6) textBox.Text = "6";
            }
        }

        private void CheckForIP(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text != "192.168.0.0")
            {
                Properties.Settings.Default.SwitchIP = SwitchIPInput.Text;
            }
            Properties.Settings.Default.Save();
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
                    hpJudgeFilter.SelectedIndex = -1;
                    break;

                case "atkFilter":
                    atkMin.Text = "0";
                    atkMax.Text = "31";
                    atkJudgeFilter.SelectedIndex = -1;
                    break;

                case "defFilter":
                    defMin.Text = "0";
                    defMax.Text = "31";
                    defJudgeFilter.SelectedIndex = -1;
                    break;

                case "spaFilter":
                    spaMin.Text = "0";
                    spaMax.Text = "31";
                    spaJudgeFilter.SelectedIndex = -1;
                    break;

                case "spdFilter":
                    spdMin.Text = "0";
                    spdMax.Text = "31";
                    spdJudgeFilter.SelectedIndex = -1;
                    break;

                case "speFilter":
                    speMin.Text = "0";
                    speMax.Text = "31";
                    speJudgeFilter.SelectedIndex = -1;
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
                    if ((a >= 'a' && a <= 'f') || (a >= 'A' && a <= 'F') || (a >= '0' && a <= '9') || a == (char)Keys.Return)
                    {
                        NewText += char.ToUpper(a);
                    }
                }

                if (NewText != "")
                {
                    if (((TextBox)sender).Name == "InputState0" && (NewText.Length == 32 || NewText.Length == 33))
                    {
                        if (NewText.Length == 32)
                        {
                            InputState1.Text = NewText.Substring(16, 16);
                        }
                        else
                        {
                            String[] States = NewText.Split((char)Keys.Return);
                            if (States[0].Length == 16 && States[1].Length == 16)
                            {
                                InputState1.Text = States[1];
                            }
                        }
                    }
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

            if (e.KeyChar == ',')
            {
                e.KeyChar = '0';
            }
            else if (e.KeyChar == '.')
            {
                e.KeyChar = '1';
            }

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
            Pad(InputMaxAdv, '0', 1);
            ulong advances = UInt64.Parse(InputMaxAdv.Text);
            if (advances == 0)
            {
                InputMaxAdv.Text = "1";
                advances = 1;
            }
            Pad(InputInitialAdv, '0', 1);
            ulong InitialAdvances = UInt64.Parse(InputInitialAdv.Text);
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
            bool IsCuteCharm = CheckCuteCharm.Checked;
            bool IsShinyLocked = CheckShinyLocked.Checked;
            string DesiredMark = (string)SelectedMark.SelectedItem;
            string DesiredShiny = (string)SelectedShiny.SelectedItem;
            string DesiredNature = (string)SelectedNature.SelectedItem;
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

            ToastNotificationManagerCompat.History.Clear();

            var progress = new Progress<int>(v =>
            {
                progressBar1.PerformStep();
            });

            List<Frame> Frames = await Task.Run(() => Generator.Generate(
                s0, s1, advances, TID, SID, ShinyCharm, MarkCharm, Weather, Static, Fishing, HeldItem, DesiredMark, DesiredShiny,
                DesiredNature, LevelMin, LevelMax, SlotMin, SlotMax, MinIVs, MaxIVs, IsAbilityLocked, EMCount, KOCount, FlawlessIVs,
                IsCuteCharm, IsShinyLocked, TIDSIDSearch, InitialAdvances, progress
            ));
            BindingSource Source = new() { DataSource = Frames };
            Results.DataSource = Source;
            Source.ResetBindings(false);


            progressBar1.Value = progressBar1.Maximum;
            ButtonSearch.Text = "Search!";
            ButtonSearch.Enabled = true;

            new ToastContentBuilder()
                .AddText(Frames.Count == 0 ? "You need better RNG!" : "Your search has finished!")
                .AddText($"Results found: {Frames.Count}")
                .Show();
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
            List<int> res = new();
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
                    Xoroshiro128Plus go = new(RetailS0, RetailS1);
                    for (int i = 0; i < num; i++)
                        go.Next();

                    (ulong s0, ulong s1) = go.GetState();
                    RetailAdvancesTrackerResultState0.Text = s0.ToString("X16");
                    RetailAdvancesTrackerResultState1.Text = s1.ToString("X16");
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
            using SeedFinder form1 = new();
            if (form1.ShowDialog() == DialogResult.OK)
            {
                this.InputState0.Text = form1.State0;
                this.InputState1.Text = form1.State1;
            }
        }

        private void CheckTIDSIDFinder_CheckedChanged(object sender, EventArgs e)
        {
            bool check = this.CheckTIDSIDFinder.Checked;
            this.LabelTIDSID.Enabled = !check;
            this.InputTID.Enabled = !check;
            this.LabelIDsSlash.Enabled = !check;
            this.InputSID.Enabled = !check;
            this.SelectedShiny.Enabled = !check;
            this.LabelShiny.Enabled = !check;
        }

        private void SensBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sensBox.Checked)
            {
                this.PID.Visible = false;
                this.EC.Visible = false;
                this.State0.Visible = false;
                this.State1.Visible = false;
                this.InputState0.UseSystemPasswordChar = true;
                this.InputState1.UseSystemPasswordChar = true;
                this.RetailAdvancesTrackerResultState0.UseSystemPasswordChar = true;
                this.RetailAdvancesTrackerResultState1.UseSystemPasswordChar = true;
            }
            else
            {
                this.PID.Visible = true;
                this.EC.Visible = true;
                this.State0.Visible = true;
                this.State1.Visible = true;
                this.InputState0.UseSystemPasswordChar = false;
                this.InputState1.UseSystemPasswordChar = false;
                this.RetailAdvancesTrackerResultState0.UseSystemPasswordChar = false;
                this.RetailAdvancesTrackerResultState1.UseSystemPasswordChar = false;
            }

        }

        private void SetIvFilters(TextBox statLower, TextBox statUpper, string min, string max)
        {
            statLower.Clear();
            statLower.Text = min;
            statUpper.Clear();
            statUpper.Text = max;
        }

        private void IvJudgeFilter(TextBox statL, TextBox statU, string judge)
        {
            switch (judge)
            {
                case "No Good":
                    SetIvFilters(statL, statU, "0", "0");
                    break;
                case "Decent":
                    SetIvFilters(statL, statU, "1", "15");
                    break;
                case "Pretty Good":
                    SetIvFilters(statL, statU, "16", "25");
                    break;
                case "Very Good":
                    SetIvFilters(statL, statU, "26", "29");
                    break;
                case "Fantastic":
                    SetIvFilters(statL, statU, "30", "30");
                    break;
                case "Best":
                    SetIvFilters(statL, statU, "31", "31");
                    break;
                default:
                    break;
            }
        }

        private void JudgeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).Name)
            {
                case "hpJudgeFilter":
                    IvJudgeFilter(hpMin, hpMax, hpJudgeFilter.Text);
                    break;

                case "atkJudgeFilter":
                    IvJudgeFilter(atkMin, atkMax, atkJudgeFilter.Text);
                    break;

                case "defJudgeFilter":
                    IvJudgeFilter(defMin, defMax, defJudgeFilter.Text);
                    break;

                case "spaJudgeFilter":
                    IvJudgeFilter(spaMin, spaMax, spaJudgeFilter.Text);
                    break;

                case "spdJudgeFilter":
                    IvJudgeFilter(spdMin, spdMax, spdJudgeFilter.Text);
                    break;

                case "speJudgeFilter":
                    IvJudgeFilter(speMin, speMax, speJudgeFilter.Text);
                    break;
            }
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            ToastNotificationManagerCompat.History.Clear();
            ToastNotificationManagerCompat.Uninstall();
        }

        public static Socket Connection;
        private async void Connect_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Program.Window.ConnectionStatusText.Text = "Connecting...";
                Connection = new(SocketType.Stream, ProtocolType.Tcp);
                Connection.Connect(Program.Window.SwitchIPInput.Text, 6000);
                Program.Window.ConnectionStatusText.Text = "Connected!";
                ChangeButtonState(Program.Window.ConnectButton, false);
                ChangeButtonState(Program.Window.DisconnectButton, true);
                var sav = await GetFakeTrainerSAV(CancellationToken.None).ConfigureAwait(false);
                await GetTIDSID(sav).ConfigureAwait(false);
                await ReadRNGState(CancellationToken.None);
            }
            catch (SocketException err)
            {
                // a bit hacky but it works
                if (err.Message.Contains("failed to respond"))
                {
                    LabelSetText(Program.Window.ConnectionStatusText, "Unable to connect.");
                    MessageBox.Show(err.Message);
                    ChangeButtonState(Program.Window.ConnectButton, true);
                    ChangeButtonState(Program.Window.DisconnectButton, false);
                }
                else
                {
                    LabelSetText(Program.Window.ConnectionStatusText, "Disconnected.");
                    MessageBox.Show($"Disconnected from {Program.Window.SwitchIPInput.Text}!");
                    ChangeButtonState(Program.Window.ConnectButton, true);
                    ChangeButtonState(Program.Window.DisconnectButton, false);
                }
            }
        }

        private async Task ReadRNGState(CancellationToken token)
        {
            if (UInt32.TryParse(Program.Window.InputRAMOffset.Text, NumberStyles.HexNumber, null, out uint Offset))
            {
                int TotalAdvances = 0;
                var (s0, s1) = await GetGlobalRNGState(Offset).ConfigureAwait(false);
                TextboxSetText(Program.Window.InputState0, $"{s0:x16}");
                TextboxSetText(Program.Window.InputState1, $"{s1:x16}");
                TextboxSetText(Program.Window.RetailAdvancesTrackerResultState0, $"{s0:x16}");
                TextboxSetText(Program.Window.RetailAdvancesTrackerResultState1, $"{s1:x16}");
                TextboxSetText(Program.Window.TrackAdv, $"{TotalAdvances:N0}");
                while (Connection.Connected)
                {
                    if (!Connection.Connected)
                        return;

                    var (_s0, _s1) = await GetGlobalRNGState(Offset).ConfigureAwait(false);
                    // Only update if it changed.
                    if (_s0 == s0 && _s1 == s1)
                        continue;


                    TextboxSetText(Program.Window.RetailAdvancesTrackerResultState0, $"{_s0:x16}");
                    TextboxSetText(Program.Window.RetailAdvancesTrackerResultState1, $"{_s1:x16}");

                    var passed = GetAdvancesPassed(s0, s1, _s0, _s1);
                    TotalAdvances += passed;
                    TextboxSetText(Program.Window.TrackAdv, $"{TotalAdvances:N0}");
                    // Store the state for the next pass.
                    s0 = _s0;
                    s1 = _s1;

                    if (!Connection.Connected)
                        return;
                }
            }
            else
            {
                Connection.Shutdown(SocketShutdown.Both);
                Connection.Disconnect(true);
                LabelSetText(Program.Window.ConnectionStatusText, "Disconnected.");
                Connection = new(SocketType.Stream, ProtocolType.Tcp);
                ChangeButtonState(Program.Window.ConnectButton, true);
                ChangeButtonState(Program.Window.DisconnectButton, false);
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (Connection.Connected)
            {
                Connection.Shutdown(SocketShutdown.Both);
                Connection.Disconnect(true);
                Program.Window.TrackAdv.Clear();
                LabelSetText(Program.Window.ConnectionStatusText, "Disconnected.");
                Connection = new(SocketType.Stream, ProtocolType.Tcp);
                ChangeButtonState(Program.Window.ConnectButton, true);
                ChangeButtonState(Program.Window.DisconnectButton, false);
            }
        }

        public async Task<(ulong s0, ulong s1)> GetGlobalRNGState(uint offset)
        {
            var data = await SwitchConnection.ReadBytesAsync(offset, 16).ConfigureAwait(false);
            var s0 = BitConverter.ToUInt64(data, 0);
            var s1 = BitConverter.ToUInt64(data, 8);
            return (s0, s1);
        }

        public int GetAdvancesPassed(ulong prevs0, ulong prevs1, ulong news0, ulong news1)
        {
            if (prevs0 == news0 && prevs1 == news1)
                return 0;

            var rng = new Xoroshiro128Plus(prevs0, prevs1);
            int i = 0;
            for (; i < 20_000; i++)
            {
                rng.NextInt(0xffffffff);
                var (s0, s1) = rng.GetState();
                if (s0 == news0 && s1 == news1)
                    return i + 1;
            }
            return i;
        }

        public async Task<SAV8SWSH> GetFakeTrainerSAV(CancellationToken token)
        {
            var sav = new SAV8SWSH();
            var info = sav.MyStatus;
            var read = await SwitchConnection.ReadBytesAsync(0x45068F18, 0x110).ConfigureAwait(false);
            read.CopyTo(info.Data, 0);
            return sav;
        }

        public async Task GetTIDSID(SAV8SWSH sav)
        {
            await Task.Delay(0_100).ConfigureAwait(false);
            TextboxSetText(Program.Window.InputTID, $"{sav.TID}");
            TextboxSetText(Program.Window.InputSID, sav.SID.ToString());
        }

        delegate void TextboxSetTextCallback(TextBox sender, string Text);
        delegate void LabelSetTextCallback(Label sender, string Text);
        delegate void ChangeButtonStateCallback(Button sender, bool State);
        private void TextboxSetText(TextBox sender, string Text)
        {
            if (sender.InvokeRequired)
            {
                TextboxSetTextCallback d = new(TextboxSetText);
                sender.Invoke(d, sender, Text);
            } 
            else
            {
                sender.Text = Text;
            }   
        }

        private void LabelSetText(Label sender, string Text)
        {
            if (sender.InvokeRequired)
            {
                LabelSetTextCallback d = new(LabelSetText);
                sender.Invoke(d, sender, Text);
            }
            else
            {
                sender.Text = Text;
            }
        }

        private void ChangeButtonState(Button sender, bool State)
        {
            if (sender.InvokeRequired)
            {
                ChangeButtonStateCallback d = new(ChangeButtonState);
                sender.Invoke(d, sender, State);
            }
            else
            {
                sender.Enabled = State;
            }
        }
    }
}
