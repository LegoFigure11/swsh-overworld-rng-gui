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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            LabelState0 = new Label();
            InputState0 = new TextBox();
            InputState1 = new TextBox();
            LabelState1 = new Label();
            hpMin = new TextBox();
            hpMax = new TextBox();
            hpFilter = new Label();
            atkFilter = new Label();
            defFilter = new Label();
            spaFilter = new Label();
            spdFilter = new Label();
            speFilter = new Label();
            label10 = new Label();
            hpMinFilter = new Button();
            hpMaxFilter = new Button();
            InputTID = new TextBox();
            InputSID = new TextBox();
            LabelTIDSID = new Label();
            LabelIDsSlash = new Label();
            InputMaxAdv = new TextBox();
            LabelMaxAdv = new Label();
            LabelMark = new Label();
            ImageRareMark = new PictureBox();
            SelectedMark = new ComboBox();
            CheckShinyCharm = new CheckBox();
            CheckMarkCharm = new CheckBox();
            CheckWeather = new CheckBox();
            CheckStatic = new CheckBox();
            CheckFishing = new CheckBox();
            CheckHeldItem = new CheckBox();
            label20 = new Label();
            InputLevelMax = new TextBox();
            InputLevelMin = new TextBox();
            label21 = new Label();
            InputSlotMax = new TextBox();
            InputSlotMin = new TextBox();
            LabelLevel = new Label();
            LabelSlot = new Label();
            ButtonSearch = new Button();
            SelectedShiny = new ComboBox();
            LabelShiny = new Label();
            Results = new DataGridView();
            Frame = new DataGridViewTextBoxColumn();
            TID = new DataGridViewTextBoxColumn();
            SID = new DataGridViewTextBoxColumn();
            Animation = new DataGridViewTextBoxColumn();
            Jump = new DataGridViewTextBoxColumn();
            Steps = new DataGridViewTextBoxColumn();
            Brilliant = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            Slot = new DataGridViewTextBoxColumn();
            PID = new DataGridViewTextBoxColumn();
            EC = new DataGridViewTextBoxColumn();
            Shiny = new DataGridViewTextBoxColumn();
            Ability = new DataGridViewTextBoxColumn();
            Nature = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            HP = new DataGridViewTextBoxColumn();
            Atk = new DataGridViewTextBoxColumn();
            Def = new DataGridViewTextBoxColumn();
            SpA = new DataGridViewTextBoxColumn();
            SpD = new DataGridViewTextBoxColumn();
            Spe = new DataGridViewTextBoxColumn();
            Height = new DataGridViewTextBoxColumn();
            Mark = new DataGridViewTextBoxColumn();
            State0 = new DataGridViewTextBoxColumn();
            State1 = new DataGridViewTextBoxColumn();
            generatorBindingSource = new BindingSource(components);
            label12 = new Label();
            speMinFilter = new Button();
            defMax = new TextBox();
            label13 = new Label();
            label15 = new Label();
            spdMinFilter = new Button();
            spdMaxFilter = new Button();
            label11 = new Label();
            speMaxFilter = new Button();
            spaMin = new TextBox();
            atkMinFilter = new Button();
            spdMin = new TextBox();
            spdMax = new TextBox();
            speMin = new TextBox();
            speMax = new TextBox();
            atkMax = new TextBox();
            atkMaxFilter = new Button();
            defMin = new TextBox();
            defMinFilter = new Button();
            spaMinFilter = new Button();
            defMaxFilter = new Button();
            spaMax = new TextBox();
            label14 = new Label();
            atkMin = new TextBox();
            spaMaxFilter = new Button();
            progressBar1 = new ProgressBar();
            RetailAdvancesTrackerLabel = new Label();
            RetailAdvancesTrackerInitialInputLabel = new Label();
            RetailAdvancesTrackerMaxAdvInputLabel = new Label();
            RetailAdvancesTrackerInitialInput = new TextBox();
            RetailAdvancesTrackerMaxInput = new TextBox();
            RetailAdvancesTrackerGenerateButton = new Button();
            RetailAdvancesTrackerProgressBar = new ProgressBar();
            RetailAdvancesTrackerSequenceInput = new TextBox();
            RetailAdvancesTrackerSequenceLabel = new Label();
            RetailAdvancesTrackerResultState0 = new TextBox();
            label3 = new Label();
            RetailAdvancesTrackerResultState1 = new TextBox();
            label2 = new Label();
            RetailAdvancesTrackerNumResultsLabel = new Label();
            CheckIsAbilityLocked = new CheckBox();
            MainMenu = new MenuStrip();
            SeedFinderMenu = new ToolStripMenuItem();
            EncounterLookupMenu = new ToolStripMenuItem();
            CramomaticMenu = new ToolStripMenuItem();
            LotoIDMenu = new ToolStripMenuItem();
            WattTraderMenu = new ToolStripMenuItem();
            MenuCloseAdvancesViewerToolStripMenuItem = new ToolStripMenuItem();
            ButtonUpdateStates = new Button();
            CheckTIDSIDFinder = new CheckBox();
            LabelKOCount = new Label();
            InputKOCount = new TextBox();
            LabelEMs = new Label();
            InputEMs = new TextBox();
            LabelFlawlessIVs = new Label();
            InputFlawlessIVs = new TextBox();
            sensBox = new CheckBox();
            CheckCuteCharm = new CheckBox();
            hpJudgeFilter = new ComboBox();
            atkJudgeFilter = new ComboBox();
            defJudgeFilter = new ComboBox();
            spaJudgeFilter = new ComboBox();
            spdJudgeFilter = new ComboBox();
            speJudgeFilter = new ComboBox();
            DesiredNature = new Label();
            SelectedNature = new ComboBox();
            LabelInitialAdv = new Label();
            InputInitialAdv = new TextBox();
            CheckShinyLocked = new CheckBox();
            ConnectButton = new Button();
            DisconnectButton = new Button();
            SwitchIPInput = new TextBox();
            SwitchIPLabel = new Label();
            CurrentAdvancesLabel = new Label();
            InputRAMOffset = new TextBox();
            InputRAMOffsetLabel = new Label();
            ConnectionStatusLabel = new Label();
            ConnectionStatusText = new Label();
            TrackAdv = new TextBox();
            TextBoxCheckEncounter = new TextBox();
            SkipAmountInput = new TextBox();
            DaySkipButton = new Button();
            ReadEncounterButton = new Button();
            SelectedAura = new ComboBox();
            LabelAura = new Label();
            CheckHidden = new CheckBox();
            ShortSkipButton = new Button();
            LabelSkipMenu = new Label();
            PokeSprite = new PictureBox();
            MarkSprite = new PictureBox();
            CheckMenuClose = new CheckBox();
            LabelNPCs = new Label();
            InputNPCs = new TextBox();
            CheckFocusWindow = new CheckBox();
            CheckPlayTone = new CheckBox();
            Check3Seg = new CheckBox();
            LabelHeight = new Label();
            SelectedHeight = new ComboBox();
            CheckUseFilters = new CheckBox();
            NTPButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ImageRareMark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Results).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generatorBindingSource).BeginInit();
            MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PokeSprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarkSprite).BeginInit();
            SuspendLayout();
            // 
            // LabelState0
            // 
            LabelState0.AutoSize = true;
            LabelState0.Location = new System.Drawing.Point(12, 30);
            LabelState0.Name = "LabelState0";
            LabelState0.Size = new System.Drawing.Size(53, 15);
            LabelState0.TabIndex = 0;
            LabelState0.Text = "State[0]: ";
            // 
            // InputState0
            // 
            InputState0.Location = new System.Drawing.Point(68, 27);
            InputState0.MaxLength = 16;
            InputState0.Name = "InputState0";
            InputState0.Size = new System.Drawing.Size(189, 23);
            InputState0.TabIndex = 0;
            InputState0.KeyDown += InputStatePaste_KeyDown;
            InputState0.KeyPress += HexInput_KeyPress;
            // 
            // InputState1
            // 
            InputState1.Location = new System.Drawing.Point(68, 53);
            InputState1.MaxLength = 16;
            InputState1.Name = "InputState1";
            InputState1.Size = new System.Drawing.Size(189, 23);
            InputState1.TabIndex = 1;
            InputState1.KeyDown += InputStatePaste_KeyDown;
            InputState1.KeyPress += HexInput_KeyPress;
            // 
            // LabelState1
            // 
            LabelState1.AutoSize = true;
            LabelState1.Location = new System.Drawing.Point(12, 57);
            LabelState1.Name = "LabelState1";
            LabelState1.Size = new System.Drawing.Size(50, 15);
            LabelState1.TabIndex = 3;
            LabelState1.Text = "State[1]:";
            // 
            // hpMin
            // 
            hpMin.Location = new System.Drawing.Point(330, 27);
            hpMin.Name = "hpMin";
            hpMin.Size = new System.Drawing.Size(28, 23);
            hpMin.TabIndex = 5;
            hpMin.Text = "0";
            hpMin.TextAlign = HorizontalAlignment.Center;
            hpMin.TextChanged += IVs_TextChanged;
            hpMin.KeyPress += DecInput_KeyPress;
            hpMin.Leave += Filter_LostFocus;
            // 
            // hpMax
            // 
            hpMax.Location = new System.Drawing.Point(380, 27);
            hpMax.Name = "hpMax";
            hpMax.Size = new System.Drawing.Size(28, 23);
            hpMax.TabIndex = 6;
            hpMax.Text = "31";
            hpMax.TextAlign = HorizontalAlignment.Center;
            hpMax.TextChanged += IVs_TextChanged;
            hpMax.KeyPress += DecInput_KeyPress;
            hpMax.Leave += Filter_LostFocus;
            // 
            // hpFilter
            // 
            hpFilter.AutoSize = true;
            hpFilter.Location = new System.Drawing.Point(298, 30);
            hpFilter.Name = "hpFilter";
            hpFilter.Size = new System.Drawing.Size(26, 15);
            hpFilter.TabIndex = 16;
            hpFilter.Text = "HP:";
            hpFilter.Click += ResetFilters;
            // 
            // atkFilter
            // 
            atkFilter.AutoSize = true;
            atkFilter.Location = new System.Drawing.Point(296, 56);
            atkFilter.Name = "atkFilter";
            atkFilter.Size = new System.Drawing.Size(28, 15);
            atkFilter.TabIndex = 17;
            atkFilter.Text = "Atk:";
            atkFilter.Click += ResetFilters;
            // 
            // defFilter
            // 
            defFilter.AutoSize = true;
            defFilter.Location = new System.Drawing.Point(296, 80);
            defFilter.Name = "defFilter";
            defFilter.Size = new System.Drawing.Size(28, 15);
            defFilter.TabIndex = 18;
            defFilter.Text = "Def:";
            defFilter.Click += ResetFilters;
            // 
            // spaFilter
            // 
            spaFilter.AutoSize = true;
            spaFilter.Location = new System.Drawing.Point(293, 106);
            spaFilter.Name = "spaFilter";
            spaFilter.Size = new System.Drawing.Size(31, 15);
            spaFilter.TabIndex = 19;
            spaFilter.Text = "SpA:";
            spaFilter.Click += ResetFilters;
            // 
            // spdFilter
            // 
            spdFilter.AutoSize = true;
            spdFilter.Location = new System.Drawing.Point(293, 131);
            spdFilter.Name = "spdFilter";
            spdFilter.Size = new System.Drawing.Size(31, 15);
            spdFilter.TabIndex = 20;
            spdFilter.Text = "SpD:";
            spdFilter.Click += ResetFilters;
            // 
            // speFilter
            // 
            speFilter.AutoSize = true;
            speFilter.Location = new System.Drawing.Point(295, 157);
            speFilter.Name = "speFilter";
            speFilter.Size = new System.Drawing.Size(29, 15);
            speFilter.TabIndex = 21;
            speFilter.Text = "Spe:";
            speFilter.Click += ResetFilters;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(364, 30);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(12, 15);
            label10.TabIndex = 22;
            label10.Text = "-";
            // 
            // hpMinFilter
            // 
            hpMinFilter.Location = new System.Drawing.Point(427, 26);
            hpMinFilter.Name = "hpMinFilter";
            hpMinFilter.Size = new System.Drawing.Size(29, 20);
            hpMinFilter.TabIndex = 17;
            hpMinFilter.Text = "0";
            hpMinFilter.UseVisualStyleBackColor = true;
            hpMinFilter.Click += StatMinFilter_Click;
            // 
            // hpMaxFilter
            // 
            hpMaxFilter.Location = new System.Drawing.Point(461, 26);
            hpMaxFilter.Name = "hpMaxFilter";
            hpMaxFilter.Size = new System.Drawing.Size(29, 20);
            hpMaxFilter.TabIndex = 18;
            hpMaxFilter.Text = "31";
            hpMaxFilter.UseVisualStyleBackColor = true;
            hpMaxFilter.Click += StatMaxFilter_Click;
            // 
            // InputTID
            // 
            InputTID.Location = new System.Drawing.Point(66, 82);
            InputTID.MaxLength = 5;
            InputTID.Name = "InputTID";
            InputTID.Size = new System.Drawing.Size(44, 23);
            InputTID.TabIndex = 2;
            InputTID.Text = "01390";
            InputTID.TextChanged += TIDSID_TextChanged;
            InputTID.KeyPress += DecInput_KeyPress;
            InputTID.Leave += SetToZero_LostFocus;
            // 
            // InputSID
            // 
            InputSID.Location = new System.Drawing.Point(124, 82);
            InputSID.MaxLength = 5;
            InputSID.Name = "InputSID";
            InputSID.Size = new System.Drawing.Size(44, 23);
            InputSID.TabIndex = 3;
            InputSID.Text = "01337";
            InputSID.TextChanged += TIDSID_TextChanged;
            InputSID.KeyPress += DecInput_KeyPress;
            InputSID.Leave += SetToZero_LostFocus;
            // 
            // LabelTIDSID
            // 
            LabelTIDSID.AutoSize = true;
            LabelTIDSID.Location = new System.Drawing.Point(5, 84);
            LabelTIDSID.Name = "LabelTIDSID";
            LabelTIDSID.Size = new System.Drawing.Size(55, 15);
            LabelTIDSID.TabIndex = 47;
            LabelTIDSID.Text = "TID / SID:";
            // 
            // LabelIDsSlash
            // 
            LabelIDsSlash.AutoSize = true;
            LabelIDsSlash.Location = new System.Drawing.Point(111, 86);
            LabelIDsSlash.Name = "LabelIDsSlash";
            LabelIDsSlash.Size = new System.Drawing.Size(12, 15);
            LabelIDsSlash.TabIndex = 48;
            LabelIDsSlash.Text = "/";
            // 
            // InputMaxAdv
            // 
            InputMaxAdv.Location = new System.Drawing.Point(66, 134);
            InputMaxAdv.MaxLength = 13;
            InputMaxAdv.Name = "InputMaxAdv";
            InputMaxAdv.Size = new System.Drawing.Size(102, 23);
            InputMaxAdv.TabIndex = 4;
            InputMaxAdv.Text = "50000";
            InputMaxAdv.KeyPress += DecInput_KeyPress;
            InputMaxAdv.Leave += SetToZero_LostFocus;
            // 
            // LabelMaxAdv
            // 
            LabelMaxAdv.AutoSize = true;
            LabelMaxAdv.Location = new System.Drawing.Point(45, 137);
            LabelMaxAdv.Name = "LabelMaxAdv";
            LabelMaxAdv.Size = new System.Drawing.Size(15, 15);
            LabelMaxAdv.TabIndex = 50;
            LabelMaxAdv.Text = "+";
            // 
            // LabelMark
            // 
            LabelMark.AutoSize = true;
            LabelMark.Location = new System.Drawing.Point(436, 261);
            LabelMark.Name = "LabelMark";
            LabelMark.Size = new System.Drawing.Size(37, 15);
            LabelMark.TabIndex = 52;
            LabelMark.Text = "Mark:";
            // 
            // ImageRareMark
            // 
            ImageRareMark.Image = Properties.Resources.raremark;
            ImageRareMark.Location = new System.Drawing.Point(706, 339);
            ImageRareMark.Name = "ImageRareMark";
            ImageRareMark.Size = new System.Drawing.Size(91, 90);
            ImageRareMark.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageRareMark.TabIndex = 53;
            ImageRareMark.TabStop = false;
            // 
            // SelectedMark
            // 
            SelectedMark.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectedMark.FormattingEnabled = true;
            SelectedMark.Items.AddRange(new object[] { "Ignore", "None", "Any Mark", "Any Personality", "Uncommon", "Time", "Weather", "Fishing", "Rare", "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" });
            SelectedMark.Location = new System.Drawing.Point(475, 258);
            SelectedMark.Name = "SelectedMark";
            SelectedMark.Size = new System.Drawing.Size(103, 23);
            SelectedMark.TabIndex = 29;
            // 
            // CheckShinyCharm
            // 
            CheckShinyCharm.AutoSize = true;
            CheckShinyCharm.Location = new System.Drawing.Point(174, 85);
            CheckShinyCharm.Name = "CheckShinyCharm";
            CheckShinyCharm.Size = new System.Drawing.Size(94, 19);
            CheckShinyCharm.TabIndex = 31;
            CheckShinyCharm.Text = "Shiny Charm";
            CheckShinyCharm.UseVisualStyleBackColor = true;
            CheckShinyCharm.CheckedChanged += SaveCheckbox_CheckChanged;
            // 
            // CheckMarkCharm
            // 
            CheckMarkCharm.AutoSize = true;
            CheckMarkCharm.Location = new System.Drawing.Point(174, 110);
            CheckMarkCharm.Name = "CheckMarkCharm";
            CheckMarkCharm.Size = new System.Drawing.Size(92, 19);
            CheckMarkCharm.TabIndex = 33;
            CheckMarkCharm.Text = "Mark Charm";
            CheckMarkCharm.UseVisualStyleBackColor = true;
            CheckMarkCharm.CheckedChanged += SaveCheckbox_CheckChanged;
            // 
            // CheckWeather
            // 
            CheckWeather.AutoSize = true;
            CheckWeather.Location = new System.Drawing.Point(12, 183);
            CheckWeather.Name = "CheckWeather";
            CheckWeather.Size = new System.Drawing.Size(70, 19);
            CheckWeather.TabIndex = 35;
            CheckWeather.Text = "Weather";
            CheckWeather.UseVisualStyleBackColor = true;
            // 
            // CheckStatic
            // 
            CheckStatic.AutoSize = true;
            CheckStatic.Location = new System.Drawing.Point(12, 160);
            CheckStatic.Name = "CheckStatic";
            CheckStatic.Size = new System.Drawing.Size(55, 19);
            CheckStatic.TabIndex = 32;
            CheckStatic.Text = "Static";
            CheckStatic.UseVisualStyleBackColor = true;
            CheckStatic.CheckedChanged += CheckStatic_CheckedChanged;
            // 
            // CheckFishing
            // 
            CheckFishing.AutoSize = true;
            CheckFishing.Location = new System.Drawing.Point(12, 206);
            CheckFishing.Name = "CheckFishing";
            CheckFishing.Size = new System.Drawing.Size(64, 19);
            CheckFishing.TabIndex = 34;
            CheckFishing.Text = "Fishing";
            CheckFishing.UseVisualStyleBackColor = true;
            // 
            // CheckHeldItem
            // 
            CheckHeldItem.AutoSize = true;
            CheckHeldItem.Location = new System.Drawing.Point(12, 252);
            CheckHeldItem.Name = "CheckHeldItem";
            CheckHeldItem.Size = new System.Drawing.Size(124, 19);
            CheckHeldItem.TabIndex = 36;
            CheckHeldItem.Text = "Random held item";
            CheckHeldItem.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(216, 284);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(12, 15);
            label20.TabIndex = 64;
            label20.Text = "-";
            // 
            // InputLevelMax
            // 
            InputLevelMax.Location = new System.Drawing.Point(232, 281);
            InputLevelMax.MaxLength = 2;
            InputLevelMax.Name = "InputLevelMax";
            InputLevelMax.Size = new System.Drawing.Size(28, 23);
            InputLevelMax.TabIndex = 39;
            InputLevelMax.Text = "0";
            InputLevelMax.TextAlign = HorizontalAlignment.Center;
            InputLevelMax.TextChanged += LevelSlot_TextChanged;
            InputLevelMax.KeyPress += DecInput_KeyPress;
            InputLevelMax.Leave += SetToZero_LostFocus;
            // 
            // InputLevelMin
            // 
            InputLevelMin.Location = new System.Drawing.Point(182, 281);
            InputLevelMin.MaxLength = 2;
            InputLevelMin.Name = "InputLevelMin";
            InputLevelMin.Size = new System.Drawing.Size(28, 23);
            InputLevelMin.TabIndex = 38;
            InputLevelMin.Text = "0";
            InputLevelMin.TextAlign = HorizontalAlignment.Center;
            InputLevelMin.TextChanged += LevelSlot_TextChanged;
            InputLevelMin.KeyPress += DecInput_KeyPress;
            InputLevelMin.Leave += SetToZero_LostFocus;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(216, 258);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(12, 15);
            label21.TabIndex = 67;
            label21.Text = "-";
            // 
            // InputSlotMax
            // 
            InputSlotMax.Location = new System.Drawing.Point(232, 255);
            InputSlotMax.MaxLength = 2;
            InputSlotMax.Name = "InputSlotMax";
            InputSlotMax.Size = new System.Drawing.Size(28, 23);
            InputSlotMax.TabIndex = 41;
            InputSlotMax.Text = "99";
            InputSlotMax.TextAlign = HorizontalAlignment.Center;
            InputSlotMax.TextChanged += LevelSlot_TextChanged;
            InputSlotMax.KeyPress += DecInput_KeyPress;
            InputSlotMax.Leave += SetToZero_LostFocus;
            // 
            // InputSlotMin
            // 
            InputSlotMin.Location = new System.Drawing.Point(182, 255);
            InputSlotMin.MaxLength = 2;
            InputSlotMin.Name = "InputSlotMin";
            InputSlotMin.Size = new System.Drawing.Size(28, 23);
            InputSlotMin.TabIndex = 40;
            InputSlotMin.Text = "0";
            InputSlotMin.TextAlign = HorizontalAlignment.Center;
            InputSlotMin.TextChanged += LevelSlot_TextChanged;
            InputSlotMin.KeyPress += DecInput_KeyPress;
            InputSlotMin.Leave += SetToZero_LostFocus;
            // 
            // LabelLevel
            // 
            LabelLevel.AutoSize = true;
            LabelLevel.Location = new System.Drawing.Point(139, 284);
            LabelLevel.Name = "LabelLevel";
            LabelLevel.Size = new System.Drawing.Size(37, 15);
            LabelLevel.TabIndex = 68;
            LabelLevel.Text = "Level:";
            // 
            // LabelSlot
            // 
            LabelSlot.AutoSize = true;
            LabelSlot.Location = new System.Drawing.Point(146, 258);
            LabelSlot.Name = "LabelSlot";
            LabelSlot.Size = new System.Drawing.Size(30, 15);
            LabelSlot.TabIndex = 69;
            LabelSlot.Text = "Slot:";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new System.Drawing.Point(247, 377);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new System.Drawing.Size(341, 46);
            ButtonSearch.TabIndex = 42;
            ButtonSearch.Text = "Search!";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // SelectedShiny
            // 
            SelectedShiny.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectedShiny.FormattingEnabled = true;
            SelectedShiny.Items.AddRange(new object[] { "Ignore", "No", "Square", "Star", "Star/Square" });
            SelectedShiny.Location = new System.Drawing.Point(475, 231);
            SelectedShiny.Name = "SelectedShiny";
            SelectedShiny.Size = new System.Drawing.Size(103, 23);
            SelectedShiny.TabIndex = 30;
            // 
            // LabelShiny
            // 
            LabelShiny.AutoSize = true;
            LabelShiny.Location = new System.Drawing.Point(434, 235);
            LabelShiny.Name = "LabelShiny";
            LabelShiny.Size = new System.Drawing.Size(39, 15);
            LabelShiny.TabIndex = 71;
            LabelShiny.Text = "Shiny:";
            // 
            // Results
            // 
            Results.AllowUserToAddRows = false;
            Results.AllowUserToDeleteRows = false;
            Results.AllowUserToResizeRows = false;
            Results.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Results.AutoGenerateColumns = false;
            Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Results.Columns.AddRange(new DataGridViewColumn[] { Frame, TID, SID, Animation, Jump, Steps, Brilliant, Level, Slot, PID, EC, Shiny, Ability, Nature, Gender, HP, Atk, Def, SpA, SpD, Spe, Height, Mark, State0, State1 });
            Results.DataSource = generatorBindingSource;
            Results.Location = new System.Drawing.Point(12, 463);
            Results.MultiSelect = false;
            Results.Name = "Results";
            Results.ReadOnly = true;
            Results.RowHeadersVisible = false;
            Results.RowHeadersWidth = 62;
            Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Results.Size = new System.Drawing.Size(808, 224);
            Results.TabIndex = 73;
            // 
            // Frame
            // 
            Frame.DataPropertyName = "Advances";
            Frame.HeaderText = "Frame";
            Frame.MinimumWidth = 8;
            Frame.Name = "Frame";
            Frame.ReadOnly = true;
            Frame.Width = 150;
            // 
            // TID
            // 
            TID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TID.DataPropertyName = "TID";
            TID.HeaderText = "TID";
            TID.MinimumWidth = 8;
            TID.Name = "TID";
            TID.ReadOnly = true;
            TID.Width = 49;
            // 
            // SID
            // 
            SID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SID.DataPropertyName = "SID";
            SID.HeaderText = "SID";
            SID.MinimumWidth = 8;
            SID.Name = "SID";
            SID.ReadOnly = true;
            SID.Width = 49;
            // 
            // Animation
            // 
            Animation.DataPropertyName = "Animation";
            Animation.HeaderText = "Animation";
            Animation.MinimumWidth = 8;
            Animation.Name = "Animation";
            Animation.ReadOnly = true;
            Animation.Width = 60;
            // 
            // Jump
            // 
            Jump.DataPropertyName = "Jump";
            Jump.HeaderText = "Jump";
            Jump.Name = "Jump";
            Jump.ReadOnly = true;
            Jump.Width = 59;
            // 
            // Steps
            // 
            Steps.DataPropertyName = "Steps";
            Steps.HeaderText = "Steps";
            Steps.Name = "Steps";
            Steps.ReadOnly = true;
            Steps.Width = 59;
            // 
            // Brilliant
            // 
            Brilliant.DataPropertyName = "Brilliant";
            Brilliant.HeaderText = "Brilliant";
            Brilliant.MinimumWidth = 6;
            Brilliant.Name = "Brilliant";
            Brilliant.ReadOnly = true;
            Brilliant.Width = 59;
            // 
            // Level
            // 
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Level.DataPropertyName = "Level";
            Level.HeaderText = "Level";
            Level.MinimumWidth = 8;
            Level.Name = "Level";
            Level.ReadOnly = true;
            Level.Width = 59;
            // 
            // Slot
            // 
            Slot.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Slot.DataPropertyName = "Slot";
            Slot.HeaderText = "Slot";
            Slot.MinimumWidth = 8;
            Slot.Name = "Slot";
            Slot.ReadOnly = true;
            Slot.Width = 52;
            // 
            // PID
            // 
            PID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PID.DataPropertyName = "PID";
            PID.HeaderText = "PID";
            PID.MinimumWidth = 8;
            PID.Name = "PID";
            PID.ReadOnly = true;
            PID.Width = 50;
            // 
            // EC
            // 
            EC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EC.DataPropertyName = "EC";
            EC.HeaderText = "EC";
            EC.MinimumWidth = 8;
            EC.Name = "EC";
            EC.ReadOnly = true;
            EC.Width = 46;
            // 
            // Shiny
            // 
            Shiny.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Shiny.DataPropertyName = "Shiny";
            Shiny.HeaderText = "Shiny";
            Shiny.MinimumWidth = 8;
            Shiny.Name = "Shiny";
            Shiny.ReadOnly = true;
            Shiny.Width = 61;
            // 
            // Ability
            // 
            Ability.DataPropertyName = "Ability";
            Ability.HeaderText = "Ability";
            Ability.MinimumWidth = 8;
            Ability.Name = "Ability";
            Ability.ReadOnly = true;
            Ability.Width = 50;
            // 
            // Nature
            // 
            Nature.DataPropertyName = "Nature";
            Nature.HeaderText = "Nature";
            Nature.MinimumWidth = 8;
            Nature.Name = "Nature";
            Nature.ReadOnly = true;
            Nature.Width = 75;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 125;
            // 
            // HP
            // 
            HP.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HP.DataPropertyName = "HP";
            HP.HeaderText = "HP";
            HP.MinimumWidth = 8;
            HP.Name = "HP";
            HP.ReadOnly = true;
            HP.Width = 34;
            // 
            // Atk
            // 
            Atk.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Atk.DataPropertyName = "Atk";
            Atk.HeaderText = "Atk";
            Atk.MinimumWidth = 8;
            Atk.Name = "Atk";
            Atk.ReadOnly = true;
            Atk.Width = 34;
            // 
            // Def
            // 
            Def.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Def.DataPropertyName = "Def";
            Def.HeaderText = "Def";
            Def.MinimumWidth = 8;
            Def.Name = "Def";
            Def.ReadOnly = true;
            Def.Width = 34;
            // 
            // SpA
            // 
            SpA.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SpA.DataPropertyName = "SpA";
            SpA.HeaderText = "SpA";
            SpA.MinimumWidth = 8;
            SpA.Name = "SpA";
            SpA.ReadOnly = true;
            SpA.Width = 34;
            // 
            // SpD
            // 
            SpD.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SpD.DataPropertyName = "SpD";
            SpD.HeaderText = "SpD";
            SpD.MinimumWidth = 8;
            SpD.Name = "SpD";
            SpD.ReadOnly = true;
            SpD.Width = 34;
            // 
            // Spe
            // 
            Spe.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Spe.DataPropertyName = "Spe";
            Spe.HeaderText = "Spe";
            Spe.MinimumWidth = 8;
            Spe.Name = "Spe";
            Spe.ReadOnly = true;
            Spe.Width = 34;
            // 
            // Height
            // 
            Height.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Height.DataPropertyName = "Height";
            Height.HeaderText = "Height";
            Height.MinimumWidth = 8;
            Height.Name = "Height";
            Height.ReadOnly = true;
            Height.Width = 68;
            // 
            // Mark
            // 
            Mark.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Mark.DataPropertyName = "Mark";
            Mark.HeaderText = "Mark";
            Mark.MinimumWidth = 8;
            Mark.Name = "Mark";
            Mark.ReadOnly = true;
            Mark.Width = 59;
            // 
            // State0
            // 
            State0.DataPropertyName = "State0";
            State0.HeaderText = "State0";
            State0.MinimumWidth = 8;
            State0.Name = "State0";
            State0.ReadOnly = true;
            State0.Width = 150;
            // 
            // State1
            // 
            State1.DataPropertyName = "State1";
            State1.HeaderText = "State1";
            State1.MinimumWidth = 8;
            State1.Name = "State1";
            State1.ReadOnly = true;
            State1.Width = 150;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(364, 80);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(12, 15);
            label12.TabIndex = 26;
            label12.Text = "-";
            // 
            // speMinFilter
            // 
            speMinFilter.Location = new System.Drawing.Point(426, 154);
            speMinFilter.Name = "speMinFilter";
            speMinFilter.Size = new System.Drawing.Size(29, 20);
            speMinFilter.TabIndex = 27;
            speMinFilter.Text = "0";
            speMinFilter.UseVisualStyleBackColor = true;
            speMinFilter.Click += StatMinFilter_Click;
            // 
            // defMax
            // 
            defMax.Location = new System.Drawing.Point(380, 77);
            defMax.Name = "defMax";
            defMax.Size = new System.Drawing.Size(28, 23);
            defMax.TabIndex = 10;
            defMax.Text = "31";
            defMax.TextAlign = HorizontalAlignment.Center;
            defMax.TextChanged += IVs_TextChanged;
            defMax.KeyPress += DecInput_KeyPress;
            defMax.Leave += Filter_LostFocus;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(364, 107);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(12, 15);
            label13.TabIndex = 28;
            label13.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(364, 157);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(12, 15);
            label15.TabIndex = 32;
            label15.Text = "-";
            // 
            // spdMinFilter
            // 
            spdMinFilter.Location = new System.Drawing.Point(426, 128);
            spdMinFilter.Name = "spdMinFilter";
            spdMinFilter.Size = new System.Drawing.Size(29, 20);
            spdMinFilter.TabIndex = 25;
            spdMinFilter.Text = "0";
            spdMinFilter.UseVisualStyleBackColor = true;
            spdMinFilter.Click += StatMinFilter_Click;
            // 
            // spdMaxFilter
            // 
            spdMaxFilter.Location = new System.Drawing.Point(461, 128);
            spdMaxFilter.Name = "spdMaxFilter";
            spdMaxFilter.Size = new System.Drawing.Size(29, 20);
            spdMaxFilter.TabIndex = 26;
            spdMaxFilter.Text = "31";
            spdMaxFilter.UseVisualStyleBackColor = true;
            spdMaxFilter.Click += StatMaxFilter_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(364, 54);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(12, 15);
            label11.TabIndex = 24;
            label11.Text = "-";
            // 
            // speMaxFilter
            // 
            speMaxFilter.Location = new System.Drawing.Point(461, 154);
            speMaxFilter.Name = "speMaxFilter";
            speMaxFilter.Size = new System.Drawing.Size(29, 20);
            speMaxFilter.TabIndex = 28;
            speMaxFilter.Text = "31";
            speMaxFilter.UseVisualStyleBackColor = true;
            speMaxFilter.Click += StatMaxFilter_Click;
            // 
            // spaMin
            // 
            spaMin.Location = new System.Drawing.Point(330, 102);
            spaMin.Name = "spaMin";
            spaMin.Size = new System.Drawing.Size(28, 23);
            spaMin.TabIndex = 11;
            spaMin.Text = "0";
            spaMin.TextAlign = HorizontalAlignment.Center;
            spaMin.TextChanged += IVs_TextChanged;
            spaMin.KeyPress += DecInput_KeyPress;
            spaMin.Leave += Filter_LostFocus;
            // 
            // atkMinFilter
            // 
            atkMinFilter.Location = new System.Drawing.Point(427, 52);
            atkMinFilter.Name = "atkMinFilter";
            atkMinFilter.Size = new System.Drawing.Size(29, 20);
            atkMinFilter.TabIndex = 19;
            atkMinFilter.Text = "0";
            atkMinFilter.UseVisualStyleBackColor = true;
            atkMinFilter.Click += StatMinFilter_Click;
            // 
            // spdMin
            // 
            spdMin.Location = new System.Drawing.Point(330, 128);
            spdMin.Name = "spdMin";
            spdMin.Size = new System.Drawing.Size(28, 23);
            spdMin.TabIndex = 13;
            spdMin.Text = "0";
            spdMin.TextAlign = HorizontalAlignment.Center;
            spdMin.TextChanged += IVs_TextChanged;
            spdMin.KeyPress += DecInput_KeyPress;
            spdMin.Leave += Filter_LostFocus;
            // 
            // spdMax
            // 
            spdMax.Location = new System.Drawing.Point(380, 128);
            spdMax.Name = "spdMax";
            spdMax.Size = new System.Drawing.Size(28, 23);
            spdMax.TabIndex = 14;
            spdMax.Text = "31";
            spdMax.TextAlign = HorizontalAlignment.Center;
            spdMax.TextChanged += IVs_TextChanged;
            spdMax.KeyPress += DecInput_KeyPress;
            spdMax.Leave += Filter_LostFocus;
            // 
            // speMin
            // 
            speMin.Location = new System.Drawing.Point(330, 154);
            speMin.Name = "speMin";
            speMin.Size = new System.Drawing.Size(28, 23);
            speMin.TabIndex = 15;
            speMin.Text = "0";
            speMin.TextAlign = HorizontalAlignment.Center;
            speMin.TextChanged += IVs_TextChanged;
            speMin.KeyPress += DecInput_KeyPress;
            speMin.Leave += Filter_LostFocus;
            // 
            // speMax
            // 
            speMax.Location = new System.Drawing.Point(380, 154);
            speMax.Name = "speMax";
            speMax.Size = new System.Drawing.Size(28, 23);
            speMax.TabIndex = 16;
            speMax.Text = "31";
            speMax.TextAlign = HorizontalAlignment.Center;
            speMax.TextChanged += IVs_TextChanged;
            speMax.KeyPress += DecInput_KeyPress;
            speMax.Leave += Filter_LostFocus;
            // 
            // atkMax
            // 
            atkMax.Location = new System.Drawing.Point(380, 53);
            atkMax.Name = "atkMax";
            atkMax.Size = new System.Drawing.Size(28, 23);
            atkMax.TabIndex = 8;
            atkMax.Text = "31";
            atkMax.TextAlign = HorizontalAlignment.Center;
            atkMax.TextChanged += IVs_TextChanged;
            atkMax.KeyPress += DecInput_KeyPress;
            atkMax.Leave += Filter_LostFocus;
            // 
            // atkMaxFilter
            // 
            atkMaxFilter.Location = new System.Drawing.Point(461, 52);
            atkMaxFilter.Name = "atkMaxFilter";
            atkMaxFilter.Size = new System.Drawing.Size(29, 20);
            atkMaxFilter.TabIndex = 20;
            atkMaxFilter.Text = "31";
            atkMaxFilter.UseVisualStyleBackColor = true;
            atkMaxFilter.Click += StatMaxFilter_Click;
            // 
            // defMin
            // 
            defMin.Location = new System.Drawing.Point(330, 77);
            defMin.Name = "defMin";
            defMin.Size = new System.Drawing.Size(28, 23);
            defMin.TabIndex = 9;
            defMin.Text = "0";
            defMin.TextAlign = HorizontalAlignment.Center;
            defMin.TextChanged += IVs_TextChanged;
            defMin.KeyPress += DecInput_KeyPress;
            defMin.Leave += Filter_LostFocus;
            // 
            // defMinFilter
            // 
            defMinFilter.Location = new System.Drawing.Point(427, 77);
            defMinFilter.Name = "defMinFilter";
            defMinFilter.Size = new System.Drawing.Size(29, 20);
            defMinFilter.TabIndex = 21;
            defMinFilter.Text = "0";
            defMinFilter.UseVisualStyleBackColor = true;
            defMinFilter.Click += StatMinFilter_Click;
            // 
            // spaMinFilter
            // 
            spaMinFilter.Location = new System.Drawing.Point(427, 103);
            spaMinFilter.Name = "spaMinFilter";
            spaMinFilter.Size = new System.Drawing.Size(29, 20);
            spaMinFilter.TabIndex = 23;
            spaMinFilter.Text = "0";
            spaMinFilter.UseVisualStyleBackColor = true;
            spaMinFilter.Click += StatMinFilter_Click;
            // 
            // defMaxFilter
            // 
            defMaxFilter.Location = new System.Drawing.Point(461, 77);
            defMaxFilter.Name = "defMaxFilter";
            defMaxFilter.Size = new System.Drawing.Size(29, 20);
            defMaxFilter.TabIndex = 22;
            defMaxFilter.Text = "31";
            defMaxFilter.UseVisualStyleBackColor = true;
            defMaxFilter.Click += StatMaxFilter_Click;
            // 
            // spaMax
            // 
            spaMax.Location = new System.Drawing.Point(380, 103);
            spaMax.Name = "spaMax";
            spaMax.Size = new System.Drawing.Size(28, 23);
            spaMax.TabIndex = 12;
            spaMax.Text = "31";
            spaMax.TextAlign = HorizontalAlignment.Center;
            spaMax.TextChanged += IVs_TextChanged;
            spaMax.KeyPress += DecInput_KeyPress;
            spaMax.Leave += Filter_LostFocus;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(364, 130);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(12, 15);
            label14.TabIndex = 30;
            label14.Text = "-";
            // 
            // atkMin
            // 
            atkMin.Location = new System.Drawing.Point(330, 52);
            atkMin.Name = "atkMin";
            atkMin.Size = new System.Drawing.Size(28, 23);
            atkMin.TabIndex = 7;
            atkMin.Text = "0";
            atkMin.TextAlign = HorizontalAlignment.Center;
            atkMin.TextChanged += IVs_TextChanged;
            atkMin.KeyPress += DecInput_KeyPress;
            atkMin.Leave += Filter_LostFocus;
            // 
            // spaMaxFilter
            // 
            spaMaxFilter.Location = new System.Drawing.Point(461, 103);
            spaMaxFilter.Name = "spaMaxFilter";
            spaMaxFilter.Size = new System.Drawing.Size(29, 20);
            spaMaxFilter.TabIndex = 24;
            spaMaxFilter.Text = "31";
            spaMaxFilter.UseVisualStyleBackColor = true;
            spaMaxFilter.Click += StatMaxFilter_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            progressBar1.Location = new System.Drawing.Point(247, 429);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(341, 21);
            progressBar1.TabIndex = 74;
            // 
            // RetailAdvancesTrackerLabel
            // 
            RetailAdvancesTrackerLabel.AutoSize = true;
            RetailAdvancesTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RetailAdvancesTrackerLabel.Location = new System.Drawing.Point(602, 29);
            RetailAdvancesTrackerLabel.Name = "RetailAdvancesTrackerLabel";
            RetailAdvancesTrackerLabel.Size = new System.Drawing.Size(148, 13);
            RetailAdvancesTrackerLabel.TabIndex = 75;
            RetailAdvancesTrackerLabel.Text = "Retail Advances Tracker";
            // 
            // RetailAdvancesTrackerInitialInputLabel
            // 
            RetailAdvancesTrackerInitialInputLabel.AutoSize = true;
            RetailAdvancesTrackerInitialInputLabel.Location = new System.Drawing.Point(602, 55);
            RetailAdvancesTrackerInitialInputLabel.Name = "RetailAdvancesTrackerInitialInputLabel";
            RetailAdvancesTrackerInitialInputLabel.Size = new System.Drawing.Size(66, 15);
            RetailAdvancesTrackerInitialInputLabel.TabIndex = 76;
            RetailAdvancesTrackerInitialInputLabel.Text = "Initial Adv.:";
            // 
            // RetailAdvancesTrackerMaxAdvInputLabel
            // 
            RetailAdvancesTrackerMaxAdvInputLabel.AutoSize = true;
            RetailAdvancesTrackerMaxAdvInputLabel.Location = new System.Drawing.Point(648, 81);
            RetailAdvancesTrackerMaxAdvInputLabel.Name = "RetailAdvancesTrackerMaxAdvInputLabel";
            RetailAdvancesTrackerMaxAdvInputLabel.Size = new System.Drawing.Size(15, 15);
            RetailAdvancesTrackerMaxAdvInputLabel.TabIndex = 77;
            RetailAdvancesTrackerMaxAdvInputLabel.Text = "+";
            // 
            // RetailAdvancesTrackerInitialInput
            // 
            RetailAdvancesTrackerInitialInput.Location = new System.Drawing.Point(667, 52);
            RetailAdvancesTrackerInitialInput.MaxLength = 16;
            RetailAdvancesTrackerInitialInput.Name = "RetailAdvancesTrackerInitialInput";
            RetailAdvancesTrackerInitialInput.Size = new System.Drawing.Size(145, 23);
            RetailAdvancesTrackerInitialInput.TabIndex = 78;
            RetailAdvancesTrackerInitialInput.Text = "0";
            RetailAdvancesTrackerInitialInput.KeyPress += DecInput_KeyPress;
            RetailAdvancesTrackerInitialInput.Leave += SetToZero_LostFocus;
            // 
            // RetailAdvancesTrackerMaxInput
            // 
            RetailAdvancesTrackerMaxInput.Location = new System.Drawing.Point(667, 78);
            RetailAdvancesTrackerMaxInput.MaxLength = 16;
            RetailAdvancesTrackerMaxInput.Name = "RetailAdvancesTrackerMaxInput";
            RetailAdvancesTrackerMaxInput.Size = new System.Drawing.Size(145, 23);
            RetailAdvancesTrackerMaxInput.TabIndex = 79;
            RetailAdvancesTrackerMaxInput.Text = "10000";
            RetailAdvancesTrackerMaxInput.KeyPress += DecInput_KeyPress;
            RetailAdvancesTrackerMaxInput.Leave += SetToZero_LostFocus;
            // 
            // RetailAdvancesTrackerGenerateButton
            // 
            RetailAdvancesTrackerGenerateButton.Location = new System.Drawing.Point(605, 111);
            RetailAdvancesTrackerGenerateButton.Name = "RetailAdvancesTrackerGenerateButton";
            RetailAdvancesTrackerGenerateButton.Size = new System.Drawing.Size(207, 20);
            RetailAdvancesTrackerGenerateButton.TabIndex = 80;
            RetailAdvancesTrackerGenerateButton.Text = "Generate Pattern";
            RetailAdvancesTrackerGenerateButton.UseVisualStyleBackColor = true;
            RetailAdvancesTrackerGenerateButton.Click += RetailAdvancesTrackerGenerateButton_Click;
            // 
            // RetailAdvancesTrackerProgressBar
            // 
            RetailAdvancesTrackerProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            RetailAdvancesTrackerProgressBar.Location = new System.Drawing.Point(606, 135);
            RetailAdvancesTrackerProgressBar.Name = "RetailAdvancesTrackerProgressBar";
            RetailAdvancesTrackerProgressBar.Size = new System.Drawing.Size(205, 10);
            RetailAdvancesTrackerProgressBar.TabIndex = 81;
            // 
            // RetailAdvancesTrackerSequenceInput
            // 
            RetailAdvancesTrackerSequenceInput.Location = new System.Drawing.Point(605, 172);
            RetailAdvancesTrackerSequenceInput.MaxLength = 30;
            RetailAdvancesTrackerSequenceInput.Name = "RetailAdvancesTrackerSequenceInput";
            RetailAdvancesTrackerSequenceInput.ReadOnly = true;
            RetailAdvancesTrackerSequenceInput.Size = new System.Drawing.Size(207, 23);
            RetailAdvancesTrackerSequenceInput.TabIndex = 82;
            RetailAdvancesTrackerSequenceInput.TextChanged += RetailAdvancesTrackerSequenceInput_TextChanged;
            RetailAdvancesTrackerSequenceInput.KeyPress += BinInput_KeyPress;
            // 
            // RetailAdvancesTrackerSequenceLabel
            // 
            RetailAdvancesTrackerSequenceLabel.AutoSize = true;
            RetailAdvancesTrackerSequenceLabel.Location = new System.Drawing.Point(602, 156);
            RetailAdvancesTrackerSequenceLabel.Name = "RetailAdvancesTrackerSequenceLabel";
            RetailAdvancesTrackerSequenceLabel.Size = new System.Drawing.Size(213, 15);
            RetailAdvancesTrackerSequenceLabel.TabIndex = 83;
            RetailAdvancesTrackerSequenceLabel.Text = "Input Sequence (0: Physical, 1: Special):";
            // 
            // RetailAdvancesTrackerResultState0
            // 
            RetailAdvancesTrackerResultState0.Location = new System.Drawing.Point(605, 241);
            RetailAdvancesTrackerResultState0.MaxLength = 16;
            RetailAdvancesTrackerResultState0.Name = "RetailAdvancesTrackerResultState0";
            RetailAdvancesTrackerResultState0.ReadOnly = true;
            RetailAdvancesTrackerResultState0.Size = new System.Drawing.Size(207, 23);
            RetailAdvancesTrackerResultState0.TabIndex = 84;
            RetailAdvancesTrackerResultState0.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(602, 268);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 15);
            label3.TabIndex = 87;
            label3.Text = "Current State[1]:";
            // 
            // RetailAdvancesTrackerResultState1
            // 
            RetailAdvancesTrackerResultState1.Location = new System.Drawing.Point(605, 284);
            RetailAdvancesTrackerResultState1.MaxLength = 16;
            RetailAdvancesTrackerResultState1.Name = "RetailAdvancesTrackerResultState1";
            RetailAdvancesTrackerResultState1.ReadOnly = true;
            RetailAdvancesTrackerResultState1.Size = new System.Drawing.Size(207, 23);
            RetailAdvancesTrackerResultState1.TabIndex = 86;
            RetailAdvancesTrackerResultState1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(602, 225);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 15);
            label2.TabIndex = 85;
            label2.Text = "Current State[0]:";
            // 
            // RetailAdvancesTrackerNumResultsLabel
            // 
            RetailAdvancesTrackerNumResultsLabel.AutoSize = true;
            RetailAdvancesTrackerNumResultsLabel.Location = new System.Drawing.Point(602, 200);
            RetailAdvancesTrackerNumResultsLabel.Name = "RetailAdvancesTrackerNumResultsLabel";
            RetailAdvancesTrackerNumResultsLabel.Size = new System.Drawing.Size(118, 15);
            RetailAdvancesTrackerNumResultsLabel.TabIndex = 88;
            RetailAdvancesTrackerNumResultsLabel.Text = "Possible Results: N/A";
            // 
            // CheckIsAbilityLocked
            // 
            CheckIsAbilityLocked.AutoSize = true;
            CheckIsAbilityLocked.Location = new System.Drawing.Point(12, 275);
            CheckIsAbilityLocked.Name = "CheckIsAbilityLocked";
            CheckIsAbilityLocked.Size = new System.Drawing.Size(101, 19);
            CheckIsAbilityLocked.TabIndex = 37;
            CheckIsAbilityLocked.Text = "Locked Ability";
            CheckIsAbilityLocked.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            MainMenu.Items.AddRange(new ToolStripItem[] { SeedFinderMenu, EncounterLookupMenu, CramomaticMenu, LotoIDMenu, WattTraderMenu, MenuCloseAdvancesViewerToolStripMenuItem });
            MainMenu.Location = new System.Drawing.Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new System.Drawing.Size(831, 24);
            MainMenu.TabIndex = 137;
            // 
            // SeedFinderMenu
            // 
            SeedFinderMenu.Name = "SeedFinderMenu";
            SeedFinderMenu.Size = new System.Drawing.Size(112, 20);
            SeedFinderMenu.Text = "Retail Seed Finder";
            SeedFinderMenu.Click += SeedFinderMenu_Click;
            // 
            // EncounterLookupMenu
            // 
            EncounterLookupMenu.Name = "EncounterLookupMenu";
            EncounterLookupMenu.Size = new System.Drawing.Size(116, 20);
            EncounterLookupMenu.Text = "Encounter Lookup";
            EncounterLookupMenu.Click += EncounterLookupMenu_Click;
            // 
            // CramomaticMenu
            // 
            CramomaticMenu.Name = "CramomaticMenu";
            CramomaticMenu.Size = new System.Drawing.Size(95, 20);
            CramomaticMenu.Text = "Cram-o-matic";
            CramomaticMenu.Click += CramomaticMenu_Click;
            // 
            // LotoIDMenu
            // 
            LotoIDMenu.Name = "LotoIDMenu";
            LotoIDMenu.Size = new System.Drawing.Size(59, 20);
            LotoIDMenu.Text = "Loto-ID";
            LotoIDMenu.Click += LotoIDMenu_Click;
            // 
            // WattTraderMenu
            // 
            WattTraderMenu.Name = "WattTraderMenu";
            WattTraderMenu.Size = new System.Drawing.Size(79, 20);
            WattTraderMenu.Text = "Watt Trader";
            WattTraderMenu.Click += WattTraderMenu_Click;
            // 
            // MenuCloseAdvancesViewerToolStripMenuItem
            // 
            MenuCloseAdvancesViewerToolStripMenuItem.Name = "MenuCloseAdvancesViewerToolStripMenuItem";
            MenuCloseAdvancesViewerToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            MenuCloseAdvancesViewerToolStripMenuItem.Text = "Menu Close Advances Viewer";
            MenuCloseAdvancesViewerToolStripMenuItem.Click += MenuCloseAdvancesViewerToolStripMenuItem_Click;
            // 
            // ButtonUpdateStates
            // 
            ButtonUpdateStates.Location = new System.Drawing.Point(604, 310);
            ButtonUpdateStates.Name = "ButtonUpdateStates";
            ButtonUpdateStates.Size = new System.Drawing.Size(209, 29);
            ButtonUpdateStates.TabIndex = 89;
            ButtonUpdateStates.Text = "Update States";
            ButtonUpdateStates.UseVisualStyleBackColor = true;
            ButtonUpdateStates.Click += ButtonUpdateStates_Click;
            // 
            // CheckTIDSIDFinder
            // 
            CheckTIDSIDFinder.AutoSize = true;
            CheckTIDSIDFinder.Location = new System.Drawing.Point(174, 135);
            CheckTIDSIDFinder.Name = "CheckTIDSIDFinder";
            CheckTIDSIDFinder.Size = new System.Drawing.Size(123, 19);
            CheckTIDSIDFinder.TabIndex = 90;
            CheckTIDSIDFinder.Text = "Search For TID/SID";
            CheckTIDSIDFinder.UseVisualStyleBackColor = true;
            CheckTIDSIDFinder.CheckedChanged += CheckTIDSIDFinder_CheckedChanged;
            // 
            // LabelKOCount
            // 
            LabelKOCount.AutoSize = true;
            LabelKOCount.Location = new System.Drawing.Point(165, 180);
            LabelKOCount.Name = "LabelKOCount";
            LabelKOCount.Size = new System.Drawing.Size(61, 15);
            LabelKOCount.TabIndex = 91;
            LabelKOCount.Text = "KO Count:";
            // 
            // InputKOCount
            // 
            InputKOCount.Location = new System.Drawing.Point(232, 177);
            InputKOCount.MaxLength = 3;
            InputKOCount.Name = "InputKOCount";
            InputKOCount.Size = new System.Drawing.Size(28, 23);
            InputKOCount.TabIndex = 90;
            InputKOCount.Text = "500";
            InputKOCount.TextAlign = HorizontalAlignment.Center;
            InputKOCount.KeyPress += DecInput_KeyPress;
            InputKOCount.Leave += SetToZero_LostFocus;
            // 
            // LabelEMs
            // 
            LabelEMs.AutoSize = true;
            LabelEMs.Location = new System.Drawing.Point(148, 232);
            LabelEMs.Name = "LabelEMs";
            LabelEMs.Size = new System.Drawing.Size(78, 15);
            LabelEMs.TabIndex = 93;
            LabelEMs.Text = "Possible EMs:";
            // 
            // InputEMs
            // 
            InputEMs.Location = new System.Drawing.Point(232, 229);
            InputEMs.MaxLength = 2;
            InputEMs.Name = "InputEMs";
            InputEMs.Size = new System.Drawing.Size(28, 23);
            InputEMs.TabIndex = 92;
            InputEMs.Text = "4";
            InputEMs.TextAlign = HorizontalAlignment.Center;
            InputEMs.KeyPress += DecInput_KeyPress;
            InputEMs.Leave += SetToZero_LostFocus;
            // 
            // LabelFlawlessIVs
            // 
            LabelFlawlessIVs.AutoSize = true;
            LabelFlawlessIVs.Location = new System.Drawing.Point(155, 206);
            LabelFlawlessIVs.Name = "LabelFlawlessIVs";
            LabelFlawlessIVs.Size = new System.Drawing.Size(71, 15);
            LabelFlawlessIVs.TabIndex = 95;
            LabelFlawlessIVs.Text = "Flawless IVs:";
            // 
            // InputFlawlessIVs
            // 
            InputFlawlessIVs.Location = new System.Drawing.Point(232, 203);
            InputFlawlessIVs.MaxLength = 1;
            InputFlawlessIVs.Name = "InputFlawlessIVs";
            InputFlawlessIVs.Size = new System.Drawing.Size(28, 23);
            InputFlawlessIVs.TabIndex = 94;
            InputFlawlessIVs.Text = "0";
            InputFlawlessIVs.TextAlign = HorizontalAlignment.Center;
            InputFlawlessIVs.TextChanged += FlawlessIVs_TextChanged;
            InputFlawlessIVs.KeyPress += DecInput_KeyPress;
            InputFlawlessIVs.Leave += SetToZero_LostFocus;
            // 
            // sensBox
            // 
            sensBox.AutoSize = true;
            sensBox.Location = new System.Drawing.Point(447, 181);
            sensBox.Name = "sensBox";
            sensBox.Size = new System.Drawing.Size(133, 19);
            sensBox.TabIndex = 96;
            sensBox.Text = "Hide Sensitive Fields";
            sensBox.UseVisualStyleBackColor = true;
            sensBox.CheckedChanged += SensBox_CheckedChanged;
            // 
            // CheckCuteCharm
            // 
            CheckCuteCharm.AutoSize = true;
            CheckCuteCharm.Location = new System.Drawing.Point(12, 321);
            CheckCuteCharm.Name = "CheckCuteCharm";
            CheckCuteCharm.Size = new System.Drawing.Size(118, 19);
            CheckCuteCharm.TabIndex = 97;
            CheckCuteCharm.Text = "Cute Charm Lead";
            CheckCuteCharm.UseVisualStyleBackColor = true;
            // 
            // hpJudgeFilter
            // 
            hpJudgeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            hpJudgeFilter.FormattingEnabled = true;
            hpJudgeFilter.Items.AddRange(new object[] { "No Good", "Decent", "Pretty Good", "Very Good", "Fantastic", "Best" });
            hpJudgeFilter.Location = new System.Drawing.Point(496, 25);
            hpJudgeFilter.Name = "hpJudgeFilter";
            hpJudgeFilter.Size = new System.Drawing.Size(82, 23);
            hpJudgeFilter.TabIndex = 104;
            hpJudgeFilter.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
            // 
            // atkJudgeFilter
            // 
            atkJudgeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            atkJudgeFilter.FormattingEnabled = true;
            atkJudgeFilter.Items.AddRange(new object[] { "No Good", "Decent", "Pretty Good", "Very Good", "Fantastic", "Best" });
            atkJudgeFilter.Location = new System.Drawing.Point(496, 51);
            atkJudgeFilter.Name = "atkJudgeFilter";
            atkJudgeFilter.Size = new System.Drawing.Size(82, 23);
            atkJudgeFilter.TabIndex = 105;
            atkJudgeFilter.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
            // 
            // defJudgeFilter
            // 
            defJudgeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            defJudgeFilter.FormattingEnabled = true;
            defJudgeFilter.Items.AddRange(new object[] { "No Good", "Decent", "Pretty Good", "Very Good", "Fantastic", "Best" });
            defJudgeFilter.Location = new System.Drawing.Point(496, 77);
            defJudgeFilter.Name = "defJudgeFilter";
            defJudgeFilter.Size = new System.Drawing.Size(82, 23);
            defJudgeFilter.TabIndex = 106;
            defJudgeFilter.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
            // 
            // spaJudgeFilter
            // 
            spaJudgeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            spaJudgeFilter.FormattingEnabled = true;
            spaJudgeFilter.Items.AddRange(new object[] { "No Good", "Decent", "Pretty Good", "Very Good", "Fantastic", "Best" });
            spaJudgeFilter.Location = new System.Drawing.Point(496, 102);
            spaJudgeFilter.Name = "spaJudgeFilter";
            spaJudgeFilter.Size = new System.Drawing.Size(82, 23);
            spaJudgeFilter.TabIndex = 107;
            spaJudgeFilter.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
            // 
            // spdJudgeFilter
            // 
            spdJudgeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            spdJudgeFilter.FormattingEnabled = true;
            spdJudgeFilter.Items.AddRange(new object[] { "No Good", "Decent", "Pretty Good", "Very Good", "Fantastic", "Best" });
            spdJudgeFilter.Location = new System.Drawing.Point(496, 127);
            spdJudgeFilter.Name = "spdJudgeFilter";
            spdJudgeFilter.Size = new System.Drawing.Size(82, 23);
            spdJudgeFilter.TabIndex = 108;
            spdJudgeFilter.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
            // 
            // speJudgeFilter
            // 
            speJudgeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            speJudgeFilter.FormattingEnabled = true;
            speJudgeFilter.Items.AddRange(new object[] { "No Good", "Decent", "Pretty Good", "Very Good", "Fantastic", "Best" });
            speJudgeFilter.Location = new System.Drawing.Point(496, 153);
            speJudgeFilter.Name = "speJudgeFilter";
            speJudgeFilter.Size = new System.Drawing.Size(82, 23);
            speJudgeFilter.TabIndex = 109;
            speJudgeFilter.SelectedIndexChanged += JudgeFilter_SelectedIndexChanged;
            // 
            // DesiredNature
            // 
            DesiredNature.AutoSize = true;
            DesiredNature.Location = new System.Drawing.Point(428, 207);
            DesiredNature.Name = "DesiredNature";
            DesiredNature.Size = new System.Drawing.Size(46, 15);
            DesiredNature.TabIndex = 110;
            DesiredNature.Text = "Nature:";
            // 
            // SelectedNature
            // 
            SelectedNature.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectedNature.FormattingEnabled = true;
            SelectedNature.Items.AddRange(new object[] { "Ignore", "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" });
            SelectedNature.Location = new System.Drawing.Point(475, 204);
            SelectedNature.Name = "SelectedNature";
            SelectedNature.Size = new System.Drawing.Size(103, 23);
            SelectedNature.TabIndex = 111;
            // 
            // LabelInitialAdv
            // 
            LabelInitialAdv.AutoSize = true;
            LabelInitialAdv.Location = new System.Drawing.Point(3, 111);
            LabelInitialAdv.Name = "LabelInitialAdv";
            LabelInitialAdv.Size = new System.Drawing.Size(57, 15);
            LabelInitialAdv.TabIndex = 113;
            LabelInitialAdv.Text = "Init. Adv.:";
            // 
            // InputInitialAdv
            // 
            InputInitialAdv.Location = new System.Drawing.Point(66, 108);
            InputInitialAdv.MaxLength = 13;
            InputInitialAdv.Name = "InputInitialAdv";
            InputInitialAdv.Size = new System.Drawing.Size(102, 23);
            InputInitialAdv.TabIndex = 112;
            InputInitialAdv.Text = "0";
            InputInitialAdv.KeyPress += DecInput_KeyPress;
            InputInitialAdv.Leave += SetToZero_LostFocus;
            // 
            // CheckShinyLocked
            // 
            CheckShinyLocked.AutoSize = true;
            CheckShinyLocked.Location = new System.Drawing.Point(12, 298);
            CheckShinyLocked.Name = "CheckShinyLocked";
            CheckShinyLocked.Size = new System.Drawing.Size(96, 19);
            CheckShinyLocked.TabIndex = 114;
            CheckShinyLocked.Text = "Shiny Locked";
            CheckShinyLocked.UseVisualStyleBackColor = true;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new System.Drawing.Point(51, 429);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new System.Drawing.Size(75, 23);
            ConnectButton.TabIndex = 115;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += Connect_ClickAsync;
            // 
            // DisconnectButton
            // 
            DisconnectButton.Enabled = false;
            DisconnectButton.Location = new System.Drawing.Point(136, 429);
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new System.Drawing.Size(75, 23);
            DisconnectButton.TabIndex = 116;
            DisconnectButton.Text = "Disconnect";
            DisconnectButton.UseVisualStyleBackColor = true;
            DisconnectButton.Click += Disconnect_Click;
            // 
            // SwitchIPInput
            // 
            SwitchIPInput.Location = new System.Drawing.Point(108, 364);
            SwitchIPInput.Name = "SwitchIPInput";
            SwitchIPInput.Size = new System.Drawing.Size(103, 23);
            SwitchIPInput.TabIndex = 117;
            SwitchIPInput.Text = "192.168.0.0";
            SwitchIPInput.TextChanged += CheckForIP;
            // 
            // SwitchIPLabel
            // 
            SwitchIPLabel.AutoSize = true;
            SwitchIPLabel.Location = new System.Drawing.Point(44, 367);
            SwitchIPLabel.Name = "SwitchIPLabel";
            SwitchIPLabel.Size = new System.Drawing.Size(58, 15);
            SwitchIPLabel.TabIndex = 118;
            SwitchIPLabel.Text = "Switch IP:";
            // 
            // CurrentAdvancesLabel
            // 
            CurrentAdvancesLabel.AutoSize = true;
            CurrentAdvancesLabel.Location = new System.Drawing.Point(39, 406);
            CurrentAdvancesLabel.Name = "CurrentAdvancesLabel";
            CurrentAdvancesLabel.Size = new System.Drawing.Size(63, 15);
            CurrentAdvancesLabel.TabIndex = 120;
            CurrentAdvancesLabel.Text = "Curr. Adv.:";
            CurrentAdvancesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InputRAMOffset
            // 
            InputRAMOffset.Location = new System.Drawing.Point(108, 338);
            InputRAMOffset.Name = "InputRAMOffset";
            InputRAMOffset.Size = new System.Drawing.Size(103, 23);
            InputRAMOffset.TabIndex = 123;
            InputRAMOffset.Text = "4C2AAC18";
            InputRAMOffset.KeyPress += HexInput_KeyPress;
            // 
            // InputRAMOffsetLabel
            // 
            InputRAMOffsetLabel.AutoSize = true;
            InputRAMOffsetLabel.Location = new System.Drawing.Point(60, 341);
            InputRAMOffsetLabel.Name = "InputRAMOffsetLabel";
            InputRAMOffsetLabel.Size = new System.Drawing.Size(42, 15);
            InputRAMOffsetLabel.TabIndex = 124;
            InputRAMOffsetLabel.Text = "Offset:";
            // 
            // ConnectionStatusLabel
            // 
            ConnectionStatusLabel.AutoSize = true;
            ConnectionStatusLabel.Location = new System.Drawing.Point(61, 387);
            ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            ConnectionStatusLabel.Size = new System.Drawing.Size(42, 15);
            ConnectionStatusLabel.TabIndex = 125;
            ConnectionStatusLabel.Text = "Status:";
            // 
            // ConnectionStatusText
            // 
            ConnectionStatusText.AutoSize = true;
            ConnectionStatusText.Location = new System.Drawing.Point(108, 387);
            ConnectionStatusText.Name = "ConnectionStatusText";
            ConnectionStatusText.Size = new System.Drawing.Size(91, 15);
            ConnectionStatusText.TabIndex = 126;
            ConnectionStatusText.Text = "Not Connected.";
            // 
            // TrackAdv
            // 
            TrackAdv.Location = new System.Drawing.Point(108, 403);
            TrackAdv.Name = "TrackAdv";
            TrackAdv.ReadOnly = true;
            TrackAdv.Size = new System.Drawing.Size(103, 23);
            TrackAdv.TabIndex = 128;
            TrackAdv.Text = "Connect Switch!";
            // 
            // TextBoxCheckEncounter
            // 
            TextBoxCheckEncounter.BackColor = System.Drawing.SystemColors.Menu;
            TextBoxCheckEncounter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TextBoxCheckEncounter.Location = new System.Drawing.Point(277, 180);
            TextBoxCheckEncounter.Multiline = true;
            TextBoxCheckEncounter.Name = "TextBoxCheckEncounter";
            TextBoxCheckEncounter.ReadOnly = true;
            TextBoxCheckEncounter.ScrollBars = ScrollBars.Horizontal;
            TextBoxCheckEncounter.Size = new System.Drawing.Size(144, 114);
            TextBoxCheckEncounter.TabIndex = 130;
            // 
            // SkipAmountInput
            // 
            SkipAmountInput.Enabled = false;
            SkipAmountInput.Location = new System.Drawing.Point(424, 350);
            SkipAmountInput.Name = "SkipAmountInput";
            SkipAmountInput.Size = new System.Drawing.Size(40, 23);
            SkipAmountInput.TabIndex = 131;
            SkipAmountInput.Text = "1";
            SkipAmountInput.TextAlign = HorizontalAlignment.Right;
            SkipAmountInput.KeyPress += DecInput_KeyPress;
            // 
            // DaySkipButton
            // 
            DaySkipButton.Enabled = false;
            DaySkipButton.Location = new System.Drawing.Point(466, 349);
            DaySkipButton.Name = "DaySkipButton";
            DaySkipButton.Size = new System.Drawing.Size(41, 25);
            DaySkipButton.TabIndex = 132;
            DaySkipButton.Text = "Days";
            DaySkipButton.UseVisualStyleBackColor = true;
            DaySkipButton.Click += DaySkip_Click;
            // 
            // ReadEncounterButton
            // 
            ReadEncounterButton.Enabled = false;
            ReadEncounterButton.Location = new System.Drawing.Point(247, 352);
            ReadEncounterButton.Name = "ReadEncounterButton";
            ReadEncounterButton.Size = new System.Drawing.Size(174, 22);
            ReadEncounterButton.TabIndex = 133;
            ReadEncounterButton.Text = "Read Encounter";
            ReadEncounterButton.UseVisualStyleBackColor = true;
            ReadEncounterButton.Click += ReadEncounter_ClickAsync;
            // 
            // SelectedAura
            // 
            SelectedAura.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectedAura.FormattingEnabled = true;
            SelectedAura.Items.AddRange(new object[] { "Ignore", "None", "Brilliant" });
            SelectedAura.Location = new System.Drawing.Point(475, 285);
            SelectedAura.Name = "SelectedAura";
            SelectedAura.Size = new System.Drawing.Size(103, 23);
            SelectedAura.TabIndex = 134;
            // 
            // LabelAura
            // 
            LabelAura.AutoSize = true;
            LabelAura.Location = new System.Drawing.Point(436, 288);
            LabelAura.Name = "LabelAura";
            LabelAura.Size = new System.Drawing.Size(35, 15);
            LabelAura.TabIndex = 135;
            LabelAura.Text = "Aura:";
            // 
            // CheckHidden
            // 
            CheckHidden.AutoSize = true;
            CheckHidden.Location = new System.Drawing.Point(12, 229);
            CheckHidden.Name = "CheckHidden";
            CheckHidden.Size = new System.Drawing.Size(65, 19);
            CheckHidden.TabIndex = 136;
            CheckHidden.Text = "Hidden";
            CheckHidden.UseVisualStyleBackColor = true;
            CheckHidden.CheckedChanged += CheckHidden_CheckedChanged;
            // 
            // ShortSkipButton
            // 
            ShortSkipButton.Enabled = false;
            ShortSkipButton.Location = new System.Drawing.Point(509, 349);
            ShortSkipButton.Name = "ShortSkipButton";
            ShortSkipButton.Size = new System.Drawing.Size(40, 25);
            ShortSkipButton.TabIndex = 138;
            ShortSkipButton.Text = "Adv.";
            ShortSkipButton.UseVisualStyleBackColor = true;
            ShortSkipButton.Click += ShortSkipButton_Click;
            // 
            // LabelSkipMenu
            // 
            LabelSkipMenu.AutoSize = true;
            LabelSkipMenu.Location = new System.Drawing.Point(427, 332);
            LabelSkipMenu.Name = "LabelSkipMenu";
            LabelSkipMenu.Size = new System.Drawing.Size(32, 15);
            LabelSkipMenu.TabIndex = 139;
            LabelSkipMenu.Text = "Skip:";
            // 
            // PokeSprite
            // 
            PokeSprite.Location = new System.Drawing.Point(305, 295);
            PokeSprite.Name = "PokeSprite";
            PokeSprite.Size = new System.Drawing.Size(74, 57);
            PokeSprite.SizeMode = PictureBoxSizeMode.CenterImage;
            PokeSprite.TabIndex = 140;
            PokeSprite.TabStop = false;
            // 
            // MarkSprite
            // 
            MarkSprite.Location = new System.Drawing.Point(378, 310);
            MarkSprite.Name = "MarkSprite";
            MarkSprite.Size = new System.Drawing.Size(48, 42);
            MarkSprite.SizeMode = PictureBoxSizeMode.CenterImage;
            MarkSprite.TabIndex = 141;
            MarkSprite.TabStop = false;
            // 
            // CheckMenuClose
            // 
            CheckMenuClose.AutoSize = true;
            CheckMenuClose.Location = new System.Drawing.Point(681, 432);
            CheckMenuClose.Name = "CheckMenuClose";
            CheckMenuClose.Size = new System.Drawing.Size(139, 19);
            CheckMenuClose.TabIndex = 174;
            CheckMenuClose.Text = "Consider Menu Close";
            CheckMenuClose.UseVisualStyleBackColor = true;
            CheckMenuClose.CheckedChanged += CheckMenuClose_CheckedChanged;
            // 
            // LabelNPCs
            // 
            LabelNPCs.AutoSize = true;
            LabelNPCs.Location = new System.Drawing.Point(596, 433);
            LabelNPCs.Name = "LabelNPCs";
            LabelNPCs.Size = new System.Drawing.Size(39, 15);
            LabelNPCs.TabIndex = 175;
            LabelNPCs.Text = "NPCs:";
            // 
            // InputNPCs
            // 
            InputNPCs.Enabled = false;
            InputNPCs.Location = new System.Drawing.Point(641, 430);
            InputNPCs.MaxLength = 2;
            InputNPCs.Name = "InputNPCs";
            InputNPCs.Size = new System.Drawing.Size(34, 23);
            InputNPCs.TabIndex = 173;
            InputNPCs.Text = "5";
            InputNPCs.KeyPress += DecInput_KeyPress;
            // 
            // CheckFocusWindow
            // 
            CheckFocusWindow.AutoSize = true;
            CheckFocusWindow.Location = new System.Drawing.Point(596, 380);
            CheckFocusWindow.Name = "CheckFocusWindow";
            CheckFocusWindow.Size = new System.Drawing.Size(104, 19);
            CheckFocusWindow.TabIndex = 176;
            CheckFocusWindow.Text = "Focus Window";
            CheckFocusWindow.UseVisualStyleBackColor = true;
            CheckFocusWindow.CheckedChanged += CheckFocusWindow_CheckChanged;
            // 
            // CheckPlayTone
            // 
            CheckPlayTone.AutoSize = true;
            CheckPlayTone.Location = new System.Drawing.Point(596, 403);
            CheckPlayTone.Name = "CheckPlayTone";
            CheckPlayTone.Size = new System.Drawing.Size(76, 19);
            CheckPlayTone.TabIndex = 177;
            CheckPlayTone.Text = "Play Tone";
            CheckPlayTone.UseVisualStyleBackColor = true;
            CheckPlayTone.CheckedChanged += CheckPlayTone_CheckedChanged;
            // 
            // Check3Seg
            // 
            Check3Seg.AutoSize = true;
            Check3Seg.Location = new System.Drawing.Point(145, 311);
            Check3Seg.Name = "Check3Seg";
            Check3Seg.Size = new System.Drawing.Size(115, 19);
            Check3Seg.TabIndex = 178;
            Check3Seg.Text = "3 Segment Only?";
            Check3Seg.UseVisualStyleBackColor = true;
            // 
            // LabelHeight
            // 
            LabelHeight.AutoSize = true;
            LabelHeight.Location = new System.Drawing.Point(427, 314);
            LabelHeight.Name = "LabelHeight";
            LabelHeight.Size = new System.Drawing.Size(46, 15);
            LabelHeight.TabIndex = 179;
            LabelHeight.Text = "Height:";
            // 
            // SelectedHeight
            // 
            SelectedHeight.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectedHeight.FormattingEnabled = true;
            SelectedHeight.Items.AddRange(new object[] { "Ignore", "XXXS or XXXL", "XXXS (0)", "XXS (1 - 24)", "XS (25 - 59)", "S (66 - 99)", "M (100 - 155)", "L (156 - 195)", "XL (196 - 230)", "XXL (231 - 245)", "XXXL (255)" });
            SelectedHeight.Location = new System.Drawing.Point(475, 312);
            SelectedHeight.Name = "SelectedHeight";
            SelectedHeight.Size = new System.Drawing.Size(103, 23);
            SelectedHeight.TabIndex = 180;
            // 
            // CheckUseFilters
            // 
            CheckUseFilters.AutoSize = true;
            CheckUseFilters.Checked = true;
            CheckUseFilters.CheckState = CheckState.Checked;
            CheckUseFilters.Location = new System.Drawing.Point(596, 358);
            CheckUseFilters.Name = "CheckUseFilters";
            CheckUseFilters.Size = new System.Drawing.Size(95, 19);
            CheckUseFilters.TabIndex = 181;
            CheckUseFilters.Text = "Enable Filters";
            CheckUseFilters.UseVisualStyleBackColor = true;
            // 
            // NTPButton
            // 
            NTPButton.Enabled = false;
            NTPButton.Location = new System.Drawing.Point(551, 349);
            NTPButton.Name = "NTPButton";
            NTPButton.Size = new System.Drawing.Size(37, 25);
            NTPButton.TabIndex = 182;
            NTPButton.Text = "NTP";
            NTPButton.UseVisualStyleBackColor = true;
            NTPButton.Click += NTPButton_Click;
            // 
            // MainWindow
            // 
            ClientSize = new System.Drawing.Size(831, 699);
            Controls.Add(NTPButton);
            Controls.Add(CheckUseFilters);
            Controls.Add(SelectedHeight);
            Controls.Add(Check3Seg);
            Controls.Add(CheckPlayTone);
            Controls.Add(CheckFocusWindow);
            Controls.Add(CheckMenuClose);
            Controls.Add(LabelNPCs);
            Controls.Add(InputNPCs);
            Controls.Add(LabelSkipMenu);
            Controls.Add(ShortSkipButton);
            Controls.Add(CheckHidden);
            Controls.Add(SelectedAura);
            Controls.Add(LabelAura);
            Controls.Add(ReadEncounterButton);
            Controls.Add(DaySkipButton);
            Controls.Add(SkipAmountInput);
            Controls.Add(TextBoxCheckEncounter);
            Controls.Add(TrackAdv);
            Controls.Add(ConnectionStatusText);
            Controls.Add(ConnectionStatusLabel);
            Controls.Add(InputRAMOffsetLabel);
            Controls.Add(InputRAMOffset);
            Controls.Add(CurrentAdvancesLabel);
            Controls.Add(SwitchIPLabel);
            Controls.Add(SwitchIPInput);
            Controls.Add(DisconnectButton);
            Controls.Add(ConnectButton);
            Controls.Add(CheckShinyLocked);
            Controls.Add(LabelInitialAdv);
            Controls.Add(InputInitialAdv);
            Controls.Add(SelectedNature);
            Controls.Add(DesiredNature);
            Controls.Add(speJudgeFilter);
            Controls.Add(spdJudgeFilter);
            Controls.Add(spaJudgeFilter);
            Controls.Add(defJudgeFilter);
            Controls.Add(atkJudgeFilter);
            Controls.Add(hpJudgeFilter);
            Controls.Add(CheckCuteCharm);
            Controls.Add(sensBox);
            Controls.Add(CheckTIDSIDFinder);
            Controls.Add(LabelFlawlessIVs);
            Controls.Add(InputFlawlessIVs);
            Controls.Add(LabelEMs);
            Controls.Add(InputEMs);
            Controls.Add(LabelKOCount);
            Controls.Add(InputKOCount);
            Controls.Add(ButtonUpdateStates);
            Controls.Add(CheckIsAbilityLocked);
            Controls.Add(RetailAdvancesTrackerNumResultsLabel);
            Controls.Add(label3);
            Controls.Add(RetailAdvancesTrackerResultState1);
            Controls.Add(label2);
            Controls.Add(RetailAdvancesTrackerResultState0);
            Controls.Add(RetailAdvancesTrackerSequenceLabel);
            Controls.Add(RetailAdvancesTrackerSequenceInput);
            Controls.Add(RetailAdvancesTrackerProgressBar);
            Controls.Add(RetailAdvancesTrackerGenerateButton);
            Controls.Add(RetailAdvancesTrackerMaxInput);
            Controls.Add(RetailAdvancesTrackerInitialInput);
            Controls.Add(RetailAdvancesTrackerMaxAdvInputLabel);
            Controls.Add(RetailAdvancesTrackerInitialInputLabel);
            Controls.Add(RetailAdvancesTrackerLabel);
            Controls.Add(progressBar1);
            Controls.Add(Results);
            Controls.Add(SelectedShiny);
            Controls.Add(LabelShiny);
            Controls.Add(ButtonSearch);
            Controls.Add(LabelSlot);
            Controls.Add(LabelLevel);
            Controls.Add(label21);
            Controls.Add(InputSlotMax);
            Controls.Add(InputSlotMin);
            Controls.Add(label20);
            Controls.Add(InputLevelMax);
            Controls.Add(InputLevelMin);
            Controls.Add(CheckHeldItem);
            Controls.Add(CheckFishing);
            Controls.Add(CheckStatic);
            Controls.Add(CheckWeather);
            Controls.Add(CheckMarkCharm);
            Controls.Add(CheckShinyCharm);
            Controls.Add(SelectedMark);
            Controls.Add(LabelMark);
            Controls.Add(LabelMaxAdv);
            Controls.Add(InputMaxAdv);
            Controls.Add(LabelIDsSlash);
            Controls.Add(LabelTIDSID);
            Controls.Add(InputSID);
            Controls.Add(InputTID);
            Controls.Add(speMaxFilter);
            Controls.Add(speMinFilter);
            Controls.Add(spdMaxFilter);
            Controls.Add(spdMinFilter);
            Controls.Add(spaMaxFilter);
            Controls.Add(spaMinFilter);
            Controls.Add(defMaxFilter);
            Controls.Add(defMinFilter);
            Controls.Add(atkMaxFilter);
            Controls.Add(atkMinFilter);
            Controls.Add(hpMaxFilter);
            Controls.Add(hpMinFilter);
            Controls.Add(label15);
            Controls.Add(speMax);
            Controls.Add(label14);
            Controls.Add(spdMax);
            Controls.Add(label13);
            Controls.Add(spaMax);
            Controls.Add(label12);
            Controls.Add(defMax);
            Controls.Add(label11);
            Controls.Add(atkMax);
            Controls.Add(label10);
            Controls.Add(speFilter);
            Controls.Add(spdFilter);
            Controls.Add(spaFilter);
            Controls.Add(defFilter);
            Controls.Add(atkFilter);
            Controls.Add(hpFilter);
            Controls.Add(speMin);
            Controls.Add(spdMin);
            Controls.Add(spaMin);
            Controls.Add(defMin);
            Controls.Add(atkMin);
            Controls.Add(hpMax);
            Controls.Add(hpMin);
            Controls.Add(LabelState1);
            Controls.Add(InputState1);
            Controls.Add(InputState0);
            Controls.Add(LabelState0);
            Controls.Add(ImageRareMark);
            Controls.Add(MainMenu);
            Controls.Add(PokeSprite);
            Controls.Add(MarkSprite);
            Controls.Add(LabelHeight);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImageRareMark).EndInit();
            ((System.ComponentModel.ISupportInitialize)Results).EndInit();
            ((System.ComponentModel.ISupportInitialize)generatorBindingSource).EndInit();
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PokeSprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarkSprite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelState0;
        private Label LabelState1;
        private TextBox hpMin;
        private TextBox hpMax;
        private Label hpFilter;
        private Label atkFilter;
        private Label defFilter;
        private Label spaFilter;
        private Label spdFilter;
        private Label speFilter;
        private Label label10;
        private Button hpMinFilter;
        private Button hpMaxFilter;
        private Label LabelTIDSID;
        private Label LabelIDsSlash;
        private TextBox InputMaxAdv;
        private Label LabelMaxAdv;
        private Label LabelMark;
        private PictureBox ImageRareMark;
        private ComboBox SelectedMark;
        private CheckBox CheckShinyCharm;
        private CheckBox CheckMarkCharm;
        private Label label20;
        private Label label21;
        private Label LabelLevel;
        private Label LabelSlot;
        private Button ButtonSearch;
        private ComboBox SelectedShiny;
        private Label LabelShiny;
        private DataGridView Results;
        private Label label12;
        private Button speMinFilter;
        private TextBox defMax;
        private Label label13;
        private Label label15;
        private Button spdMinFilter;
        private Button spdMaxFilter;
        private Label label11;
        private Button speMaxFilter;
        private TextBox spaMin;
        private Button atkMinFilter;
        private TextBox spdMin;
        private TextBox spdMax;
        private TextBox speMin;
        private TextBox speMax;
        private TextBox atkMax;
        private Button atkMaxFilter;
        private TextBox defMin;
        private Button defMinFilter;
        private Button spaMinFilter;
        private Button defMaxFilter;
        private TextBox spaMax;
        private Label label14;
        private TextBox atkMin;
        private Button spaMaxFilter;
        private BindingSource generatorBindingSource;
        private ProgressBar progressBar1;
        private Label RetailAdvancesTrackerLabel;
        private Label RetailAdvancesTrackerInitialInputLabel;
        private Label RetailAdvancesTrackerMaxAdvInputLabel;
        private TextBox RetailAdvancesTrackerInitialInput;
        private TextBox RetailAdvancesTrackerMaxInput;
        private Button RetailAdvancesTrackerGenerateButton;
        private ProgressBar RetailAdvancesTrackerProgressBar;
        private TextBox RetailAdvancesTrackerSequenceInput;
        private Label RetailAdvancesTrackerSequenceLabel;
        private TextBox RetailAdvancesTrackerResultState0;
        private Label label3;
        private TextBox RetailAdvancesTrackerResultState1;
        private Label label2;
        private Label RetailAdvancesTrackerNumResultsLabel;
        private MenuStrip MainMenu;
        private ToolStripMenuItem SeedFinderMenu;
        private Button ButtonUpdateStates;
        private Label LabelKOCount;
        private TextBox InputKOCount;
        private CheckBox CheckTIDSIDFinder;
        private Label LabelEMs;
        private Label LabelFlawlessIVs;
        private CheckBox sensBox;
        private CheckBox CheckCuteCharm;
        private ComboBox hpJudgeFilter;
        private ComboBox atkJudgeFilter;
        private ComboBox defJudgeFilter;
        private ComboBox spaJudgeFilter;
        private ComboBox spdJudgeFilter;
        private ComboBox speJudgeFilter;
        private Label DesiredNature;
        private ComboBox SelectedNature;
        private Label LabelInitialAdv;
        private TextBox InputInitialAdv;
        private Button ConnectButton;
        private Button DisconnectButton;
        private TextBox SwitchIPInput;
        private Label SwitchIPLabel;
        private Label CurrentAdvancesLabel;
        private TextBox InputRAMOffset;
        private Label InputRAMOffsetLabel;
        private Label ConnectionStatusLabel;
        private Label ConnectionStatusText;
        private TextBox TrackAdv;
        private TextBox TextBoxCheckEncounter;
        private TextBox SkipAmountInput;
        private Button DaySkipButton;
        private Button ReadEncounterButton;
        private ComboBox SelectedAura;
        private Label LabelAura;
        private ToolStripMenuItem EncounterLookupMenu;
        public CheckBox CheckHeldItem;
        public TextBox InputEMs;
        public CheckBox CheckIsAbilityLocked;
        public TextBox InputFlawlessIVs;
        public TextBox InputSlotMin;
        public TextBox InputSlotMax;
        public TextBox InputLevelMin;
        public TextBox InputLevelMax;
        public CheckBox CheckStatic;
        public CheckBox CheckWeather;
        public CheckBox CheckFishing;
        public CheckBox CheckHidden;
        private ToolStripMenuItem CramomaticMenu;
        public TextBox InputState0;
        public TextBox InputState1;
        private ToolStripMenuItem LotoIDMenu;
        public TextBox InputTID;
        public TextBox InputSID;
        public Button ShortSkipButton;
        private Label LabelSkipMenu;
        private ToolStripMenuItem MenuCloseAdvancesViewerToolStripMenuItem;
        public CheckBox CheckShinyLocked;
        private PictureBox PokeSprite;
        private PictureBox MarkSprite;
        private CheckBox CheckMenuClose;
        private Label LabelNPCs;
        private TextBox InputNPCs;
        public CheckBox CheckFocusWindow;
        public CheckBox CheckPlayTone;
        private CheckBox Check3Seg;
        private DataGridViewTextBoxColumn Frame;
        private DataGridViewTextBoxColumn TID;
        private DataGridViewTextBoxColumn SID;
        private DataGridViewTextBoxColumn Animation;
        private DataGridViewTextBoxColumn Jump;
        private DataGridViewTextBoxColumn Steps;
        private DataGridViewTextBoxColumn Brilliant;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn Slot;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn EC;
        private DataGridViewTextBoxColumn Shiny;
        private DataGridViewTextBoxColumn Ability;
        private DataGridViewTextBoxColumn Nature;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn HP;
        private DataGridViewTextBoxColumn Atk;
        private DataGridViewTextBoxColumn Def;
        private DataGridViewTextBoxColumn SpA;
        private DataGridViewTextBoxColumn SpD;
        private DataGridViewTextBoxColumn Spe;
        private new DataGridViewTextBoxColumn Height;
        private DataGridViewTextBoxColumn Mark;
        private DataGridViewTextBoxColumn State0;
        private DataGridViewTextBoxColumn State1;
        private Label LabelHeight;
        private ComboBox SelectedHeight;
        public CheckBox CheckUseFilters;
        public Button button1;
        public Button NTPButton;
        private ToolStripMenuItem WattTraderMenu;
    }
}
