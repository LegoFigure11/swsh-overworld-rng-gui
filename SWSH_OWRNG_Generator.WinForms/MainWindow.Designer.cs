using System.Windows.Forms;

namespace SWSH_OWRNG_Generator.WinForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LabelState0 = new System.Windows.Forms.Label();
            this.InputState0 = new System.Windows.Forms.TextBox();
            this.InputState1 = new System.Windows.Forms.TextBox();
            this.LabelState1 = new System.Windows.Forms.Label();
            this.hpMin = new System.Windows.Forms.TextBox();
            this.hpMax = new System.Windows.Forms.TextBox();
            this.hpFilter = new System.Windows.Forms.Label();
            this.atkFilter = new System.Windows.Forms.Label();
            this.defFilter = new System.Windows.Forms.Label();
            this.spaFilter = new System.Windows.Forms.Label();
            this.spdFilter = new System.Windows.Forms.Label();
            this.speFilter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hpMinFilter = new System.Windows.Forms.Button();
            this.hpMaxFilter = new System.Windows.Forms.Button();
            this.InputTID = new System.Windows.Forms.TextBox();
            this.InputSID = new System.Windows.Forms.TextBox();
            this.LabelTIDSID = new System.Windows.Forms.Label();
            this.LabelIDsSlash = new System.Windows.Forms.Label();
            this.InputMaxAdv = new System.Windows.Forms.TextBox();
            this.LabelMaxAdv = new System.Windows.Forms.Label();
            this.LabelMark = new System.Windows.Forms.Label();
            this.ImageRareMark = new System.Windows.Forms.PictureBox();
            this.SelectedMark = new System.Windows.Forms.ComboBox();
            this.CheckShinyCharm = new System.Windows.Forms.CheckBox();
            this.CheckMarkCharm = new System.Windows.Forms.CheckBox();
            this.CheckWeather = new System.Windows.Forms.CheckBox();
            this.CheckStatic = new System.Windows.Forms.CheckBox();
            this.CheckFishing = new System.Windows.Forms.CheckBox();
            this.CheckHeldItem = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.InputLevelMax = new System.Windows.Forms.TextBox();
            this.InputLevelMin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.InputSlotMax = new System.Windows.Forms.TextBox();
            this.InputSlotMin = new System.Windows.Forms.TextBox();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelSlot = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.SelectedShiny = new System.Windows.Forms.ComboBox();
            this.LabelShiny = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.DataGridView();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brilliant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Def = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.speMinFilter = new System.Windows.Forms.Button();
            this.defMax = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.spdMinFilter = new System.Windows.Forms.Button();
            this.spdMaxFilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.speMaxFilter = new System.Windows.Forms.Button();
            this.spaMin = new System.Windows.Forms.TextBox();
            this.atkMinFilter = new System.Windows.Forms.Button();
            this.spdMin = new System.Windows.Forms.TextBox();
            this.spdMax = new System.Windows.Forms.TextBox();
            this.speMin = new System.Windows.Forms.TextBox();
            this.speMax = new System.Windows.Forms.TextBox();
            this.atkMax = new System.Windows.Forms.TextBox();
            this.atkMaxFilter = new System.Windows.Forms.Button();
            this.defMin = new System.Windows.Forms.TextBox();
            this.defMinFilter = new System.Windows.Forms.Button();
            this.spaMinFilter = new System.Windows.Forms.Button();
            this.defMaxFilter = new System.Windows.Forms.Button();
            this.spaMax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.atkMin = new System.Windows.Forms.TextBox();
            this.spaMaxFilter = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.RetailAdvancesTrackerLabel = new System.Windows.Forms.Label();
            this.RetailAdvancesTrackerInitialInputLabel = new System.Windows.Forms.Label();
            this.RetailAdvancesTrackerMaxAdvInputLabel = new System.Windows.Forms.Label();
            this.RetailAdvancesTrackerInitialInput = new System.Windows.Forms.TextBox();
            this.RetailAdvancesTrackerMaxInput = new System.Windows.Forms.TextBox();
            this.RetailAdvancesTrackerGenerateButton = new System.Windows.Forms.Button();
            this.RetailAdvancesTrackerProgressBar = new System.Windows.Forms.ProgressBar();
            this.RetailAdvancesTrackerSequenceInput = new System.Windows.Forms.TextBox();
            this.RetailAdvancesTrackerSequenceLabel = new System.Windows.Forms.Label();
            this.RetailAdvancesTrackerResultState0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RetailAdvancesTrackerResultState1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RetailAdvancesTrackerNumResultsLabel = new System.Windows.Forms.Label();
            this.CheckIsAbilityLocked = new System.Windows.Forms.CheckBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.SeedFinderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonUpdateStates = new System.Windows.Forms.Button();
            this.CheckTIDSIDFinder = new System.Windows.Forms.CheckBox();
            this.LabelKOCount = new System.Windows.Forms.Label();
            this.InputKOCount = new System.Windows.Forms.TextBox();
            this.LabelEMs = new System.Windows.Forms.Label();
            this.InputEMs = new System.Windows.Forms.TextBox();
            this.LabelFlawlessIVs = new System.Windows.Forms.Label();
            this.InputFlawlessIVs = new System.Windows.Forms.TextBox();
            this.sensBox = new System.Windows.Forms.CheckBox();
            this.CheckCuteCharm = new System.Windows.Forms.CheckBox();
            this.hpJudgeFilter = new System.Windows.Forms.ComboBox();
            this.atkJudgeFilter = new System.Windows.Forms.ComboBox();
            this.defJudgeFilter = new System.Windows.Forms.ComboBox();
            this.spaJudgeFilter = new System.Windows.Forms.ComboBox();
            this.spdJudgeFilter = new System.Windows.Forms.ComboBox();
            this.speJudgeFilter = new System.Windows.Forms.ComboBox();
            this.DesiredNature = new System.Windows.Forms.Label();
            this.SelectedNature = new System.Windows.Forms.ComboBox();
            this.LabelInitialAdv = new System.Windows.Forms.Label();
            this.InputInitialAdv = new System.Windows.Forms.TextBox();
            this.CheckShinyLocked = new System.Windows.Forms.CheckBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.SwitchIPInput = new System.Windows.Forms.TextBox();
            this.SwitchIPLabel = new System.Windows.Forms.Label();
            this.CurrentAdvancesLabel = new System.Windows.Forms.Label();
            this.InputRAMOffset = new System.Windows.Forms.TextBox();
            this.InputRAMOffsetLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionStatusText = new System.Windows.Forms.Label();
            this.TrackAdv = new System.Windows.Forms.TextBox();
            this.TextBoxCheckEncounter = new System.Windows.Forms.TextBox();
            this.DaySkipAmountInput = new System.Windows.Forms.TextBox();
            this.DaySkipButton = new System.Windows.Forms.Button();
            this.ReadEncounterButton = new System.Windows.Forms.Button();
            this.SelectedAura = new System.Windows.Forms.ComboBox();
            this.LabelAura = new System.Windows.Forms.Label();
            this.CheckHidden = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRareMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatorBindingSource)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelState0
            // 
            this.LabelState0.AutoSize = true;
            this.LabelState0.Location = new System.Drawing.Point(9, 30);
            this.LabelState0.Name = "LabelState0";
            this.LabelState0.Size = new System.Drawing.Size(53, 15);
            this.LabelState0.TabIndex = 0;
            this.LabelState0.Text = "State[0]: ";
            // 
            // InputState0
            // 
            this.InputState0.Location = new System.Drawing.Point(68, 27);
            this.InputState0.MaxLength = 16;
            this.InputState0.Name = "InputState0";
            this.InputState0.Size = new System.Drawing.Size(189, 23);
            this.InputState0.TabIndex = 0;
            this.InputState0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputStatePaste_KeyDown);
            this.InputState0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // InputState1
            // 
            this.InputState1.Location = new System.Drawing.Point(68, 53);
            this.InputState1.MaxLength = 16;
            this.InputState1.Name = "InputState1";
            this.InputState1.Size = new System.Drawing.Size(189, 23);
            this.InputState1.TabIndex = 1;
            this.InputState1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputStatePaste_KeyDown);
            this.InputState1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // LabelState1
            // 
            this.LabelState1.AutoSize = true;
            this.LabelState1.Location = new System.Drawing.Point(12, 55);
            this.LabelState1.Name = "LabelState1";
            this.LabelState1.Size = new System.Drawing.Size(50, 15);
            this.LabelState1.TabIndex = 3;
            this.LabelState1.Text = "State[1]:";
            // 
            // hpMin
            // 
            this.hpMin.Location = new System.Drawing.Point(330, 27);
            this.hpMin.Name = "hpMin";
            this.hpMin.Size = new System.Drawing.Size(28, 23);
            this.hpMin.TabIndex = 5;
            this.hpMin.Text = "0";
            this.hpMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hpMin.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.hpMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.hpMin.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // hpMax
            // 
            this.hpMax.Location = new System.Drawing.Point(380, 27);
            this.hpMax.Name = "hpMax";
            this.hpMax.Size = new System.Drawing.Size(28, 23);
            this.hpMax.TabIndex = 6;
            this.hpMax.Text = "31";
            this.hpMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hpMax.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.hpMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.hpMax.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // hpFilter
            // 
            this.hpFilter.AutoSize = true;
            this.hpFilter.Location = new System.Drawing.Point(298, 30);
            this.hpFilter.Name = "hpFilter";
            this.hpFilter.Size = new System.Drawing.Size(26, 15);
            this.hpFilter.TabIndex = 16;
            this.hpFilter.Text = "HP:";
            this.hpFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // atkFilter
            // 
            this.atkFilter.AutoSize = true;
            this.atkFilter.Location = new System.Drawing.Point(296, 57);
            this.atkFilter.Name = "atkFilter";
            this.atkFilter.Size = new System.Drawing.Size(28, 15);
            this.atkFilter.TabIndex = 17;
            this.atkFilter.Text = "Atk:";
            this.atkFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // defFilter
            // 
            this.defFilter.AutoSize = true;
            this.defFilter.Location = new System.Drawing.Point(296, 82);
            this.defFilter.Name = "defFilter";
            this.defFilter.Size = new System.Drawing.Size(28, 15);
            this.defFilter.TabIndex = 18;
            this.defFilter.Text = "Def:";
            this.defFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // spaFilter
            // 
            this.spaFilter.AutoSize = true;
            this.spaFilter.Location = new System.Drawing.Point(293, 108);
            this.spaFilter.Name = "spaFilter";
            this.spaFilter.Size = new System.Drawing.Size(31, 15);
            this.spaFilter.TabIndex = 19;
            this.spaFilter.Text = "SpA:";
            this.spaFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // spdFilter
            // 
            this.spdFilter.AutoSize = true;
            this.spdFilter.Location = new System.Drawing.Point(293, 134);
            this.spdFilter.Name = "spdFilter";
            this.spdFilter.Size = new System.Drawing.Size(31, 15);
            this.spdFilter.TabIndex = 20;
            this.spdFilter.Text = "SpD:";
            this.spdFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // speFilter
            // 
            this.speFilter.AutoSize = true;
            this.speFilter.Location = new System.Drawing.Point(295, 160);
            this.speFilter.Name = "speFilter";
            this.speFilter.Size = new System.Drawing.Size(29, 15);
            this.speFilter.TabIndex = 21;
            this.speFilter.Text = "Spe:";
            this.speFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "-";
            // 
            // hpMinFilter
            // 
            this.hpMinFilter.Location = new System.Drawing.Point(427, 26);
            this.hpMinFilter.Name = "hpMinFilter";
            this.hpMinFilter.Size = new System.Drawing.Size(29, 20);
            this.hpMinFilter.TabIndex = 17;
            this.hpMinFilter.Text = "0";
            this.hpMinFilter.UseVisualStyleBackColor = true;
            this.hpMinFilter.Click += new System.EventHandler(this.HpMinFilter_Click);
            // 
            // hpMaxFilter
            // 
            this.hpMaxFilter.Location = new System.Drawing.Point(461, 26);
            this.hpMaxFilter.Name = "hpMaxFilter";
            this.hpMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.hpMaxFilter.TabIndex = 18;
            this.hpMaxFilter.Text = "31";
            this.hpMaxFilter.UseVisualStyleBackColor = true;
            this.hpMaxFilter.Click += new System.EventHandler(this.HpMaxFilter_Click);
            // 
            // InputTID
            // 
            this.InputTID.Location = new System.Drawing.Point(66, 82);
            this.InputTID.MaxLength = 5;
            this.InputTID.Name = "InputTID";
            this.InputTID.Size = new System.Drawing.Size(44, 23);
            this.InputTID.TabIndex = 2;
            this.InputTID.Text = "01390";
            this.InputTID.TextChanged += new System.EventHandler(this.TIDSID_TextChanged);
            this.InputTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputTID.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // InputSID
            // 
            this.InputSID.Location = new System.Drawing.Point(124, 82);
            this.InputSID.MaxLength = 5;
            this.InputSID.Name = "InputSID";
            this.InputSID.Size = new System.Drawing.Size(44, 23);
            this.InputSID.TabIndex = 3;
            this.InputSID.Text = "01337";
            this.InputSID.TextChanged += new System.EventHandler(this.TIDSID_TextChanged);
            this.InputSID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputSID.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // LabelTIDSID
            // 
            this.LabelTIDSID.AutoSize = true;
            this.LabelTIDSID.Location = new System.Drawing.Point(5, 84);
            this.LabelTIDSID.Name = "LabelTIDSID";
            this.LabelTIDSID.Size = new System.Drawing.Size(55, 15);
            this.LabelTIDSID.TabIndex = 47;
            this.LabelTIDSID.Text = "TID / SID:";
            // 
            // LabelIDsSlash
            // 
            this.LabelIDsSlash.AutoSize = true;
            this.LabelIDsSlash.Location = new System.Drawing.Point(111, 86);
            this.LabelIDsSlash.Name = "LabelIDsSlash";
            this.LabelIDsSlash.Size = new System.Drawing.Size(12, 15);
            this.LabelIDsSlash.TabIndex = 48;
            this.LabelIDsSlash.Text = "/";
            // 
            // InputMaxAdv
            // 
            this.InputMaxAdv.Location = new System.Drawing.Point(66, 134);
            this.InputMaxAdv.MaxLength = 13;
            this.InputMaxAdv.Name = "InputMaxAdv";
            this.InputMaxAdv.Size = new System.Drawing.Size(102, 23);
            this.InputMaxAdv.TabIndex = 4;
            this.InputMaxAdv.Text = "50000";
            // 
            // LabelMaxAdv
            // 
            this.LabelMaxAdv.AutoSize = true;
            this.LabelMaxAdv.Location = new System.Drawing.Point(45, 137);
            this.LabelMaxAdv.Name = "LabelMaxAdv";
            this.LabelMaxAdv.Size = new System.Drawing.Size(15, 15);
            this.LabelMaxAdv.TabIndex = 50;
            this.LabelMaxAdv.Text = "+";
            // 
            // LabelMark
            // 
            this.LabelMark.AutoSize = true;
            this.LabelMark.Location = new System.Drawing.Point(435, 268);
            this.LabelMark.Name = "LabelMark";
            this.LabelMark.Size = new System.Drawing.Size(37, 15);
            this.LabelMark.TabIndex = 52;
            this.LabelMark.Text = "Mark:";
            // 
            // ImageRareMark
            // 
            this.ImageRareMark.Image = global::SWSH_OWRNG_Generator.WinForms.Properties.Resources.raremark;
            this.ImageRareMark.Location = new System.Drawing.Point(642, 341);
            this.ImageRareMark.Name = "ImageRareMark";
            this.ImageRareMark.Size = new System.Drawing.Size(128, 128);
            this.ImageRareMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageRareMark.TabIndex = 53;
            this.ImageRareMark.TabStop = false;
            // 
            // SelectedMark
            // 
            this.SelectedMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedMark.FormattingEnabled = true;
            this.SelectedMark.Items.AddRange(new object[] {
            "Ignore",
            "None",
            "Any Mark",
            "Any Personality",
            "Uncommon",
            "Time",
            "Weather",
            "Fishing",
            "Rare",
            "Rowdy",
            "AbsentMinded",
            "Jittery",
            "Excited",
            "Charismatic",
            "Calmness",
            "Intense",
            "ZonedOut",
            "Joyful",
            "Angry",
            "Smiley",
            "Teary",
            "Upbeat",
            "Peeved",
            "Intellectual",
            "Ferocious",
            "Crafty",
            "Scowling",
            "Kindly",
            "Flustered",
            "PumpedUp",
            "ZeroEnergy",
            "Prideful",
            "Unsure",
            "Humble",
            "Thorny",
            "Vigor",
            "Slump"});
            this.SelectedMark.Location = new System.Drawing.Point(475, 265);
            this.SelectedMark.Name = "SelectedMark";
            this.SelectedMark.Size = new System.Drawing.Size(103, 23);
            this.SelectedMark.TabIndex = 29;
            // 
            // CheckShinyCharm
            // 
            this.CheckShinyCharm.AutoSize = true;
            this.CheckShinyCharm.Location = new System.Drawing.Point(174, 85);
            this.CheckShinyCharm.Name = "CheckShinyCharm";
            this.CheckShinyCharm.Size = new System.Drawing.Size(94, 19);
            this.CheckShinyCharm.TabIndex = 31;
            this.CheckShinyCharm.Text = "Shiny Charm";
            this.CheckShinyCharm.UseVisualStyleBackColor = true;
            this.CheckShinyCharm.CheckedChanged += new System.EventHandler(this.SaveCheckbox_CheckChanged);
            // 
            // CheckMarkCharm
            // 
            this.CheckMarkCharm.AutoSize = true;
            this.CheckMarkCharm.Location = new System.Drawing.Point(174, 110);
            this.CheckMarkCharm.Name = "CheckMarkCharm";
            this.CheckMarkCharm.Size = new System.Drawing.Size(92, 19);
            this.CheckMarkCharm.TabIndex = 33;
            this.CheckMarkCharm.Text = "Mark Charm";
            this.CheckMarkCharm.UseVisualStyleBackColor = true;
            this.CheckMarkCharm.CheckedChanged += new System.EventHandler(this.SaveCheckbox_CheckChanged);
            // 
            // CheckWeather
            // 
            this.CheckWeather.AutoSize = true;
            this.CheckWeather.Location = new System.Drawing.Point(12, 183);
            this.CheckWeather.Name = "CheckWeather";
            this.CheckWeather.Size = new System.Drawing.Size(70, 19);
            this.CheckWeather.TabIndex = 35;
            this.CheckWeather.Text = "Weather";
            this.CheckWeather.UseVisualStyleBackColor = true;
            // 
            // CheckStatic
            // 
            this.CheckStatic.AutoSize = true;
            this.CheckStatic.Location = new System.Drawing.Point(12, 160);
            this.CheckStatic.Name = "CheckStatic";
            this.CheckStatic.Size = new System.Drawing.Size(55, 19);
            this.CheckStatic.TabIndex = 32;
            this.CheckStatic.Text = "Static";
            this.CheckStatic.UseVisualStyleBackColor = true;
            this.CheckStatic.CheckedChanged += new System.EventHandler(this.CheckStatic_CheckedChanged);
            // 
            // CheckFishing
            // 
            this.CheckFishing.AutoSize = true;
            this.CheckFishing.Location = new System.Drawing.Point(12, 206);
            this.CheckFishing.Name = "CheckFishing";
            this.CheckFishing.Size = new System.Drawing.Size(64, 19);
            this.CheckFishing.TabIndex = 34;
            this.CheckFishing.Text = "Fishing";
            this.CheckFishing.UseVisualStyleBackColor = true;
            // 
            // CheckHeldItem
            // 
            this.CheckHeldItem.AutoSize = true;
            this.CheckHeldItem.Location = new System.Drawing.Point(12, 252);
            this.CheckHeldItem.Name = "CheckHeldItem";
            this.CheckHeldItem.Size = new System.Drawing.Size(124, 19);
            this.CheckHeldItem.TabIndex = 36;
            this.CheckHeldItem.Text = "Random held item";
            this.CheckHeldItem.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(216, 284);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 15);
            this.label20.TabIndex = 64;
            this.label20.Text = "-";
            // 
            // InputLevelMax
            // 
            this.InputLevelMax.Location = new System.Drawing.Point(232, 281);
            this.InputLevelMax.MaxLength = 2;
            this.InputLevelMax.Name = "InputLevelMax";
            this.InputLevelMax.Size = new System.Drawing.Size(28, 23);
            this.InputLevelMax.TabIndex = 39;
            this.InputLevelMax.Text = "0";
            this.InputLevelMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputLevelMax.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            this.InputLevelMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputLevelMax.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // InputLevelMin
            // 
            this.InputLevelMin.Location = new System.Drawing.Point(182, 281);
            this.InputLevelMin.MaxLength = 2;
            this.InputLevelMin.Name = "InputLevelMin";
            this.InputLevelMin.Size = new System.Drawing.Size(28, 23);
            this.InputLevelMin.TabIndex = 38;
            this.InputLevelMin.Text = "0";
            this.InputLevelMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputLevelMin.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            this.InputLevelMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputLevelMin.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(216, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 15);
            this.label21.TabIndex = 67;
            this.label21.Text = "-";
            // 
            // InputSlotMax
            // 
            this.InputSlotMax.Location = new System.Drawing.Point(232, 255);
            this.InputSlotMax.MaxLength = 2;
            this.InputSlotMax.Name = "InputSlotMax";
            this.InputSlotMax.Size = new System.Drawing.Size(28, 23);
            this.InputSlotMax.TabIndex = 41;
            this.InputSlotMax.Text = "99";
            this.InputSlotMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputSlotMax.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            this.InputSlotMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputSlotMax.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // InputSlotMin
            // 
            this.InputSlotMin.Location = new System.Drawing.Point(182, 255);
            this.InputSlotMin.MaxLength = 2;
            this.InputSlotMin.Name = "InputSlotMin";
            this.InputSlotMin.Size = new System.Drawing.Size(28, 23);
            this.InputSlotMin.TabIndex = 40;
            this.InputSlotMin.Text = "0";
            this.InputSlotMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputSlotMin.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            this.InputSlotMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputSlotMin.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Location = new System.Drawing.Point(139, 284);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(37, 15);
            this.LabelLevel.TabIndex = 68;
            this.LabelLevel.Text = "Level:";
            // 
            // LabelSlot
            // 
            this.LabelSlot.AutoSize = true;
            this.LabelSlot.Location = new System.Drawing.Point(146, 258);
            this.LabelSlot.Name = "LabelSlot";
            this.LabelSlot.Size = new System.Drawing.Size(30, 15);
            this.LabelSlot.TabIndex = 69;
            this.LabelSlot.Text = "Slot:";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(247, 377);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(341, 46);
            this.ButtonSearch.TabIndex = 42;
            this.ButtonSearch.Text = "Search!";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // SelectedShiny
            // 
            this.SelectedShiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedShiny.FormattingEnabled = true;
            this.SelectedShiny.Items.AddRange(new object[] {
            "Ignore",
            "No",
            "Square",
            "Star",
            "Star/Square"});
            this.SelectedShiny.Location = new System.Drawing.Point(475, 238);
            this.SelectedShiny.Name = "SelectedShiny";
            this.SelectedShiny.Size = new System.Drawing.Size(103, 23);
            this.SelectedShiny.TabIndex = 30;
            // 
            // LabelShiny
            // 
            this.LabelShiny.AutoSize = true;
            this.LabelShiny.Location = new System.Drawing.Point(433, 242);
            this.LabelShiny.Name = "LabelShiny";
            this.LabelShiny.Size = new System.Drawing.Size(39, 15);
            this.LabelShiny.TabIndex = 71;
            this.LabelShiny.Text = "Shiny:";
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.AutoGenerateColumns = false;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frame,
            this.TID,
            this.SID,
            this.Animation,
            this.Brilliant,
            this.Level,
            this.Slot,
            this.PID,
            this.EC,
            this.Shiny,
            this.Ability,
            this.Nature,
            this.Gender,
            this.HP,
            this.Atk,
            this.Def,
            this.SpA,
            this.SpD,
            this.Spe,
            this.Mark,
            this.State0,
            this.State1});
            this.Results.DataSource = this.generatorBindingSource;
            this.Results.Location = new System.Drawing.Point(12, 463);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowHeadersWidth = 62;
            this.Results.Size = new System.Drawing.Size(808, 224);
            this.Results.TabIndex = 73;
            // 
            // Frame
            // 
            this.Frame.DataPropertyName = "Advances";
            this.Frame.HeaderText = "Frame";
            this.Frame.MinimumWidth = 8;
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            this.Frame.Width = 150;
            // 
            // TID
            // 
            this.TID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TID.DataPropertyName = "TID";
            this.TID.HeaderText = "TID";
            this.TID.MinimumWidth = 8;
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Width = 49;
            // 
            // SID
            // 
            this.SID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SID.DataPropertyName = "SID";
            this.SID.HeaderText = "SID";
            this.SID.MinimumWidth = 8;
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Width = 49;
            // 
            // Animation
            // 
            this.Animation.DataPropertyName = "Animation";
            this.Animation.HeaderText = "Animation";
            this.Animation.MinimumWidth = 8;
            this.Animation.Name = "Animation";
            this.Animation.ReadOnly = true;
            this.Animation.Width = 60;
            // 
            // Brilliant
            // 
            this.Brilliant.DataPropertyName = "Brilliant";
            this.Brilliant.HeaderText = "Brilliant";
            this.Brilliant.MinimumWidth = 6;
            this.Brilliant.Name = "Brilliant";
            this.Brilliant.ReadOnly = true;
            this.Brilliant.Width = 125;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 8;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 59;
            // 
            // Slot
            // 
            this.Slot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Slot.DataPropertyName = "Slot";
            this.Slot.HeaderText = "Slot";
            this.Slot.MinimumWidth = 8;
            this.Slot.Name = "Slot";
            this.Slot.ReadOnly = true;
            this.Slot.Width = 52;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "PID";
            this.PID.MinimumWidth = 8;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 50;
            // 
            // EC
            // 
            this.EC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EC.DataPropertyName = "EC";
            this.EC.HeaderText = "EC";
            this.EC.MinimumWidth = 8;
            this.EC.Name = "EC";
            this.EC.ReadOnly = true;
            this.EC.Width = 46;
            // 
            // Shiny
            // 
            this.Shiny.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Shiny.DataPropertyName = "Shiny";
            this.Shiny.HeaderText = "Shiny";
            this.Shiny.MinimumWidth = 8;
            this.Shiny.Name = "Shiny";
            this.Shiny.ReadOnly = true;
            this.Shiny.Width = 61;
            // 
            // Ability
            // 
            this.Ability.DataPropertyName = "Ability";
            this.Ability.HeaderText = "Ability";
            this.Ability.MinimumWidth = 8;
            this.Ability.Name = "Ability";
            this.Ability.ReadOnly = true;
            this.Ability.Width = 50;
            // 
            // Nature
            // 
            this.Nature.DataPropertyName = "Nature";
            this.Nature.HeaderText = "Nature";
            this.Nature.MinimumWidth = 8;
            this.Nature.Name = "Nature";
            this.Nature.ReadOnly = true;
            this.Nature.Width = 75;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // HP
            // 
            this.HP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HP.DataPropertyName = "HP";
            this.HP.HeaderText = "HP";
            this.HP.MinimumWidth = 8;
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.Width = 34;
            // 
            // Atk
            // 
            this.Atk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Atk.DataPropertyName = "Atk";
            this.Atk.HeaderText = "Atk";
            this.Atk.MinimumWidth = 8;
            this.Atk.Name = "Atk";
            this.Atk.ReadOnly = true;
            this.Atk.Width = 34;
            // 
            // Def
            // 
            this.Def.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Def.DataPropertyName = "Def";
            this.Def.HeaderText = "Def";
            this.Def.MinimumWidth = 8;
            this.Def.Name = "Def";
            this.Def.ReadOnly = true;
            this.Def.Width = 34;
            // 
            // SpA
            // 
            this.SpA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SpA.DataPropertyName = "SpA";
            this.SpA.HeaderText = "SpA";
            this.SpA.MinimumWidth = 8;
            this.SpA.Name = "SpA";
            this.SpA.ReadOnly = true;
            this.SpA.Width = 34;
            // 
            // SpD
            // 
            this.SpD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SpD.DataPropertyName = "SpD";
            this.SpD.HeaderText = "SpD";
            this.SpD.MinimumWidth = 8;
            this.SpD.Name = "SpD";
            this.SpD.ReadOnly = true;
            this.SpD.Width = 34;
            // 
            // Spe
            // 
            this.Spe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Spe.DataPropertyName = "Spe";
            this.Spe.HeaderText = "Spe";
            this.Spe.MinimumWidth = 8;
            this.Spe.Name = "Spe";
            this.Spe.ReadOnly = true;
            this.Spe.Width = 34;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mark.DataPropertyName = "Mark";
            this.Mark.HeaderText = "Mark";
            this.Mark.MinimumWidth = 8;
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 59;
            // 
            // State0
            // 
            this.State0.DataPropertyName = "State0";
            this.State0.HeaderText = "State0";
            this.State0.MinimumWidth = 8;
            this.State0.Name = "State0";
            this.State0.ReadOnly = true;
            this.State0.Width = 150;
            // 
            // State1
            // 
            this.State1.DataPropertyName = "State1";
            this.State1.HeaderText = "State1";
            this.State1.MinimumWidth = 8;
            this.State1.Name = "State1";
            this.State1.ReadOnly = true;
            this.State1.Width = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "-";
            // 
            // speMinFilter
            // 
            this.speMinFilter.Location = new System.Drawing.Point(426, 157);
            this.speMinFilter.Name = "speMinFilter";
            this.speMinFilter.Size = new System.Drawing.Size(29, 20);
            this.speMinFilter.TabIndex = 27;
            this.speMinFilter.Text = "0";
            this.speMinFilter.UseVisualStyleBackColor = true;
            this.speMinFilter.Click += new System.EventHandler(this.SpeMinFilter_Click);
            // 
            // defMax
            // 
            this.defMax.Location = new System.Drawing.Point(380, 79);
            this.defMax.Name = "defMax";
            this.defMax.Size = new System.Drawing.Size(28, 23);
            this.defMax.TabIndex = 10;
            this.defMax.Text = "31";
            this.defMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.defMax.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.defMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.defMax.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(364, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "-";
            // 
            // spdMinFilter
            // 
            this.spdMinFilter.Location = new System.Drawing.Point(426, 131);
            this.spdMinFilter.Name = "spdMinFilter";
            this.spdMinFilter.Size = new System.Drawing.Size(29, 20);
            this.spdMinFilter.TabIndex = 25;
            this.spdMinFilter.Text = "0";
            this.spdMinFilter.UseVisualStyleBackColor = true;
            this.spdMinFilter.Click += new System.EventHandler(this.SpdMinFilter_Click);
            // 
            // spdMaxFilter
            // 
            this.spdMaxFilter.Location = new System.Drawing.Point(461, 131);
            this.spdMaxFilter.Name = "spdMaxFilter";
            this.spdMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.spdMaxFilter.TabIndex = 26;
            this.spdMaxFilter.Text = "31";
            this.spdMaxFilter.UseVisualStyleBackColor = true;
            this.spdMaxFilter.Click += new System.EventHandler(this.SpdMaxFilter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "-";
            // 
            // speMaxFilter
            // 
            this.speMaxFilter.Location = new System.Drawing.Point(461, 157);
            this.speMaxFilter.Name = "speMaxFilter";
            this.speMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.speMaxFilter.TabIndex = 28;
            this.speMaxFilter.Text = "31";
            this.speMaxFilter.UseVisualStyleBackColor = true;
            this.speMaxFilter.Click += new System.EventHandler(this.SpeMaxFilter_Click);
            // 
            // spaMin
            // 
            this.spaMin.Location = new System.Drawing.Point(330, 104);
            this.spaMin.Name = "spaMin";
            this.spaMin.Size = new System.Drawing.Size(28, 23);
            this.spaMin.TabIndex = 11;
            this.spaMin.Text = "0";
            this.spaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spaMin.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.spaMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.spaMin.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // atkMinFilter
            // 
            this.atkMinFilter.Location = new System.Drawing.Point(427, 53);
            this.atkMinFilter.Name = "atkMinFilter";
            this.atkMinFilter.Size = new System.Drawing.Size(29, 20);
            this.atkMinFilter.TabIndex = 19;
            this.atkMinFilter.Text = "0";
            this.atkMinFilter.UseVisualStyleBackColor = true;
            this.atkMinFilter.Click += new System.EventHandler(this.AtkMinFilter_Click);
            // 
            // spdMin
            // 
            this.spdMin.Location = new System.Drawing.Point(330, 130);
            this.spdMin.Name = "spdMin";
            this.spdMin.Size = new System.Drawing.Size(28, 23);
            this.spdMin.TabIndex = 13;
            this.spdMin.Text = "0";
            this.spdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spdMin.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.spdMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.spdMin.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // spdMax
            // 
            this.spdMax.Location = new System.Drawing.Point(380, 130);
            this.spdMax.Name = "spdMax";
            this.spdMax.Size = new System.Drawing.Size(28, 23);
            this.spdMax.TabIndex = 14;
            this.spdMax.Text = "31";
            this.spdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spdMax.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.spdMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.spdMax.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // speMin
            // 
            this.speMin.Location = new System.Drawing.Point(330, 157);
            this.speMin.Name = "speMin";
            this.speMin.Size = new System.Drawing.Size(28, 23);
            this.speMin.TabIndex = 15;
            this.speMin.Text = "0";
            this.speMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speMin.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.speMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.speMin.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // speMax
            // 
            this.speMax.Location = new System.Drawing.Point(380, 157);
            this.speMax.Name = "speMax";
            this.speMax.Size = new System.Drawing.Size(28, 23);
            this.speMax.TabIndex = 16;
            this.speMax.Text = "31";
            this.speMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speMax.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.speMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.speMax.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // atkMax
            // 
            this.atkMax.Location = new System.Drawing.Point(380, 54);
            this.atkMax.Name = "atkMax";
            this.atkMax.Size = new System.Drawing.Size(28, 23);
            this.atkMax.TabIndex = 8;
            this.atkMax.Text = "31";
            this.atkMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.atkMax.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.atkMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.atkMax.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // atkMaxFilter
            // 
            this.atkMaxFilter.Location = new System.Drawing.Point(461, 53);
            this.atkMaxFilter.Name = "atkMaxFilter";
            this.atkMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.atkMaxFilter.TabIndex = 20;
            this.atkMaxFilter.Text = "31";
            this.atkMaxFilter.UseVisualStyleBackColor = true;
            this.atkMaxFilter.Click += new System.EventHandler(this.AtkMaxFilter_Click);
            // 
            // defMin
            // 
            this.defMin.Location = new System.Drawing.Point(330, 79);
            this.defMin.Name = "defMin";
            this.defMin.Size = new System.Drawing.Size(28, 23);
            this.defMin.TabIndex = 9;
            this.defMin.Text = "0";
            this.defMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.defMin.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.defMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.defMin.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // defMinFilter
            // 
            this.defMinFilter.Location = new System.Drawing.Point(427, 79);
            this.defMinFilter.Name = "defMinFilter";
            this.defMinFilter.Size = new System.Drawing.Size(29, 20);
            this.defMinFilter.TabIndex = 21;
            this.defMinFilter.Text = "0";
            this.defMinFilter.UseVisualStyleBackColor = true;
            this.defMinFilter.Click += new System.EventHandler(this.DefMinFilter_Click);
            // 
            // spaMinFilter
            // 
            this.spaMinFilter.Location = new System.Drawing.Point(427, 105);
            this.spaMinFilter.Name = "spaMinFilter";
            this.spaMinFilter.Size = new System.Drawing.Size(29, 20);
            this.spaMinFilter.TabIndex = 23;
            this.spaMinFilter.Text = "0";
            this.spaMinFilter.UseVisualStyleBackColor = true;
            this.spaMinFilter.Click += new System.EventHandler(this.SpaMinFilter_Click);
            // 
            // defMaxFilter
            // 
            this.defMaxFilter.Location = new System.Drawing.Point(461, 79);
            this.defMaxFilter.Name = "defMaxFilter";
            this.defMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.defMaxFilter.TabIndex = 22;
            this.defMaxFilter.Text = "31";
            this.defMaxFilter.UseVisualStyleBackColor = true;
            this.defMaxFilter.Click += new System.EventHandler(this.DefMaxFilter_Click);
            // 
            // spaMax
            // 
            this.spaMax.Location = new System.Drawing.Point(380, 105);
            this.spaMax.Name = "spaMax";
            this.spaMax.Size = new System.Drawing.Size(28, 23);
            this.spaMax.TabIndex = 12;
            this.spaMax.Text = "31";
            this.spaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spaMax.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.spaMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.spaMax.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(364, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "-";
            // 
            // atkMin
            // 
            this.atkMin.Location = new System.Drawing.Point(330, 53);
            this.atkMin.Name = "atkMin";
            this.atkMin.Size = new System.Drawing.Size(28, 23);
            this.atkMin.TabIndex = 7;
            this.atkMin.Text = "0";
            this.atkMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.atkMin.TextChanged += new System.EventHandler(this.IVs_TextChanged);
            this.atkMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.atkMin.Leave += new System.EventHandler(this.Filter_LostFocus);
            // 
            // spaMaxFilter
            // 
            this.spaMaxFilter.Location = new System.Drawing.Point(461, 105);
            this.spaMaxFilter.Name = "spaMaxFilter";
            this.spaMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.spaMaxFilter.TabIndex = 24;
            this.spaMaxFilter.Text = "31";
            this.spaMaxFilter.UseVisualStyleBackColor = true;
            this.spaMaxFilter.Click += new System.EventHandler(this.SpaMaxFilter_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(247, 429);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(341, 21);
            this.progressBar1.TabIndex = 74;
            // 
            // RetailAdvancesTrackerLabel
            // 
            this.RetailAdvancesTrackerLabel.AutoSize = true;
            this.RetailAdvancesTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RetailAdvancesTrackerLabel.Location = new System.Drawing.Point(602, 29);
            this.RetailAdvancesTrackerLabel.Name = "RetailAdvancesTrackerLabel";
            this.RetailAdvancesTrackerLabel.Size = new System.Drawing.Size(148, 13);
            this.RetailAdvancesTrackerLabel.TabIndex = 75;
            this.RetailAdvancesTrackerLabel.Text = "Retail Advances Tracker";
            // 
            // RetailAdvancesTrackerInitialInputLabel
            // 
            this.RetailAdvancesTrackerInitialInputLabel.AutoSize = true;
            this.RetailAdvancesTrackerInitialInputLabel.Location = new System.Drawing.Point(602, 55);
            this.RetailAdvancesTrackerInitialInputLabel.Name = "RetailAdvancesTrackerInitialInputLabel";
            this.RetailAdvancesTrackerInitialInputLabel.Size = new System.Drawing.Size(66, 15);
            this.RetailAdvancesTrackerInitialInputLabel.TabIndex = 76;
            this.RetailAdvancesTrackerInitialInputLabel.Text = "Initial Adv.:";
            // 
            // RetailAdvancesTrackerMaxAdvInputLabel
            // 
            this.RetailAdvancesTrackerMaxAdvInputLabel.AutoSize = true;
            this.RetailAdvancesTrackerMaxAdvInputLabel.Location = new System.Drawing.Point(648, 81);
            this.RetailAdvancesTrackerMaxAdvInputLabel.Name = "RetailAdvancesTrackerMaxAdvInputLabel";
            this.RetailAdvancesTrackerMaxAdvInputLabel.Size = new System.Drawing.Size(15, 15);
            this.RetailAdvancesTrackerMaxAdvInputLabel.TabIndex = 77;
            this.RetailAdvancesTrackerMaxAdvInputLabel.Text = "+";
            // 
            // RetailAdvancesTrackerInitialInput
            // 
            this.RetailAdvancesTrackerInitialInput.Location = new System.Drawing.Point(667, 52);
            this.RetailAdvancesTrackerInitialInput.MaxLength = 16;
            this.RetailAdvancesTrackerInitialInput.Name = "RetailAdvancesTrackerInitialInput";
            this.RetailAdvancesTrackerInitialInput.Size = new System.Drawing.Size(145, 23);
            this.RetailAdvancesTrackerInitialInput.TabIndex = 78;
            this.RetailAdvancesTrackerInitialInput.Text = "0";
            this.RetailAdvancesTrackerInitialInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.RetailAdvancesTrackerInitialInput.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // RetailAdvancesTrackerMaxInput
            // 
            this.RetailAdvancesTrackerMaxInput.Location = new System.Drawing.Point(667, 78);
            this.RetailAdvancesTrackerMaxInput.MaxLength = 16;
            this.RetailAdvancesTrackerMaxInput.Name = "RetailAdvancesTrackerMaxInput";
            this.RetailAdvancesTrackerMaxInput.Size = new System.Drawing.Size(145, 23);
            this.RetailAdvancesTrackerMaxInput.TabIndex = 79;
            this.RetailAdvancesTrackerMaxInput.Text = "10000";
            this.RetailAdvancesTrackerMaxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.RetailAdvancesTrackerMaxInput.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // RetailAdvancesTrackerGenerateButton
            // 
            this.RetailAdvancesTrackerGenerateButton.Location = new System.Drawing.Point(605, 111);
            this.RetailAdvancesTrackerGenerateButton.Name = "RetailAdvancesTrackerGenerateButton";
            this.RetailAdvancesTrackerGenerateButton.Size = new System.Drawing.Size(207, 20);
            this.RetailAdvancesTrackerGenerateButton.TabIndex = 80;
            this.RetailAdvancesTrackerGenerateButton.Text = "Generate Pattern";
            this.RetailAdvancesTrackerGenerateButton.UseVisualStyleBackColor = true;
            this.RetailAdvancesTrackerGenerateButton.Click += new System.EventHandler(this.RetailAdvancesTrackerGenerateButton_Click);
            // 
            // RetailAdvancesTrackerProgressBar
            // 
            this.RetailAdvancesTrackerProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RetailAdvancesTrackerProgressBar.Location = new System.Drawing.Point(606, 135);
            this.RetailAdvancesTrackerProgressBar.Name = "RetailAdvancesTrackerProgressBar";
            this.RetailAdvancesTrackerProgressBar.Size = new System.Drawing.Size(205, 10);
            this.RetailAdvancesTrackerProgressBar.TabIndex = 81;
            // 
            // RetailAdvancesTrackerSequenceInput
            // 
            this.RetailAdvancesTrackerSequenceInput.Location = new System.Drawing.Point(605, 172);
            this.RetailAdvancesTrackerSequenceInput.MaxLength = 30;
            this.RetailAdvancesTrackerSequenceInput.Name = "RetailAdvancesTrackerSequenceInput";
            this.RetailAdvancesTrackerSequenceInput.ReadOnly = true;
            this.RetailAdvancesTrackerSequenceInput.Size = new System.Drawing.Size(207, 23);
            this.RetailAdvancesTrackerSequenceInput.TabIndex = 82;
            this.RetailAdvancesTrackerSequenceInput.TextChanged += new System.EventHandler(this.RetailAdvancesTrackerSequenceInput_TextChanged);
            this.RetailAdvancesTrackerSequenceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BinInput_KeyPress);
            // 
            // RetailAdvancesTrackerSequenceLabel
            // 
            this.RetailAdvancesTrackerSequenceLabel.AutoSize = true;
            this.RetailAdvancesTrackerSequenceLabel.Location = new System.Drawing.Point(602, 156);
            this.RetailAdvancesTrackerSequenceLabel.Name = "RetailAdvancesTrackerSequenceLabel";
            this.RetailAdvancesTrackerSequenceLabel.Size = new System.Drawing.Size(213, 15);
            this.RetailAdvancesTrackerSequenceLabel.TabIndex = 83;
            this.RetailAdvancesTrackerSequenceLabel.Text = "Input Sequence (0: Physical, 1: Special):";
            // 
            // RetailAdvancesTrackerResultState0
            // 
            this.RetailAdvancesTrackerResultState0.Location = new System.Drawing.Point(605, 257);
            this.RetailAdvancesTrackerResultState0.MaxLength = 16;
            this.RetailAdvancesTrackerResultState0.Name = "RetailAdvancesTrackerResultState0";
            this.RetailAdvancesTrackerResultState0.ReadOnly = true;
            this.RetailAdvancesTrackerResultState0.Size = new System.Drawing.Size(207, 23);
            this.RetailAdvancesTrackerResultState0.TabIndex = 84;
            this.RetailAdvancesTrackerResultState0.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 87;
            this.label3.Text = "Current State[1]:";
            // 
            // RetailAdvancesTrackerResultState1
            // 
            this.RetailAdvancesTrackerResultState1.Location = new System.Drawing.Point(605, 300);
            this.RetailAdvancesTrackerResultState1.MaxLength = 16;
            this.RetailAdvancesTrackerResultState1.Name = "RetailAdvancesTrackerResultState1";
            this.RetailAdvancesTrackerResultState1.ReadOnly = true;
            this.RetailAdvancesTrackerResultState1.Size = new System.Drawing.Size(207, 23);
            this.RetailAdvancesTrackerResultState1.TabIndex = 86;
            this.RetailAdvancesTrackerResultState1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Current State[0]:";
            // 
            // RetailAdvancesTrackerNumResultsLabel
            // 
            this.RetailAdvancesTrackerNumResultsLabel.AutoSize = true;
            this.RetailAdvancesTrackerNumResultsLabel.Location = new System.Drawing.Point(602, 209);
            this.RetailAdvancesTrackerNumResultsLabel.Name = "RetailAdvancesTrackerNumResultsLabel";
            this.RetailAdvancesTrackerNumResultsLabel.Size = new System.Drawing.Size(118, 15);
            this.RetailAdvancesTrackerNumResultsLabel.TabIndex = 88;
            this.RetailAdvancesTrackerNumResultsLabel.Text = "Possible Results: N/A";
            // 
            // CheckIsAbilityLocked
            // 
            this.CheckIsAbilityLocked.AutoSize = true;
            this.CheckIsAbilityLocked.Location = new System.Drawing.Point(12, 275);
            this.CheckIsAbilityLocked.Name = "CheckIsAbilityLocked";
            this.CheckIsAbilityLocked.Size = new System.Drawing.Size(101, 19);
            this.CheckIsAbilityLocked.TabIndex = 37;
            this.CheckIsAbilityLocked.Text = "Locked Ability";
            this.CheckIsAbilityLocked.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeedFinderMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(831, 24);
            this.MainMenu.TabIndex = 137;
            // 
            // SeedFinderMenu
            // 
            this.SeedFinderMenu.Name = "SeedFinderMenu";
            this.SeedFinderMenu.Size = new System.Drawing.Size(80, 20);
            this.SeedFinderMenu.Text = "Seed Finder";
            this.SeedFinderMenu.Click += new System.EventHandler(this.SeedFinderMenu_Click);
            // 
            // ButtonUpdateStates
            // 
            this.ButtonUpdateStates.Location = new System.Drawing.Point(604, 326);
            this.ButtonUpdateStates.Name = "ButtonUpdateStates";
            this.ButtonUpdateStates.Size = new System.Drawing.Size(209, 29);
            this.ButtonUpdateStates.TabIndex = 89;
            this.ButtonUpdateStates.Text = "Update States";
            this.ButtonUpdateStates.UseVisualStyleBackColor = true;
            this.ButtonUpdateStates.Click += new System.EventHandler(this.ButtonUpdateStates_Click);
            // 
            // CheckTIDSIDFinder
            // 
            this.CheckTIDSIDFinder.AutoSize = true;
            this.CheckTIDSIDFinder.Location = new System.Drawing.Point(174, 136);
            this.CheckTIDSIDFinder.Name = "CheckTIDSIDFinder";
            this.CheckTIDSIDFinder.Size = new System.Drawing.Size(123, 19);
            this.CheckTIDSIDFinder.TabIndex = 90;
            this.CheckTIDSIDFinder.Text = "Search For TID/SID";
            this.CheckTIDSIDFinder.UseVisualStyleBackColor = true;
            this.CheckTIDSIDFinder.CheckedChanged += new System.EventHandler(this.CheckTIDSIDFinder_CheckedChanged);
            // 
            // LabelKOCount
            // 
            this.LabelKOCount.AutoSize = true;
            this.LabelKOCount.Location = new System.Drawing.Point(165, 180);
            this.LabelKOCount.Name = "LabelKOCount";
            this.LabelKOCount.Size = new System.Drawing.Size(61, 15);
            this.LabelKOCount.TabIndex = 91;
            this.LabelKOCount.Text = "KO Count:";
            // 
            // InputKOCount
            // 
            this.InputKOCount.Location = new System.Drawing.Point(232, 177);
            this.InputKOCount.MaxLength = 3;
            this.InputKOCount.Name = "InputKOCount";
            this.InputKOCount.Size = new System.Drawing.Size(28, 23);
            this.InputKOCount.TabIndex = 90;
            this.InputKOCount.Text = "500";
            this.InputKOCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputKOCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputKOCount.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // LabelEMs
            // 
            this.LabelEMs.AutoSize = true;
            this.LabelEMs.Location = new System.Drawing.Point(148, 232);
            this.LabelEMs.Name = "LabelEMs";
            this.LabelEMs.Size = new System.Drawing.Size(78, 15);
            this.LabelEMs.TabIndex = 93;
            this.LabelEMs.Text = "Possible EMs:";
            // 
            // InputEMs
            // 
            this.InputEMs.Location = new System.Drawing.Point(232, 229);
            this.InputEMs.MaxLength = 2;
            this.InputEMs.Name = "InputEMs";
            this.InputEMs.Size = new System.Drawing.Size(28, 23);
            this.InputEMs.TabIndex = 92;
            this.InputEMs.Text = "4";
            this.InputEMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputEMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputEMs.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // LabelFlawlessIVs
            // 
            this.LabelFlawlessIVs.AutoSize = true;
            this.LabelFlawlessIVs.Location = new System.Drawing.Point(155, 206);
            this.LabelFlawlessIVs.Name = "LabelFlawlessIVs";
            this.LabelFlawlessIVs.Size = new System.Drawing.Size(71, 15);
            this.LabelFlawlessIVs.TabIndex = 95;
            this.LabelFlawlessIVs.Text = "Flawless IVs:";
            // 
            // InputFlawlessIVs
            // 
            this.InputFlawlessIVs.Location = new System.Drawing.Point(232, 203);
            this.InputFlawlessIVs.MaxLength = 1;
            this.InputFlawlessIVs.Name = "InputFlawlessIVs";
            this.InputFlawlessIVs.Size = new System.Drawing.Size(28, 23);
            this.InputFlawlessIVs.TabIndex = 94;
            this.InputFlawlessIVs.Text = "0";
            this.InputFlawlessIVs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputFlawlessIVs.TextChanged += new System.EventHandler(this.FlawlessIVs_TextChanged);
            this.InputFlawlessIVs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputFlawlessIVs.Leave += new System.EventHandler(this.SetToZero_LostFocus);
            // 
            // sensBox
            // 
            this.sensBox.AutoSize = true;
            this.sensBox.Location = new System.Drawing.Point(447, 188);
            this.sensBox.Name = "sensBox";
            this.sensBox.Size = new System.Drawing.Size(133, 19);
            this.sensBox.TabIndex = 96;
            this.sensBox.Text = "Hide Sensitive Fields";
            this.sensBox.UseVisualStyleBackColor = true;
            this.sensBox.CheckedChanged += new System.EventHandler(this.SensBox_CheckedChanged);
            // 
            // CheckCuteCharm
            // 
            this.CheckCuteCharm.AutoSize = true;
            this.CheckCuteCharm.Location = new System.Drawing.Point(12, 321);
            this.CheckCuteCharm.Name = "CheckCuteCharm";
            this.CheckCuteCharm.Size = new System.Drawing.Size(118, 19);
            this.CheckCuteCharm.TabIndex = 97;
            this.CheckCuteCharm.Text = "Cute Charm Lead";
            this.CheckCuteCharm.UseVisualStyleBackColor = true;
            // 
            // hpJudgeFilter
            // 
            this.hpJudgeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hpJudgeFilter.FormattingEnabled = true;
            this.hpJudgeFilter.Items.AddRange(new object[] {
            "No Good",
            "Decent",
            "Pretty Good",
            "Very Good",
            "Fantastic",
            "Best"});
            this.hpJudgeFilter.Location = new System.Drawing.Point(496, 25);
            this.hpJudgeFilter.Name = "hpJudgeFilter";
            this.hpJudgeFilter.Size = new System.Drawing.Size(82, 23);
            this.hpJudgeFilter.TabIndex = 104;
            this.hpJudgeFilter.SelectedIndexChanged += new System.EventHandler(this.JudgeFilter_SelectedIndexChanged);
            // 
            // atkJudgeFilter
            // 
            this.atkJudgeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atkJudgeFilter.FormattingEnabled = true;
            this.atkJudgeFilter.Items.AddRange(new object[] {
            "No Good",
            "Decent",
            "Pretty Good",
            "Very Good",
            "Fantastic",
            "Best"});
            this.atkJudgeFilter.Location = new System.Drawing.Point(496, 52);
            this.atkJudgeFilter.Name = "atkJudgeFilter";
            this.atkJudgeFilter.Size = new System.Drawing.Size(82, 23);
            this.atkJudgeFilter.TabIndex = 105;
            this.atkJudgeFilter.SelectedIndexChanged += new System.EventHandler(this.JudgeFilter_SelectedIndexChanged);
            // 
            // defJudgeFilter
            // 
            this.defJudgeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defJudgeFilter.FormattingEnabled = true;
            this.defJudgeFilter.Items.AddRange(new object[] {
            "No Good",
            "Decent",
            "Pretty Good",
            "Very Good",
            "Fantastic",
            "Best"});
            this.defJudgeFilter.Location = new System.Drawing.Point(496, 78);
            this.defJudgeFilter.Name = "defJudgeFilter";
            this.defJudgeFilter.Size = new System.Drawing.Size(82, 23);
            this.defJudgeFilter.TabIndex = 106;
            this.defJudgeFilter.SelectedIndexChanged += new System.EventHandler(this.JudgeFilter_SelectedIndexChanged);
            // 
            // spaJudgeFilter
            // 
            this.spaJudgeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spaJudgeFilter.FormattingEnabled = true;
            this.spaJudgeFilter.Items.AddRange(new object[] {
            "No Good",
            "Decent",
            "Pretty Good",
            "Very Good",
            "Fantastic",
            "Best"});
            this.spaJudgeFilter.Location = new System.Drawing.Point(496, 103);
            this.spaJudgeFilter.Name = "spaJudgeFilter";
            this.spaJudgeFilter.Size = new System.Drawing.Size(82, 23);
            this.spaJudgeFilter.TabIndex = 107;
            this.spaJudgeFilter.SelectedIndexChanged += new System.EventHandler(this.JudgeFilter_SelectedIndexChanged);
            // 
            // spdJudgeFilter
            // 
            this.spdJudgeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spdJudgeFilter.FormattingEnabled = true;
            this.spdJudgeFilter.Items.AddRange(new object[] {
            "No Good",
            "Decent",
            "Pretty Good",
            "Very Good",
            "Fantastic",
            "Best"});
            this.spdJudgeFilter.Location = new System.Drawing.Point(496, 130);
            this.spdJudgeFilter.Name = "spdJudgeFilter";
            this.spdJudgeFilter.Size = new System.Drawing.Size(82, 23);
            this.spdJudgeFilter.TabIndex = 108;
            this.spdJudgeFilter.SelectedIndexChanged += new System.EventHandler(this.JudgeFilter_SelectedIndexChanged);
            // 
            // speJudgeFilter
            // 
            this.speJudgeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speJudgeFilter.FormattingEnabled = true;
            this.speJudgeFilter.Items.AddRange(new object[] {
            "No Good",
            "Decent",
            "Pretty Good",
            "Very Good",
            "Fantastic",
            "Best"});
            this.speJudgeFilter.Location = new System.Drawing.Point(496, 156);
            this.speJudgeFilter.Name = "speJudgeFilter";
            this.speJudgeFilter.Size = new System.Drawing.Size(82, 23);
            this.speJudgeFilter.TabIndex = 109;
            this.speJudgeFilter.SelectedIndexChanged += new System.EventHandler(this.JudgeFilter_SelectedIndexChanged);
            // 
            // DesiredNature
            // 
            this.DesiredNature.AutoSize = true;
            this.DesiredNature.Location = new System.Drawing.Point(427, 214);
            this.DesiredNature.Name = "DesiredNature";
            this.DesiredNature.Size = new System.Drawing.Size(46, 15);
            this.DesiredNature.TabIndex = 110;
            this.DesiredNature.Text = "Nature:";
            // 
            // SelectedNature
            // 
            this.SelectedNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedNature.FormattingEnabled = true;
            this.SelectedNature.Items.AddRange(new object[] {
            "Ignore",
            "Hardy",
            "Lonely",
            "Brave",
            "Adamant",
            "Naughty",
            "Bold",
            "Docile",
            "Relaxed",
            "Impish",
            "Lax",
            "Timid",
            "Hasty",
            "Serious",
            "Jolly",
            "Naive",
            "Modest",
            "Mild",
            "Quiet",
            "Bashful",
            "Rash",
            "Calm",
            "Gentle",
            "Sassy",
            "Careful",
            "Quirky"});
            this.SelectedNature.Location = new System.Drawing.Point(475, 211);
            this.SelectedNature.Name = "SelectedNature";
            this.SelectedNature.Size = new System.Drawing.Size(103, 23);
            this.SelectedNature.TabIndex = 111;
            // 
            // LabelInitialAdv
            // 
            this.LabelInitialAdv.AutoSize = true;
            this.LabelInitialAdv.Location = new System.Drawing.Point(3, 111);
            this.LabelInitialAdv.Name = "LabelInitialAdv";
            this.LabelInitialAdv.Size = new System.Drawing.Size(57, 15);
            this.LabelInitialAdv.TabIndex = 113;
            this.LabelInitialAdv.Text = "Init. Adv.:";
            // 
            // InputInitialAdv
            // 
            this.InputInitialAdv.Location = new System.Drawing.Point(66, 108);
            this.InputInitialAdv.MaxLength = 13;
            this.InputInitialAdv.Name = "InputInitialAdv";
            this.InputInitialAdv.Size = new System.Drawing.Size(102, 23);
            this.InputInitialAdv.TabIndex = 112;
            this.InputInitialAdv.Text = "0";
            // 
            // CheckShinyLocked
            // 
            this.CheckShinyLocked.AutoSize = true;
            this.CheckShinyLocked.Location = new System.Drawing.Point(12, 298);
            this.CheckShinyLocked.Name = "CheckShinyLocked";
            this.CheckShinyLocked.Size = new System.Drawing.Size(96, 19);
            this.CheckShinyLocked.TabIndex = 114;
            this.CheckShinyLocked.Text = "Shiny Locked";
            this.CheckShinyLocked.UseVisualStyleBackColor = true;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(51, 429);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 115;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.Connect_ClickAsync);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(136, 429);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 116;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // SwitchIPInput
            // 
            this.SwitchIPInput.Location = new System.Drawing.Point(108, 364);
            this.SwitchIPInput.Name = "SwitchIPInput";
            this.SwitchIPInput.Size = new System.Drawing.Size(103, 23);
            this.SwitchIPInput.TabIndex = 117;
            this.SwitchIPInput.Text = "192.168.0.0";
            this.SwitchIPInput.TextChanged += new System.EventHandler(this.CheckForIP);
            // 
            // SwitchIPLabel
            // 
            this.SwitchIPLabel.AutoSize = true;
            this.SwitchIPLabel.Location = new System.Drawing.Point(44, 367);
            this.SwitchIPLabel.Name = "SwitchIPLabel";
            this.SwitchIPLabel.Size = new System.Drawing.Size(58, 15);
            this.SwitchIPLabel.TabIndex = 118;
            this.SwitchIPLabel.Text = "Switch IP:";
            // 
            // CurrentAdvancesLabel
            // 
            this.CurrentAdvancesLabel.AutoSize = true;
            this.CurrentAdvancesLabel.Location = new System.Drawing.Point(39, 406);
            this.CurrentAdvancesLabel.Name = "CurrentAdvancesLabel";
            this.CurrentAdvancesLabel.Size = new System.Drawing.Size(63, 15);
            this.CurrentAdvancesLabel.TabIndex = 120;
            this.CurrentAdvancesLabel.Text = "Curr. Adv.:";
            this.CurrentAdvancesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InputRAMOffset
            // 
            this.InputRAMOffset.Location = new System.Drawing.Point(108, 338);
            this.InputRAMOffset.Name = "InputRAMOffset";
            this.InputRAMOffset.Size = new System.Drawing.Size(103, 23);
            this.InputRAMOffset.TabIndex = 123;
            this.InputRAMOffset.Text = "4C2AAC18";
            this.InputRAMOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // InputRAMOffsetLabel
            // 
            this.InputRAMOffsetLabel.AutoSize = true;
            this.InputRAMOffsetLabel.Location = new System.Drawing.Point(60, 341);
            this.InputRAMOffsetLabel.Name = "InputRAMOffsetLabel";
            this.InputRAMOffsetLabel.Size = new System.Drawing.Size(42, 15);
            this.InputRAMOffsetLabel.TabIndex = 124;
            this.InputRAMOffsetLabel.Text = "Offset:";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(61, 387);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(42, 15);
            this.ConnectionStatusLabel.TabIndex = 125;
            this.ConnectionStatusLabel.Text = "Status:";
            // 
            // ConnectionStatusText
            // 
            this.ConnectionStatusText.AutoSize = true;
            this.ConnectionStatusText.Location = new System.Drawing.Point(108, 387);
            this.ConnectionStatusText.Name = "ConnectionStatusText";
            this.ConnectionStatusText.Size = new System.Drawing.Size(91, 15);
            this.ConnectionStatusText.TabIndex = 126;
            this.ConnectionStatusText.Text = "Not Connected.";
            // 
            // TrackAdv
            // 
            this.TrackAdv.Location = new System.Drawing.Point(108, 403);
            this.TrackAdv.Name = "TrackAdv";
            this.TrackAdv.ReadOnly = true;
            this.TrackAdv.Size = new System.Drawing.Size(103, 23);
            this.TrackAdv.TabIndex = 128;
            this.TrackAdv.Text = "Connect Switch!";
            // 
            // TextBoxCheckEncounter
            // 
            this.TextBoxCheckEncounter.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBoxCheckEncounter.Location = new System.Drawing.Point(277, 188);
            this.TextBoxCheckEncounter.Multiline = true;
            this.TextBoxCheckEncounter.Name = "TextBoxCheckEncounter";
            this.TextBoxCheckEncounter.ReadOnly = true;
            this.TextBoxCheckEncounter.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBoxCheckEncounter.Size = new System.Drawing.Size(144, 116);
            this.TextBoxCheckEncounter.TabIndex = 130;
            // 
            // DaySkipAmountInput
            // 
            this.DaySkipAmountInput.Enabled = false;
            this.DaySkipAmountInput.Location = new System.Drawing.Point(277, 351);
            this.DaySkipAmountInput.Name = "DaySkipAmountInput";
            this.DaySkipAmountInput.Size = new System.Drawing.Size(47, 23);
            this.DaySkipAmountInput.TabIndex = 131;
            this.DaySkipAmountInput.Text = "1";
            this.DaySkipAmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DaySkipAmountInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            // 
            // DaySkipButton
            // 
            this.DaySkipButton.Enabled = false;
            this.DaySkipButton.Location = new System.Drawing.Point(330, 350);
            this.DaySkipButton.Name = "DaySkipButton";
            this.DaySkipButton.Size = new System.Drawing.Size(91, 25);
            this.DaySkipButton.TabIndex = 132;
            this.DaySkipButton.Text = "DaySkip";
            this.DaySkipButton.UseVisualStyleBackColor = true;
            this.DaySkipButton.Click += new System.EventHandler(this.DaySkip_Click);
            // 
            // ReadEncounterButton
            // 
            this.ReadEncounterButton.Enabled = false;
            this.ReadEncounterButton.Location = new System.Drawing.Point(330, 305);
            this.ReadEncounterButton.Name = "ReadEncounterButton";
            this.ReadEncounterButton.Size = new System.Drawing.Size(91, 42);
            this.ReadEncounterButton.TabIndex = 133;
            this.ReadEncounterButton.Text = "Read Encounter";
            this.ReadEncounterButton.UseVisualStyleBackColor = true;
            this.ReadEncounterButton.Click += new System.EventHandler(this.ReadEncounter_ClickAsync);
            // 
            // SelectedAura
            // 
            this.SelectedAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedAura.FormattingEnabled = true;
            this.SelectedAura.Items.AddRange(new object[] {
            "Ignore",
            "None",
            "Brilliant"});
            this.SelectedAura.Location = new System.Drawing.Point(475, 292);
            this.SelectedAura.Name = "SelectedAura";
            this.SelectedAura.Size = new System.Drawing.Size(103, 23);
            this.SelectedAura.TabIndex = 134;
            // 
            // LabelAura
            // 
            this.LabelAura.AutoSize = true;
            this.LabelAura.Location = new System.Drawing.Point(437, 295);
            this.LabelAura.Name = "LabelAura";
            this.LabelAura.Size = new System.Drawing.Size(35, 15);
            this.LabelAura.TabIndex = 135;
            this.LabelAura.Text = "Aura:";
            // 
            // CheckHidden
            // 
            this.CheckHidden.AutoSize = true;
            this.CheckHidden.Location = new System.Drawing.Point(12, 229);
            this.CheckHidden.Name = "CheckHidden";
            this.CheckHidden.Size = new System.Drawing.Size(65, 19);
            this.CheckHidden.TabIndex = 136;
            this.CheckHidden.Text = "Hidden";
            this.CheckHidden.UseVisualStyleBackColor = true;
            this.CheckHidden.CheckedChanged += new System.EventHandler(this.CheckHidden_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(275, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(831, 699);
            this.Controls.Add(this.CheckHidden);
            this.Controls.Add(this.SelectedAura);
            this.Controls.Add(this.LabelAura);
            this.Controls.Add(this.ReadEncounterButton);
            this.Controls.Add(this.DaySkipButton);
            this.Controls.Add(this.DaySkipAmountInput);
            this.Controls.Add(this.TrackAdv);
            this.Controls.Add(this.ConnectionStatusText);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.InputRAMOffsetLabel);
            this.Controls.Add(this.InputRAMOffset);
            this.Controls.Add(this.CurrentAdvancesLabel);
            this.Controls.Add(this.SwitchIPLabel);
            this.Controls.Add(this.SwitchIPInput);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.CheckShinyLocked);
            this.Controls.Add(this.LabelInitialAdv);
            this.Controls.Add(this.InputInitialAdv);
            this.Controls.Add(this.SelectedNature);
            this.Controls.Add(this.DesiredNature);
            this.Controls.Add(this.speJudgeFilter);
            this.Controls.Add(this.spdJudgeFilter);
            this.Controls.Add(this.spaJudgeFilter);
            this.Controls.Add(this.defJudgeFilter);
            this.Controls.Add(this.atkJudgeFilter);
            this.Controls.Add(this.hpJudgeFilter);
            this.Controls.Add(this.CheckCuteCharm);
            this.Controls.Add(this.sensBox);
            this.Controls.Add(this.CheckTIDSIDFinder);
            this.Controls.Add(this.LabelFlawlessIVs);
            this.Controls.Add(this.InputFlawlessIVs);
            this.Controls.Add(this.LabelEMs);
            this.Controls.Add(this.InputEMs);
            this.Controls.Add(this.LabelKOCount);
            this.Controls.Add(this.InputKOCount);
            this.Controls.Add(this.ButtonUpdateStates);
            this.Controls.Add(this.CheckIsAbilityLocked);
            this.Controls.Add(this.RetailAdvancesTrackerNumResultsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RetailAdvancesTrackerResultState1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetailAdvancesTrackerResultState0);
            this.Controls.Add(this.RetailAdvancesTrackerSequenceLabel);
            this.Controls.Add(this.RetailAdvancesTrackerSequenceInput);
            this.Controls.Add(this.RetailAdvancesTrackerProgressBar);
            this.Controls.Add(this.RetailAdvancesTrackerGenerateButton);
            this.Controls.Add(this.RetailAdvancesTrackerMaxInput);
            this.Controls.Add(this.RetailAdvancesTrackerInitialInput);
            this.Controls.Add(this.RetailAdvancesTrackerMaxAdvInputLabel);
            this.Controls.Add(this.RetailAdvancesTrackerInitialInputLabel);
            this.Controls.Add(this.RetailAdvancesTrackerLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.SelectedShiny);
            this.Controls.Add(this.LabelShiny);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.LabelSlot);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.InputSlotMax);
            this.Controls.Add(this.InputSlotMin);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.InputLevelMax);
            this.Controls.Add(this.InputLevelMin);
            this.Controls.Add(this.CheckHeldItem);
            this.Controls.Add(this.CheckFishing);
            this.Controls.Add(this.CheckStatic);
            this.Controls.Add(this.CheckWeather);
            this.Controls.Add(this.CheckMarkCharm);
            this.Controls.Add(this.CheckShinyCharm);
            this.Controls.Add(this.SelectedMark);
            this.Controls.Add(this.LabelMark);
            this.Controls.Add(this.LabelMaxAdv);
            this.Controls.Add(this.InputMaxAdv);
            this.Controls.Add(this.LabelIDsSlash);
            this.Controls.Add(this.LabelTIDSID);
            this.Controls.Add(this.InputSID);
            this.Controls.Add(this.InputTID);
            this.Controls.Add(this.speMaxFilter);
            this.Controls.Add(this.speMinFilter);
            this.Controls.Add(this.spdMaxFilter);
            this.Controls.Add(this.spdMinFilter);
            this.Controls.Add(this.spaMaxFilter);
            this.Controls.Add(this.spaMinFilter);
            this.Controls.Add(this.defMaxFilter);
            this.Controls.Add(this.defMinFilter);
            this.Controls.Add(this.atkMaxFilter);
            this.Controls.Add(this.atkMinFilter);
            this.Controls.Add(this.hpMaxFilter);
            this.Controls.Add(this.hpMinFilter);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.speMax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.spdMax);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.spaMax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.defMax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.atkMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.speFilter);
            this.Controls.Add(this.spdFilter);
            this.Controls.Add(this.spaFilter);
            this.Controls.Add(this.defFilter);
            this.Controls.Add(this.atkFilter);
            this.Controls.Add(this.hpFilter);
            this.Controls.Add(this.speMin);
            this.Controls.Add(this.spdMin);
            this.Controls.Add(this.spaMin);
            this.Controls.Add(this.defMin);
            this.Controls.Add(this.atkMin);
            this.Controls.Add(this.hpMax);
            this.Controls.Add(this.hpMin);
            this.Controls.Add(this.LabelState1);
            this.Controls.Add(this.InputState1);
            this.Controls.Add(this.InputState0);
            this.Controls.Add(this.LabelState0);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ImageRareMark);
            this.Controls.Add(this.TextBoxCheckEncounter);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageRareMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generatorBindingSource)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelState0;
        private System.Windows.Forms.TextBox InputState0;
        private System.Windows.Forms.TextBox InputState1;
        private System.Windows.Forms.Label LabelState1;
        private System.Windows.Forms.TextBox hpMin;
        private System.Windows.Forms.TextBox hpMax;
        private System.Windows.Forms.Label hpFilter;
        private System.Windows.Forms.Label atkFilter;
        private System.Windows.Forms.Label defFilter;
        private System.Windows.Forms.Label spaFilter;
        private System.Windows.Forms.Label spdFilter;
        private System.Windows.Forms.Label speFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button hpMinFilter;
        private System.Windows.Forms.Button hpMaxFilter;
        private System.Windows.Forms.TextBox InputTID;
        private System.Windows.Forms.TextBox InputSID;
        private System.Windows.Forms.Label LabelTIDSID;
        private System.Windows.Forms.Label LabelIDsSlash;
        private System.Windows.Forms.TextBox InputMaxAdv;
        private System.Windows.Forms.Label LabelMaxAdv;
        private System.Windows.Forms.Label LabelMark;
        private System.Windows.Forms.PictureBox ImageRareMark;
        private System.Windows.Forms.ComboBox SelectedMark;
        private System.Windows.Forms.CheckBox CheckShinyCharm;
        private System.Windows.Forms.CheckBox CheckMarkCharm;
        private System.Windows.Forms.CheckBox CheckWeather;
        private System.Windows.Forms.CheckBox CheckStatic;
        private System.Windows.Forms.CheckBox CheckFishing;
        private System.Windows.Forms.CheckBox CheckHeldItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox InputLevelMax;
        private System.Windows.Forms.TextBox InputLevelMin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox InputSlotMax;
        private System.Windows.Forms.TextBox InputSlotMin;
        private System.Windows.Forms.Label LabelLevel;
        private System.Windows.Forms.Label LabelSlot;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ComboBox SelectedShiny;
        private System.Windows.Forms.Label LabelShiny;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button speMinFilter;
        private System.Windows.Forms.TextBox defMax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button spdMinFilter;
        private System.Windows.Forms.Button spdMaxFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button speMaxFilter;
        private System.Windows.Forms.TextBox spaMin;
        private System.Windows.Forms.Button atkMinFilter;
        private System.Windows.Forms.TextBox spdMin;
        private System.Windows.Forms.TextBox spdMax;
        private System.Windows.Forms.TextBox speMin;
        private System.Windows.Forms.TextBox speMax;
        private System.Windows.Forms.TextBox atkMax;
        private System.Windows.Forms.Button atkMaxFilter;
        private System.Windows.Forms.TextBox defMin;
        private System.Windows.Forms.Button defMinFilter;
        private System.Windows.Forms.Button spaMinFilter;
        private System.Windows.Forms.Button defMaxFilter;
        private System.Windows.Forms.TextBox spaMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox atkMin;
        private System.Windows.Forms.Button spaMaxFilter;
        private System.Windows.Forms.BindingSource generatorBindingSource;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label RetailAdvancesTrackerLabel;
        private System.Windows.Forms.Label RetailAdvancesTrackerInitialInputLabel;
        private System.Windows.Forms.Label RetailAdvancesTrackerMaxAdvInputLabel;
        private System.Windows.Forms.TextBox RetailAdvancesTrackerInitialInput;
        private System.Windows.Forms.TextBox RetailAdvancesTrackerMaxInput;
        private System.Windows.Forms.Button RetailAdvancesTrackerGenerateButton;
        private System.Windows.Forms.ProgressBar RetailAdvancesTrackerProgressBar;
        private System.Windows.Forms.TextBox RetailAdvancesTrackerSequenceInput;
        private System.Windows.Forms.Label RetailAdvancesTrackerSequenceLabel;
        private System.Windows.Forms.TextBox RetailAdvancesTrackerResultState0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RetailAdvancesTrackerResultState1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RetailAdvancesTrackerNumResultsLabel;
        private System.Windows.Forms.CheckBox CheckIsAbilityLocked;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SeedFinderMenu;
        private System.Windows.Forms.Button ButtonUpdateStates;
        private System.Windows.Forms.Label LabelKOCount;
        private System.Windows.Forms.TextBox InputKOCount;
        private System.Windows.Forms.CheckBox CheckTIDSIDFinder;
        private System.Windows.Forms.Label LabelEMs;
        private System.Windows.Forms.TextBox InputEMs;
        private System.Windows.Forms.Label LabelFlawlessIVs;
        private System.Windows.Forms.TextBox InputFlawlessIVs;
        private System.Windows.Forms.CheckBox sensBox;
        private System.Windows.Forms.CheckBox CheckCuteCharm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brilliant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Def;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn State0;
        private System.Windows.Forms.DataGridViewTextBoxColumn State1;
        private System.Windows.Forms.ComboBox hpJudgeFilter;
        private System.Windows.Forms.ComboBox atkJudgeFilter;
        private System.Windows.Forms.ComboBox defJudgeFilter;
        private System.Windows.Forms.ComboBox spaJudgeFilter;
        private System.Windows.Forms.ComboBox spdJudgeFilter;
        private System.Windows.Forms.ComboBox speJudgeFilter;
        private System.Windows.Forms.Label DesiredNature;
        private System.Windows.Forms.ComboBox SelectedNature;
        private System.Windows.Forms.Label LabelInitialAdv;
        private System.Windows.Forms.TextBox InputInitialAdv;
        private System.Windows.Forms.CheckBox CheckShinyLocked;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox SwitchIPInput;
        private System.Windows.Forms.Label SwitchIPLabel;
        private System.Windows.Forms.Label CurrentAdvancesLabel;
        private TextBox InputRAMOffset;
        private Label InputRAMOffsetLabel;
        private Label ConnectionStatusLabel;
        private Label ConnectionStatusText;
        private TextBox TrackAdv;
        private TextBox TextBoxCheckEncounter;
        private TextBox DaySkipAmountInput;
        private Button DaySkipButton;
        private Button ReadEncounterButton;
        private ComboBox SelectedAura;
        private Label LabelAura;
        private CheckBox CheckHidden;
        public PictureBox pictureBox1;
    }
}
