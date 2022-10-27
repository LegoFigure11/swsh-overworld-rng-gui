using PKHeX.Core;
using PKHeX.Drawing.Misc;
using PKHeX.Drawing.PokeSprite;
using SWSH_OWRNG_Generator.Core.Overworld.Generators;
using SWSH_OWRNG_Generator.WinForms.Properties;
using SysBot.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class MainWindow : Form
    {
        private readonly static SwitchConnectionConfig Config = new() { Protocol = SwitchProtocol.WiFi, IP = Settings.Default.SwitchIP, Port = 6000 };
        public SwitchSocketAsync SwitchConnection = new(Config);

        public MainWindow()
        {
            string build = string.Empty;
#if DEBUG
            var date = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetEntryAssembly().Location);
            build = $" (dev-{date:yyyyMMdd})";
#endif
            var v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Text = "SwSh OWRNG Generator GUI v" + v.Major + "." + v.Minor + "." + v.Build + build;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchIPInput.Text = Settings.Default.SwitchIP;
            InputTID.Text = Settings.Default.TID;
            InputSID.Text = Settings.Default.SID;
            CheckShinyCharm.Checked = Settings.Default.ShinyCharm;
            CheckMarkCharm.Checked = Settings.Default.MarkCharm;
            CheckPlayTone.Checked = Settings.Default.PlayTone;
            CheckFocusWindow.Checked = Settings.Default.FocusWindow;

            SelectedMark.SelectedIndex = 0;
            SelectedShiny.SelectedIndex = 0;
            SelectedNature.SelectedIndex = 0;
            SelectedAura.SelectedIndex = 0;

            SpriteName.AllowShinySprite = true;

            // Set Tab Indexes Manually
            // This will make life easier when adding more fields later on
            // (aka Lego can't find the button that made this nice to do)
            int i = 0;
            InputState0.TabIndex = i++;
            InputState1.TabIndex = i++;
            InputTID.TabIndex = i++;
            InputSID.TabIndex = i++;
            CheckShinyCharm.TabIndex = i++;
            InputInitialAdv.TabIndex = i++;
            CheckMarkCharm.TabIndex = i++;
            InputMaxAdv.TabIndex = i++;
            CheckTIDSIDFinder.TabIndex = i++;
            // IVs
            hpMin.TabIndex = i++;
            hpMax.TabIndex = i++;
            atkMin.TabIndex = i++;
            atkMax.TabIndex = i++;
            defMin.TabIndex = i++;
            defMax.TabIndex = i++;
            spaMin.TabIndex = i++;
            spaMax.TabIndex = i++;
            spdMin.TabIndex = i++;
            spdMax.TabIndex = i++;
            speMin.TabIndex = i++;
            speMax.TabIndex = i++;
            hpMinFilter.TabIndex = i++;
            hpMaxFilter.TabIndex = i++;
            hpJudgeFilter.TabIndex = i++;
            atkMinFilter.TabIndex = i++;
            atkMaxFilter.TabIndex = i++;
            atkJudgeFilter.TabIndex = i++;
            defMinFilter.TabIndex = i++;
            defMaxFilter.TabIndex = i++;
            defJudgeFilter.TabIndex = i++;
            spaMinFilter.TabIndex = i++;
            spaMaxFilter.TabIndex = i++;
            spaJudgeFilter.TabIndex = i++;
            spdMinFilter.TabIndex = i++;
            spdMaxFilter.TabIndex = i++;
            spdJudgeFilter.TabIndex = i++;
            speMinFilter.TabIndex = i++;
            speMaxFilter.TabIndex = i++;
            speJudgeFilter.TabIndex = i++;
            // Checkboxes
            CheckStatic.TabIndex = i++;
            CheckWeather.TabIndex = i++;
            CheckFishing.TabIndex = i++;
            CheckHeldItem.TabIndex = i++;
            CheckCuteCharm.TabIndex = i++;
            CheckIsAbilityLocked.TabIndex = i++;
            CheckShinyLocked.TabIndex = i++;
            // Inputs
            InputKOCount.TabIndex = i++;
            InputFlawlessIVs.TabIndex = i++;
            InputEMs.TabIndex = i++;
            InputSlotMin.TabIndex = i++;
            InputSlotMax.TabIndex = i++;
            InputLevelMin.TabIndex = i++;
            InputLevelMax.TabIndex = i++;
            // Sensitive Info Box
            sensBox.TabIndex = i++;
            // Drop Downs
            SelectedNature.TabIndex = i++;
            SelectedShiny.TabIndex = i++;
            SelectedMark.TabIndex = i++;
            SelectedAura.TabIndex = i++;
            // Results
            ButtonSearch.TabIndex = i++;
            Results.TabIndex = i++;
            // Retail Advances Tracker
            RetailAdvancesTrackerInitialInput.TabIndex = i++;
            RetailAdvancesTrackerMaxInput.TabIndex = i++;
            RetailAdvancesTrackerGenerateButton.TabIndex = i++;
            RetailAdvancesTrackerSequenceInput.TabIndex = i++;
            ButtonUpdateStates.TabIndex = i++;
            // CFW Stuff
            InputRAMOffset.TabIndex = i++;
            SwitchIPInput.TabIndex = i++;
            ConnectButton.TabIndex = i++;
            DisconnectButton.TabIndex = i++;
            ReadEncounterButton.TabIndex = i++;
            DaySkipButton.TabIndex = i++;
        }

        private void Filter_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (int.TryParse(textBox.Text, out int i))
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
            if (long.TryParse(textBox.Text, out long i))
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
            if (int.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 99) textBox.Text = "99";
            }
        }

        private void IVs_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (int.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 31) textBox.Text = "31";

                switch (textBox.Name)
                {
                    case "hpMin":
                    case "hpMax":
                        JudgeFilterCompareIVs(ushort.Parse(hpMin.Text), ushort.Parse(hpMax.Text), hpJudgeFilter);
                        break;

                    case "atkMin":
                    case "atkMax":
                        JudgeFilterCompareIVs(ushort.Parse(atkMin.Text), ushort.Parse(atkMax.Text), atkJudgeFilter);
                        break;

                    case "defMin":
                    case "defMax":
                        JudgeFilterCompareIVs(ushort.Parse(defMin.Text), ushort.Parse(defMax.Text), defJudgeFilter);
                        break;

                    case "spaMin":
                    case "spaMax":
                        JudgeFilterCompareIVs(ushort.Parse(spaMin.Text), ushort.Parse(spaMax.Text), spaJudgeFilter);
                        break;

                    case "spdMin":
                    case "spdMax":
                        JudgeFilterCompareIVs(ushort.Parse(spdMin.Text), ushort.Parse(spdMax.Text), spdJudgeFilter);
                        break;

                    case "speMin":
                    case "speMax":
                        JudgeFilterCompareIVs(ushort.Parse(speMin.Text), ushort.Parse(speMax.Text), speJudgeFilter);
                        break;
                }
            }
        }

        private void JudgeFilterCompareIVs(uint min, uint max, ComboBox box)
        {
            box.SelectedIndexChanged -= JudgeFilter_SelectedIndexChanged;
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
            box.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
        }

        private void FlawlessIVs_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (int.TryParse(textBox.Text, out int i))
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
                Settings.Default.SwitchIP = SwitchIPInput.Text;
                Config.IP = SwitchIPInput.Text;
            }
            Settings.Default.Save();
        }

        private void TIDSID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (int.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 0xFFFF) textBox.Text = "65535";
            }

            if (textBox.Name == "InputTID")
            {
                Settings.Default.TID = InputTID.Text;
            }
            else
            {
                Settings.Default.SID = InputSID.Text;
            }
            Settings.Default.Save();
        }

        private void SaveCheckbox_CheckChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "CheckShinyCharm":
                    Settings.Default.ShinyCharm = checkBox.Checked;
                    break;

                case "CheckMarkCharm":
                    Settings.Default.MarkCharm = checkBox.Checked;
                    break;
            }
            Settings.Default.Save();
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

        private void StatMinFilter_Click(object sender, EventArgs e)
        {
            string Min = "0";
            string Max = ModifierKeys == Keys.Shift ? "1" : "0";
            switch (((Button)sender).Name)
            {
                case "hpMinFilter":
                    SetIvFilters(hpMin, hpMax, Min, Max);
                    break;
                case "atkMinFilter":
                    SetIvFilters(atkMin, atkMax, Min, Max);
                    break;
                case "defMinFilter":
                    SetIvFilters(defMin, defMax, Min, Max);
                    break;
                case "spaMinFilter":
                    SetIvFilters(spaMin, spaMax, Min, Max);
                    break;
                case "spdMinFilter":
                    SetIvFilters(spdMin, spdMax, Min, Max);
                    break;
                case "speMinFilter":
                    SetIvFilters(speMin, speMax, Min, Max);
                    break;
            }
        }

        private void StatMaxFilter_Click(object sender, EventArgs e)
        {
            string Min = ModifierKeys == Keys.Shift ? "30" : "31";
            string Max = "31";
            switch (((Button)sender).Name)
            {
                case "hpMaxFilter":
                    SetIvFilters(hpMin, hpMax, Min, Max);
                    break;
                case "atkMaxFilter":
                    SetIvFilters(atkMin, atkMax, Min, Max);
                    break;
                case "defMaxFilter":
                    SetIvFilters(defMin, defMax, Min, Max);
                    break;
                case "spaMaxFilter":
                    SetIvFilters(spaMin, spaMax, Min, Max);
                    break;
                case "spdMaxFilter":
                    SetIvFilters(spdMin, spdMax, Min, Max);
                    break;
                case "speMaxFilter":
                    SetIvFilters(speMin, speMax, Min, Max);
                    break;
            }
        }

        private void CheckStatic_CheckedChanged(object sender, EventArgs e)
        {
            bool check = CheckStatic.Checked;
            InputLevelMax.ReadOnly = check;
            InputLevelMin.ReadOnly = check;
            InputSlotMax.ReadOnly = check;
            InputSlotMin.ReadOnly = check;
            InputEMs.ReadOnly = check;
            InputKOCount.ReadOnly = check;
            CheckHeldItem.Enabled = !check;
            SelectedAura.Enabled = !check;
            CheckHidden.Enabled = !check;
        }

        private void InputStatePaste_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control && e.KeyCode == Keys.V) || (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert))
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
                            string[] States = NewText.Split((char)Keys.Return);
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

        public void HexInput_KeyPress(object sender, KeyPressEventArgs e)
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

        public void DecInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private readonly CancellationTokenSource Source = new();

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            FormWindowState _FormWindowState = WindowState;
            if (ButtonSearch.Text == "Cancel")
            {
                if (Source != null) Source.Cancel();
            }
            else
            {
                Pad(InputState0, '0', 16);
                Pad(InputState1, '0', 16);
                Pad(InputTID, '0', 5);
                Pad(InputSID, '0', 5);
                Pad(InputSlotMin, '0', 1);
                Pad(InputSlotMax, '0', 1);
                Pad(InputLevelMin, '0', 1);
                Pad(InputLevelMax, '0', 1);
                ulong s0 = ulong.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
                ulong s1 = ulong.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
                Pad(InputMaxAdv, '0', 1);
                ulong advances = ulong.Parse(InputMaxAdv.Text);
                if (advances == 0)
                {
                    InputMaxAdv.Text = "1";
                    advances = 1;
                }
                Pad(InputInitialAdv, '0', 1);
                ulong InitialAdvances = ulong.Parse(InputInitialAdv.Text);
                Pad(InputNPCs, '0', 1);
                uint NPCs = 0;
                if (CheckMenuClose.Checked)
                {
                    NPCs = uint.Parse(InputNPCs.Text) + 1;
                }
                Core.Overworld.Filter Filters = new()
                {
                    TSV = Core.Util.Common.GetTSV(ushort.Parse(InputTID.Text), ushort.Parse(InputSID.Text)),
                    SlotMin = ushort.Parse(InputSlotMin.Text),
                    SlotMax = ushort.Parse(InputSlotMax.Text),
                    LevelMin = ushort.Parse(InputLevelMin.Text),
                    LevelMax = ushort.Parse(InputLevelMax.Text),
                    KOs = ushort.Parse(InputKOCount.Text),
                    EggMoveCount = ushort.Parse(InputEMs.Text),
                    FlawlessIVs = ushort.Parse(InputFlawlessIVs.Text),
                    ShinyRolls = CheckShinyCharm.Checked ? 3 : 1,
                    MarkRolls = CheckMarkCharm.Checked ? 3 : 1,
                    Weather = CheckWeather.Checked,
                    Static = CheckStatic.Checked,
                    Fishing = CheckFishing.Checked,
                    HeldItem = CheckHeldItem.Checked,
                    AbilityLocked = CheckIsAbilityLocked.Checked,
                    TIDSIDSearch = CheckTIDSIDFinder.Checked,
                    CuteCharm = CheckCuteCharm.Checked,
                    ShinyLocked = CheckShinyLocked.Checked,
                    Hidden = CheckHidden.Checked,
                    MenuClose = CheckMenuClose.Checked,
                    DesiredMark = (string)SelectedMark.SelectedItem,
                    DesiredShiny = (string)SelectedShiny.SelectedItem,
                    DesiredNature = (string)SelectedNature.SelectedItem,
                    DesiredAura = (string)SelectedAura.SelectedItem,
                    MinIVs = new uint[] { ushort.Parse(hpMin.Text), ushort.Parse(atkMin.Text), ushort.Parse(defMin.Text), ushort.Parse(spaMin.Text), ushort.Parse(spdMin.Text), ushort.Parse(speMin.Text) },
                    MaxIVs = new uint[] { ushort.Parse(hpMax.Text), ushort.Parse(atkMax.Text), ushort.Parse(defMax.Text), ushort.Parse(spaMax.Text), ushort.Parse(spdMax.Text), ushort.Parse(speMax.Text) }
                };

                int[] WrongIVs = new int[6];
                string message = "";
                string[] stats = { "HP", "Atk", "Def", "SpA", "SpD", "Spe" };
                int err = 0;

                for (int i = 0; i < Filters.MinIVs.Length; i++)
                {
                    if (Filters.MinIVs[i] > Filters.MaxIVs[i])
                    {
                        message += $"Error in stat filter: {stats[i]}!\n";
                        err = 1;
                    }
                }

                if (err != 0)
                {
                    message += "\nMin IV filter cannot be greater than Max IV filter!";
                    const string caption = "Error!";
                    DialogResult result = MessageBox.Show(message, caption);
                    return;
                }

                ButtonSearch.Text = "Cancel";

                Results.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                Results.Rows.Clear();
                Results.Columns["TID"].Visible = Filters.TIDSIDSearch;
                Results.Columns["SID"].Visible = Filters.TIDSIDSearch;
                Results.Columns["Level"].Visible = !Filters.Static;
                Results.Columns["Slot"].Visible = !Filters.Static;
                Results.Columns["Brilliant"].Visible = !Filters.Static;
                Results.Columns["Ability"].Visible = !Filters.AbilityLocked;
                Results.Columns["Jump"].Visible = Filters.MenuClose;

                progressBar1.Value = 0;
                progressBar1.Maximum = (int)advances;
                progressBar1.Step = progressBar1.Maximum / 100;

                var progress = new Progress<int>(_ => progressBar1.PerformStep());

                List<Core.Overworld.Frame> Frames;
                if (Filters.Static)
                {
                    Frames = await Task.Run(() => Static.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs), CancellationToken.None);
                }
                else if (Filters.Hidden)
                {
                    Frames = await Task.Run(() => Hidden.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs), CancellationToken.None);
                }
                else if (Filters.Fishing)
                {
                    Frames = await Task.Run(() => Fishing.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs), CancellationToken.None);
                }
                /* else if (Filters.TIDSIDSearch)
                 * {
                 *      Frames = await Task.Run(() => TIDSID.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs), CancellationToken.None);
                 * }
                 * else
                 */
                else if (!Filters.TIDSIDSearch)
                {
                    Frames = await Task.Run(() => Symbol.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs), CancellationToken.None);
                }
                else
                {
                    Frames = await Task.Run(() => Generator.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs), CancellationToken.None);
                }
                ButtonSearch.Text = $"Preparing {Frames.Count:N0} results...";
                ButtonSearch.Enabled = false;
                BindingSource Source = new() { DataSource = Frames };
                Results.DataSource = Source;
                Source.ResetBindings(false);
            }
            progressBar1.Value = progressBar1.Maximum;
            ButtonSearch.Enabled = true;

            if (CheckPlayTone.Checked)
            {
                System.Media.SystemSounds.Asterisk.Play();
            }

            if (CheckFocusWindow.Checked)
            {
                WindowState = _FormWindowState;
                Activate();
            }

            ButtonSearch.Text = "Search!";
        }

        public static void Pad(object sender, char s, int length)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.PadLeft(length, s);
        }

        private string RetailAdvancesGeneratorString = string.Empty;
        private ulong RetailS0 = 1;
        private ulong RetailS1 = 1;
        private uint RetailInitial;
        private async void RetailAdvancesTrackerGenerateButton_Click(object sender, EventArgs e)
        {
            Pad(InputState0, '0', 16);
            Pad(InputState1, '0', 16);
            ulong s0 = ulong.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = ulong.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
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
            uint Initial = uint.Parse(RetailAdvancesTrackerInitialInput.Text);
            RetailInitial = Initial;
            uint Max = uint.Parse(RetailAdvancesTrackerMaxInput.Text);

            RetailAdvancesTrackerGenerateButton.Text = "Calculating...";
            RetailAdvancesTrackerGenerateButton.Enabled = false;
            RetailAdvancesTrackerSequenceInput.ReadOnly = true;

            RetailAdvancesTrackerProgressBar.Value = 0;
            RetailAdvancesTrackerProgressBar.Maximum = (int)(Initial + Max);
            RetailAdvancesTrackerProgressBar.Step = RetailAdvancesTrackerProgressBar.Maximum / 100;

            var progress = new Progress<int>(_ => RetailAdvancesTrackerProgressBar.PerformStep());

            RetailAdvancesGeneratorString = await Task.Run(() => Core.Util.Common.GenerateRetailSequence(s0, s1, Initial, Max, progress));

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
            bool check = sensBox.Checked;
            this.PID.Visible = !check;
            this.EC.Visible = !check;
            this.State0.Visible = !check;
            this.State1.Visible = !check;
            this.InputState0.UseSystemPasswordChar = check;
            this.InputState1.UseSystemPasswordChar = check;
            this.RetailAdvancesTrackerResultState0.UseSystemPasswordChar = check;
            this.RetailAdvancesTrackerResultState1.UseSystemPasswordChar = check;
        }

        private static void SetIvFilters(TextBox statLower, TextBox statUpper, string min, string max)
        {
            statLower.Clear();
            statLower.Text = min;
            statUpper.Clear();
            statUpper.Text = max;
        }

        private static void IvJudgeFilter(TextBox statL, TextBox statU, string judge)
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

        private bool ShouldReadState = true;

        private async void Connect_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Program.Window.ConnectionStatusText.Text = "Connecting...";
                SwitchConnection.Connect();
                Program.Window.ConnectionStatusText.Text = "Connected!";
                ChangeButtonState(Program.Window.ConnectButton, false);
                ChangeButtonState(Program.Window.DisconnectButton, true);
                ChangeButtonState(Program.Window.ReadEncounterButton, true);
                ChangeButtonState(Program.Window.DaySkipButton, true);
                ChangeButtonState(Program.Window.ShortSkipButton, true);
                ChangeTextBoxState(Program.Window.SkipAmountInput, true);
                var sav = await GetFakeTrainerSAV(CancellationToken.None).ConfigureAwait(false);
                await GetTIDSID(sav).ConfigureAwait(false);
                await ReadRNGState(CancellationToken.None).ConfigureAwait(false);
            }
            catch (SocketException err)
            {
                // a bit hacky but it works
                if (err.Message.Contains("failed to respond"))
                {
                    LabelSetText(Program.Window.ConnectionStatusText, "Unable to connect.");
                    MessageBox.Show(err.Message);
                }
                else
                {
                    LabelSetText(Program.Window.ConnectionStatusText, "Disconnected.");
                    MessageBox.Show($"Disconnected from {Program.Window.SwitchIPInput.Text}!");
                }
                ChangeButtonState(Program.Window.ConnectButton, true);
                ChangeButtonState(Program.Window.DisconnectButton, false);
                ChangeButtonState(Program.Window.ReadEncounterButton, false);
                ChangeButtonState(Program.Window.DaySkipButton, false);
                ChangeButtonState(Program.Window.ShortSkipButton, false);
                ChangeTextBoxState(Program.Window.SkipAmountInput, false);
            }
        }

        private async Task ReadRNGState(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (!ShouldReadState)
                    continue;
                if (uint.TryParse(Program.Window.InputRAMOffset.Text, NumberStyles.HexNumber, null, out uint Offset))
                {
                    ulong TotalAdvances = 0;
                    var (s0, s1) = await GetGlobalRNGState(Offset, token).ConfigureAwait(false);
                    TextboxSetText(Program.Window.InputState0, $"{s0:x16}");
                    TextboxSetText(Program.Window.InputState1, $"{s1:x16}");
                    TextboxSetText(Program.Window.RetailAdvancesTrackerResultState0, $"{s0:x16}");
                    TextboxSetText(Program.Window.RetailAdvancesTrackerResultState1, $"{s1:x16}");
                    TextboxSetText(Program.Window.TrackAdv, $"{TotalAdvances:N0}");
                    while (SwitchConnection.Connected)
                    {
                        if (!SwitchConnection.Connected)
                            return;

                        if (!ShouldReadState)
                            continue;

                        var (_s0, _s1) = await GetGlobalRNGState(Offset, token).ConfigureAwait(false);
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

                        if (!SwitchConnection.Connected)
                            return;
                    }
                }
                else
                {
                    SwitchConnection.Disconnect();
                    LabelSetText(Program.Window.ConnectionStatusText, "Disconnected.");
                    ChangeButtonState(Program.Window.ConnectButton, true);
                    ChangeButtonState(Program.Window.DisconnectButton, false);
                }
            }
        }

        public static bool HasMark(IRibbonIndex pk, out RibbonIndex result)
        {
            result = default;
            for (var mark = RibbonIndex.MarkLunchtime; mark <= RibbonIndex.MarkSlump; mark++)
            {
                if (pk.GetRibbon((int)mark))
                {
                    result = mark;
                    return true;
                }
            }
            return false;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (SwitchConnection.Connected)
            {
                SwitchConnection.Disconnect();
                Program.Window.TrackAdv.Clear();
                LabelSetText(Program.Window.ConnectionStatusText, "Disconnected.");
                ChangeButtonState(Program.Window.ConnectButton, true);
                ChangeButtonState(Program.Window.DisconnectButton, false);
            }
        }

        public async Task<(ulong s0, ulong s1)> GetGlobalRNGState(uint offset, CancellationToken token)
        {
            var data = await SwitchConnection.ReadBytesAsync(offset, 16, token).ConfigureAwait(false);
            var s0 = BitConverter.ToUInt64(data, 0);
            var s1 = BitConverter.ToUInt64(data, 8);
            return (s0, s1);
        }

        public static ulong GetAdvancesPassed(ulong prevs0, ulong prevs1, ulong news0, ulong news1)
        {
            if (prevs0 == news0 && prevs1 == news1)
                return 0;

            var rng = new Xoroshiro128Plus(prevs0, prevs1);
            ulong i = 0;
            for (; i < 20_000; i++) // 20,000 is an arbitrary number to prevent an infinite loop
            {
                rng.Next();
                var (s0, s1) = rng.GetState();
                if (s0 == news0 && s1 == news1)
                    return ++i;
            }
            return i;
        }

        public async Task<SAV8SWSH> GetFakeTrainerSAV(CancellationToken token)
        {
            var sav = new SAV8SWSH();
            var info = sav.MyStatus;
            var read = await SwitchConnection.ReadBytesAsync(0x45068F18, 0x110, token).ConfigureAwait(false);
            read.CopyTo(info.Data, 0);
            return sav;
        }

        public async Task GetTIDSID(SAV8SWSH sav)
        {
            await Task.Delay(0_100).ConfigureAwait(false);
            TextboxSetText(Program.Window.InputTID, sav.TID.ToString());
            TextboxSetText(Program.Window.InputSID, sav.SID.ToString());
        }

        delegate void TextboxSetTextCallback(TextBox sender, string Text);
        delegate void LabelSetTextCallback(Label sender, string Text);
        delegate void ButtonSetTextCallback(Button sender, string Text);
        delegate void ChangeButtonStateCallback(Button sender, bool State);
        delegate void ChangeTextBoxStateCallback(TextBox sender, bool State);
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

        private void ButtonSetText(Button sender, string Text)
        {
            if (sender.InvokeRequired)
            {
                ButtonSetTextCallback d = new(ButtonSetText);
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

        private void ChangeTextBoxState(TextBox sender, bool State)
        {
            if (sender.InvokeRequired)
            {
                ChangeTextBoxStateCallback d = new(ChangeTextBoxState);
                sender.Invoke(d, sender, State);
            }
            else
            {
                sender.Enabled = State;
            }
        }

        public async Task<PK8> ReadPokemon(uint offset, int size)
        {
            var data = await SwitchConnection.ReadBytesAsync(offset, size, CancellationToken.None).ConfigureAwait(false);
            return new PK8(data);
        }

        public bool UseCRLF = true;

        public async Task DaySkip(CancellationToken token) => await SwitchConnection.SendAsync(SwitchCommand.DaySkip(UseCRLF), token).ConfigureAwait(false);
        public async Task ResetTime(CancellationToken token) => await SwitchConnection.SendAsync(SwitchCommand.ResetTime(UseCRLF), token).ConfigureAwait(false);
        public async Task DoAnimation(CancellationToken token) => await SwitchConnection.SendAsync(SwitchCommand.Click(SwitchButton.LSTICK, UseCRLF), token).ConfigureAwait(false);
        public async Task DetatchController(CancellationToken token) => await SwitchConnection.SendAsync(SwitchCommand.DetachController(UseCRLF), token).ConfigureAwait(false);

        private async void DaySkip_Click(object sender, EventArgs e)
        {
            if (SwitchConnection.Connected)
            {
                int output = int.Parse(SkipAmountInput.Text);
                ChangeButtonState(Program.Window.DaySkipButton, false);
                ChangeButtonState(Program.Window.ShortSkipButton, false);
                ButtonSetText(Program.Window.DaySkipButton, "Skipping...");
                for (int i = 0; i < output && SwitchConnection.Connected; i++)
                {
                    await DaySkip(CancellationToken.None).ConfigureAwait(false);
                    ButtonSetText(Program.Window.DaySkipButton, $"{i + 1}/{output}");
                    await Task.Delay(0_360).ConfigureAwait(false);
                }
                if (SwitchConnection.Connected)
                    await ResetTime(CancellationToken.None).ConfigureAwait(false);
                ChangeButtonState(Program.Window.DaySkipButton, true);
                ChangeButtonState(Program.Window.ShortSkipButton, true);
                ButtonSetText(Program.Window.DaySkipButton, "Days");
            }
        }

        private async void ReadEncounter_ClickAsync(object sender, EventArgs e)
        {
            ShouldReadState = false;
            ChangeButtonState(Program.Window.ReadEncounterButton, false);
            if (SwitchConnection.Connected)
            {
                TextboxSetText(Program.Window.TextBoxCheckEncounter, "Reading encounter...");
                await Task.Delay(0_500).ConfigureAwait(false); // Give state reads time to complete
                uint offset = 0x8FEA3648;
                PK8 pk = await ReadPokemon(offset, 0x158).ConfigureAwait(false);
                if (pk.Species == 0 || pk.Species > 0 && pk.Species > 899)
                {
                    TextboxSetText(Program.Window.TextBoxCheckEncounter, "No encounter present.");
                    PokeSprite.Image = null;
                    MarkSprite.Image = null;
                    ShouldReadState = true;
                    ChangeButtonState(Program.Window.ReadEncounterButton, true);
                    return;
                }
                bool hasMark = HasMark(pk, out RibbonIndex mark);
                bool isSquare = pk.ShinyXor == 0;
                string markString = hasMark ? $"Mark: {mark.ToString().Replace("Mark", "")}" : string.Empty;
                string form = pk.Form == 0 ? "" : $"-{pk.Form}";
                string gender = pk.Gender switch
                {
                    0 => " (M)",
                    1 => " (F)",
                    _ => string.Empty
                };
                string PIDstring = sensBox.Checked ? $"****{pk.PID & 0xFFFF:X4}" : $"{pk.PID:X8}";
                string ECstring = sensBox.Checked ? $"****{pk.EncryptionConstant & 0xFFFF:X4}" : $"{pk.EncryptionConstant:X8}";
                string output = $"{(isSquare ? "■ - " : pk.ShinyXor <= 16 ? "★ - " : "")}{(Species)pk.Species}{form}{gender}{Environment.NewLine}PID: {PIDstring}{Environment.NewLine}EC: {ECstring}{Environment.NewLine}{GameInfo.GetStrings(1).Natures[pk.Nature]} Nature{Environment.NewLine}Ability: {GameInfo.GetStrings(1).Ability[pk.Ability]}{Environment.NewLine}IVs: {pk.IV_HP}/{pk.IV_ATK}/{pk.IV_DEF}/{pk.IV_SPA}/{pk.IV_SPD}/{pk.IV_SPE}{Environment.NewLine}{markString}";

                if (pk.Species > 0 && pk.Species <= 899)
                {
                    TextboxSetText(Program.Window.TextBoxCheckEncounter, output);
                    var img = pk.Sprite();
                    PokeSprite.Image = img;
                    if (hasMark)
                    {
                        var info = RibbonInfo.GetRibbonInfo(pk);
                        foreach (var rib in info)
                        {
                            if (!rib.HasRibbon)
                                continue;

                            var mimg = RibbonSpriteUtil.GetRibbonSprite(rib.Name);
                            if (mimg is not null)
                            {
                                MarkSprite.Image = mimg;
                            }
                        }
                    }
                    else if (!hasMark)
                    {
                        MarkSprite.Image = null;
                    }
                }
            }
            ShouldReadState = true;
            ChangeButtonState(Program.Window.ReadEncounterButton, true);
        }

        private void CheckHidden_CheckedChanged(object sender, EventArgs e)
        {
            bool check = CheckHidden.Checked;
            CheckStatic.Enabled = !check;
            SelectedAura.Enabled = !check;
            InputKOCount.ReadOnly = check;
            InputEMs.ReadOnly = check;
            Brilliant.Visible = !check;
        }

        private void EncounterLookupMenu_Click(object sender, EventArgs e)
        {
            using EncounterLookup EncounterLookupForm = new(this);
            EncounterLookupForm.ShowDialog();
        }

        private void CramomaticMenu_Click(object sender, EventArgs e)
        {
            using Cram_o_matic CramomaticForm = new(this);
            CramomaticForm.ShowDialog();
        }

        private void LotoIDMenu_Click(object sender, EventArgs e)
        {
            using Loto_ID LotoIDForm = new(this);
            LotoIDForm.ShowDialog();
        }

        private async void ShortSkipButton_Click(object sender, EventArgs e)
        {
            if (SwitchConnection.Connected)
            {
                int output = int.Parse(SkipAmountInput.Text);
                ChangeButtonState(Program.Window.ShortSkipButton, false);
                ChangeButtonState(Program.Window.DaySkipButton, false);
                ButtonSetText(Program.Window.ShortSkipButton, "Skipping...");
                for (int i = 0; i < output && SwitchConnection.Connected; i++)
                {
                    await DoAnimation(CancellationToken.None).ConfigureAwait(false);
                    ButtonSetText(Program.Window.ShortSkipButton, $"{i + 1}/{output}");
                    await Task.Delay(0_150).ConfigureAwait(false);
                }
                ChangeButtonState(Program.Window.ShortSkipButton, true);
                ChangeButtonState(Program.Window.DaySkipButton, true);
                if (SwitchConnection.Connected)
                    await DetatchController(CancellationToken.None);
                ButtonSetText(Program.Window.ShortSkipButton, "Adv.");
            }
        }

        private void MenuCloseAdvancesViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using MenuCloseTimeline MenuCloseTimelineForm = new(this);
            MenuCloseTimelineForm.ShowDialog();
        }

        private void CheckMenuClose_CheckedChanged(object sender, EventArgs e)
        {
            InputNPCs.Enabled = CheckMenuClose.Checked;
        }

        private void CheckFocusWindow_CheckChanged(object sender, EventArgs e)
        {
            Settings.Default.FocusWindow = CheckFocusWindow.Checked;
            Settings.Default.Save();
        }

        private void CheckPlayTone_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.PlayTone = CheckPlayTone.Checked;
            Settings.Default.Save();
        }
    }
}
