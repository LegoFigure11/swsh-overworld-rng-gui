
namespace SWSH_OWRNG_Generator_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.LabelTID = new System.Windows.Forms.Label();
            this.LabelSID = new System.Windows.Forms.Label();
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
            this.CheckExtraRoll = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.LevelMax = new System.Windows.Forms.TextBox();
            this.LevelMin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SlotMax = new System.Windows.Forms.TextBox();
            this.SlotMin = new System.Windows.Forms.TextBox();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.LabelSlot = new System.Windows.Forms.Label();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.SelectedShiny = new System.Windows.Forms.ComboBox();
            this.LabelShiny = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Def = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.ImageRareMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelState0
            // 
            this.LabelState0.AutoSize = true;
            this.LabelState0.Location = new System.Drawing.Point(15, 9);
            this.LabelState0.Name = "LabelState0";
            this.LabelState0.Size = new System.Drawing.Size(50, 13);
            this.LabelState0.TabIndex = 0;
            this.LabelState0.Text = "State[0]: ";
            // 
            // InputState0
            // 
            this.InputState0.Location = new System.Drawing.Point(68, 6);
            this.InputState0.MaxLength = 16;
            this.InputState0.Name = "InputState0";
            this.InputState0.Size = new System.Drawing.Size(205, 20);
            this.InputState0.TabIndex = 1;
            this.InputState0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputStatePaste_KeyDown);
            this.InputState0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // InputState1
            // 
            this.InputState1.Location = new System.Drawing.Point(68, 32);
            this.InputState1.MaxLength = 16;
            this.InputState1.Name = "InputState1";
            this.InputState1.Size = new System.Drawing.Size(205, 20);
            this.InputState1.TabIndex = 2;
            this.InputState1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputStatePaste_KeyDown);
            this.InputState1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInput_KeyPress);
            // 
            // LabelState1
            // 
            this.LabelState1.AutoSize = true;
            this.LabelState1.Location = new System.Drawing.Point(15, 35);
            this.LabelState1.Name = "LabelState1";
            this.LabelState1.Size = new System.Drawing.Size(47, 13);
            this.LabelState1.TabIndex = 3;
            this.LabelState1.Text = "State[1]:";
            // 
            // hpMin
            // 
            this.hpMin.Location = new System.Drawing.Point(353, 6);
            this.hpMin.Name = "hpMin";
            this.hpMin.Size = new System.Drawing.Size(28, 20);
            this.hpMin.TabIndex = 4;
            this.hpMin.Text = "0";
            this.hpMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hpMin.LostFocus += new System.EventHandler(this.Filter_LostFocus);
            // 
            // hpMax
            // 
            this.hpMax.Location = new System.Drawing.Point(403, 6);
            this.hpMax.Name = "hpMax";
            this.hpMax.Size = new System.Drawing.Size(28, 20);
            this.hpMax.TabIndex = 5;
            this.hpMax.Text = "31";
            this.hpMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hpMax.LostFocus += new System.EventHandler(this.Filter_LostFocus);
            // 
            // hpFilter
            // 
            this.hpFilter.AutoSize = true;
            this.hpFilter.Location = new System.Drawing.Point(322, 9);
            this.hpFilter.Name = "hpFilter";
            this.hpFilter.Size = new System.Drawing.Size(25, 13);
            this.hpFilter.TabIndex = 16;
            this.hpFilter.Text = "HP:";
            this.hpFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // atkFilter
            // 
            this.atkFilter.AutoSize = true;
            this.atkFilter.Location = new System.Drawing.Point(321, 35);
            this.atkFilter.Name = "atkFilter";
            this.atkFilter.Size = new System.Drawing.Size(26, 13);
            this.atkFilter.TabIndex = 17;
            this.atkFilter.Text = "Atk:";
            this.atkFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // defFilter
            // 
            this.defFilter.AutoSize = true;
            this.defFilter.Location = new System.Drawing.Point(320, 61);
            this.defFilter.Name = "defFilter";
            this.defFilter.Size = new System.Drawing.Size(27, 13);
            this.defFilter.TabIndex = 18;
            this.defFilter.Text = "Def:";
            this.defFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // spaFilter
            // 
            this.spaFilter.AutoSize = true;
            this.spaFilter.Location = new System.Drawing.Point(317, 87);
            this.spaFilter.Name = "spaFilter";
            this.spaFilter.Size = new System.Drawing.Size(30, 13);
            this.spaFilter.TabIndex = 19;
            this.spaFilter.Text = "SpA:";
            this.spaFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // spdFilter
            // 
            this.spdFilter.AutoSize = true;
            this.spdFilter.Location = new System.Drawing.Point(316, 113);
            this.spdFilter.Name = "spdFilter";
            this.spdFilter.Size = new System.Drawing.Size(31, 13);
            this.spdFilter.TabIndex = 20;
            this.spdFilter.Text = "SpD:";
            this.spdFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // speFilter
            // 
            this.speFilter.AutoSize = true;
            this.speFilter.Location = new System.Drawing.Point(316, 139);
            this.speFilter.Name = "speFilter";
            this.speFilter.Size = new System.Drawing.Size(29, 13);
            this.speFilter.TabIndex = 21;
            this.speFilter.Text = "Spe:";
            this.speFilter.Click += new System.EventHandler(this.ResetFilters);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "-";
            // 
            // hpMinFilter
            // 
            this.hpMinFilter.Location = new System.Drawing.Point(437, 5);
            this.hpMinFilter.Name = "hpMinFilter";
            this.hpMinFilter.Size = new System.Drawing.Size(29, 20);
            this.hpMinFilter.TabIndex = 33;
            this.hpMinFilter.Text = "0";
            this.hpMinFilter.UseVisualStyleBackColor = true;
            this.hpMinFilter.Click += new System.EventHandler(this.HpMinFilter_Click);
            // 
            // hpMaxFilter
            // 
            this.hpMaxFilter.Location = new System.Drawing.Point(471, 5);
            this.hpMaxFilter.Name = "hpMaxFilter";
            this.hpMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.hpMaxFilter.TabIndex = 34;
            this.hpMaxFilter.Text = "31";
            this.hpMaxFilter.UseVisualStyleBackColor = true;
            this.hpMaxFilter.Click += new System.EventHandler(this.HpMaxFilter_Click);
            // 
            // InputTID
            // 
            this.InputTID.Location = new System.Drawing.Point(68, 84);
            this.InputTID.MaxLength = 5;
            this.InputTID.Name = "InputTID";
            this.InputTID.Size = new System.Drawing.Size(102, 20);
            this.InputTID.TabIndex = 45;
            this.InputTID.Text = "1390";
            this.InputTID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputTID.TextChanged += new System.EventHandler(this.TIDSID_TextChanged);
            // 
            // InputSID
            // 
            this.InputSID.Location = new System.Drawing.Point(68, 110);
            this.InputSID.MaxLength = 5;
            this.InputSID.Name = "InputSID";
            this.InputSID.Size = new System.Drawing.Size(102, 20);
            this.InputSID.TabIndex = 46;
            this.InputSID.Text = "42069";
            this.InputSID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.InputSID.TextChanged += new System.EventHandler(this.TIDSID_TextChanged);
            // 
            // LabelTID
            // 
            this.LabelTID.AutoSize = true;
            this.LabelTID.Location = new System.Drawing.Point(34, 87);
            this.LabelTID.Name = "LabelTID";
            this.LabelTID.Size = new System.Drawing.Size(28, 13);
            this.LabelTID.TabIndex = 47;
            this.LabelTID.Text = "TID:";
            // 
            // LabelSID
            // 
            this.LabelSID.AutoSize = true;
            this.LabelSID.Location = new System.Drawing.Point(34, 113);
            this.LabelSID.Name = "LabelSID";
            this.LabelSID.Size = new System.Drawing.Size(28, 13);
            this.LabelSID.TabIndex = 48;
            this.LabelSID.Text = "SID:";
            // 
            // InputMaxAdv
            // 
            this.InputMaxAdv.Location = new System.Drawing.Point(68, 136);
            this.InputMaxAdv.MaxLength = 13;
            this.InputMaxAdv.Name = "InputMaxAdv";
            this.InputMaxAdv.Size = new System.Drawing.Size(102, 20);
            this.InputMaxAdv.TabIndex = 49;
            this.InputMaxAdv.Text = "50000000";
            // 
            // LabelMaxAdv
            // 
            this.LabelMaxAdv.AutoSize = true;
            this.LabelMaxAdv.Location = new System.Drawing.Point(7, 140);
            this.LabelMaxAdv.Name = "LabelMaxAdv";
            this.LabelMaxAdv.Size = new System.Drawing.Size(55, 13);
            this.LabelMaxAdv.TabIndex = 50;
            this.LabelMaxAdv.Text = "Max Adv.:";
            // 
            // LabelMark
            // 
            this.LabelMark.AutoSize = true;
            this.LabelMark.Location = new System.Drawing.Point(313, 165);
            this.LabelMark.Name = "LabelMark";
            this.LabelMark.Size = new System.Drawing.Size(34, 13);
            this.LabelMark.TabIndex = 52;
            this.LabelMark.Text = "Mark:";
            // 
            // ImageRareMark
            // 
            this.ImageRareMark.Image = global::SWSH_OWRNG_Generator_GUI.Properties.Resources.raremark;
            this.ImageRareMark.Location = new System.Drawing.Point(182, 58);
            this.ImageRareMark.Name = "ImageRareMark";
            this.ImageRareMark.Size = new System.Drawing.Size(128, 128);
            this.ImageRareMark.TabIndex = 53;
            this.ImageRareMark.TabStop = false;
            // 
            // SelectedMark
            // 
            this.SelectedMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedMark.FormattingEnabled = true;
            this.SelectedMark.Items.AddRange(new object[] {
            "Any",
            "None",
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
            this.SelectedMark.Location = new System.Drawing.Point(353, 162);
            this.SelectedMark.Name = "SelectedMark";
            this.SelectedMark.Size = new System.Drawing.Size(147, 21);
            this.SelectedMark.TabIndex = 54;
            this.SelectedMark.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CheckShinyCharm
            // 
            this.CheckShinyCharm.AutoSize = true;
            this.CheckShinyCharm.Location = new System.Drawing.Point(12, 162);
            this.CheckShinyCharm.Name = "CheckShinyCharm";
            this.CheckShinyCharm.Size = new System.Drawing.Size(85, 17);
            this.CheckShinyCharm.TabIndex = 55;
            this.CheckShinyCharm.Text = "Shiny Charm";
            this.CheckShinyCharm.UseVisualStyleBackColor = true;
            // 
            // CheckMarkCharm
            // 
            this.CheckMarkCharm.AutoSize = true;
            this.CheckMarkCharm.Location = new System.Drawing.Point(12, 185);
            this.CheckMarkCharm.Name = "CheckMarkCharm";
            this.CheckMarkCharm.Size = new System.Drawing.Size(83, 17);
            this.CheckMarkCharm.TabIndex = 56;
            this.CheckMarkCharm.Text = "Mark Charm";
            this.CheckMarkCharm.UseVisualStyleBackColor = true;
            // 
            // CheckWeather
            // 
            this.CheckWeather.AutoSize = true;
            this.CheckWeather.Location = new System.Drawing.Point(12, 208);
            this.CheckWeather.Name = "CheckWeather";
            this.CheckWeather.Size = new System.Drawing.Size(67, 17);
            this.CheckWeather.TabIndex = 57;
            this.CheckWeather.Text = "Weather";
            this.CheckWeather.UseVisualStyleBackColor = true;
            // 
            // CheckStatic
            // 
            this.CheckStatic.AutoSize = true;
            this.CheckStatic.Location = new System.Drawing.Point(98, 162);
            this.CheckStatic.Name = "CheckStatic";
            this.CheckStatic.Size = new System.Drawing.Size(53, 17);
            this.CheckStatic.TabIndex = 58;
            this.CheckStatic.Text = "Static";
            this.CheckStatic.UseVisualStyleBackColor = true;
            this.CheckStatic.CheckedChanged += new System.EventHandler(this.CheckStatic_CheckedChanged);
            // 
            // CheckFishing
            // 
            this.CheckFishing.AutoSize = true;
            this.CheckFishing.Location = new System.Drawing.Point(98, 185);
            this.CheckFishing.Name = "CheckFishing";
            this.CheckFishing.Size = new System.Drawing.Size(59, 17);
            this.CheckFishing.TabIndex = 59;
            this.CheckFishing.Text = "Fishing";
            this.CheckFishing.UseVisualStyleBackColor = true;
            // 
            // CheckHeldItem
            // 
            this.CheckHeldItem.AutoSize = true;
            this.CheckHeldItem.Location = new System.Drawing.Point(98, 208);
            this.CheckHeldItem.Name = "CheckHeldItem";
            this.CheckHeldItem.Size = new System.Drawing.Size(111, 17);
            this.CheckHeldItem.TabIndex = 60;
            this.CheckHeldItem.Text = "Random held item";
            this.CheckHeldItem.UseVisualStyleBackColor = true;
            // 
            // CheckExtraRoll
            // 
            this.CheckExtraRoll.AutoSize = true;
            this.CheckExtraRoll.Location = new System.Drawing.Point(12, 231);
            this.CheckExtraRoll.Name = "CheckExtraRoll";
            this.CheckExtraRoll.Size = new System.Drawing.Size(147, 17);
            this.CheckExtraRoll.TabIndex = 61;
            this.CheckExtraRoll.Text = "Unknown Extra Mark Roll";
            this.CheckExtraRoll.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(244, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "-";
            // 
            // LevelMax
            // 
            this.LevelMax.Location = new System.Drawing.Point(260, 229);
            this.LevelMax.MaxLength = 2;
            this.LevelMax.Name = "LevelMax";
            this.LevelMax.Size = new System.Drawing.Size(28, 20);
            this.LevelMax.TabIndex = 63;
            this.LevelMax.Text = "0";
            this.LevelMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LevelMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.LevelMax.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            // 
            // LevelMin
            // 
            this.LevelMin.Location = new System.Drawing.Point(210, 229);
            this.LevelMin.MaxLength = 2;
            this.LevelMin.Name = "LevelMin";
            this.LevelMin.Size = new System.Drawing.Size(28, 20);
            this.LevelMin.TabIndex = 62;
            this.LevelMin.Text = "0";
            this.LevelMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LevelMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.LevelMin.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(422, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 13);
            this.label21.TabIndex = 67;
            this.label21.Text = "-";
            // 
            // SlotMax
            // 
            this.SlotMax.Location = new System.Drawing.Point(438, 229);
            this.SlotMax.MaxLength = 2;
            this.SlotMax.Name = "SlotMax";
            this.SlotMax.Size = new System.Drawing.Size(28, 20);
            this.SlotMax.TabIndex = 66;
            this.SlotMax.Text = "99";
            this.SlotMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SlotMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.SlotMax.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            // 
            // SlotMin
            // 
            this.SlotMin.Location = new System.Drawing.Point(388, 229);
            this.SlotMin.MaxLength = 2;
            this.SlotMin.Name = "SlotMin";
            this.SlotMin.Size = new System.Drawing.Size(28, 20);
            this.SlotMin.TabIndex = 65;
            this.SlotMin.Text = "0";
            this.SlotMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SlotMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInput_KeyPress);
            this.SlotMin.TextChanged += new System.EventHandler(this.LevelSlot_TextChanged);
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Location = new System.Drawing.Point(168, 232);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(36, 13);
            this.LabelLevel.TabIndex = 68;
            this.LabelLevel.Text = "Level:";
            // 
            // LabelSlot
            // 
            this.LabelSlot.AutoSize = true;
            this.LabelSlot.Location = new System.Drawing.Point(354, 232);
            this.LabelSlot.Name = "LabelSlot";
            this.LabelSlot.Size = new System.Drawing.Size(28, 13);
            this.LabelSlot.TabIndex = 69;
            this.LabelSlot.Text = "Slot:";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(12, 273);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(488, 37);
            this.ButtonSearch.TabIndex = 70;
            this.ButtonSearch.Text = "Search!";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // SelectedShiny
            // 
            this.SelectedShiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedShiny.FormattingEnabled = true;
            this.SelectedShiny.Items.AddRange(new object[] {
            "Any",
            "No",
            "Square",
            "Star",
            "Star/Square"});
            this.SelectedShiny.Location = new System.Drawing.Point(353, 189);
            this.SelectedShiny.Name = "SelectedShiny";
            this.SelectedShiny.Size = new System.Drawing.Size(147, 21);
            this.SelectedShiny.TabIndex = 72;
            // 
            // LabelShiny
            // 
            this.LabelShiny.AutoSize = true;
            this.LabelShiny.Location = new System.Drawing.Point(309, 192);
            this.LabelShiny.Name = "LabelShiny";
            this.LabelShiny.Size = new System.Drawing.Size(36, 13);
            this.LabelShiny.TabIndex = 71;
            this.LabelShiny.Text = "Shiny:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Frame,
            this.Level,
            this.Slot,
            this.PID,
            this.EC,
            this.Shiny,
            this.HP,
            this.Atk,
            this.Def,
            this.SpA,
            this.SpD,
            this.Spe,
            this.Mark});
            this.dataGridView1.Location = new System.Drawing.Point(12, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(486, 119);
            this.dataGridView1.TabIndex = 73;
            // 
            // Frame
            // 
            this.Frame.HeaderText = "Frame";
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 58;
            // 
            // Slot
            // 
            this.Slot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Slot.HeaderText = "Slot";
            this.Slot.Name = "Slot";
            this.Slot.ReadOnly = true;
            this.Slot.Width = 50;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 50;
            // 
            // EC
            // 
            this.EC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EC.HeaderText = "EC";
            this.EC.Name = "EC";
            this.EC.ReadOnly = true;
            this.EC.Width = 46;
            // 
            // Shiny
            // 
            this.Shiny.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Shiny.HeaderText = "Shiny";
            this.Shiny.Name = "Shiny";
            this.Shiny.ReadOnly = true;
            this.Shiny.Width = 58;
            // 
            // HP
            // 
            this.HP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HP.HeaderText = "HP";
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            this.HP.Width = 47;
            // 
            // Atk
            // 
            this.Atk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Atk.HeaderText = "Atk";
            this.Atk.Name = "Atk";
            this.Atk.ReadOnly = true;
            this.Atk.Width = 48;
            // 
            // Def
            // 
            this.Def.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Def.HeaderText = "Def";
            this.Def.Name = "Def";
            this.Def.ReadOnly = true;
            this.Def.Width = 49;
            // 
            // SpA
            // 
            this.SpA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SpA.HeaderText = "SpA";
            this.SpA.Name = "SpA";
            this.SpA.ReadOnly = true;
            this.SpA.Width = 52;
            // 
            // SpD
            // 
            this.SpD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SpD.HeaderText = "SpD";
            this.SpD.Name = "SpD";
            this.SpD.ReadOnly = true;
            this.SpD.Width = 53;
            // 
            // Spe
            // 
            this.Spe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Spe.HeaderText = "Spe";
            this.Spe.Name = "Spe";
            this.Spe.ReadOnly = true;
            this.Spe.Width = 51;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "-";
            // 
            // speMinFilter
            // 
            this.speMinFilter.Location = new System.Drawing.Point(436, 136);
            this.speMinFilter.Name = "speMinFilter";
            this.speMinFilter.Size = new System.Drawing.Size(29, 20);
            this.speMinFilter.TabIndex = 43;
            this.speMinFilter.Text = "0";
            this.speMinFilter.UseVisualStyleBackColor = true;
            this.speMinFilter.Click += new System.EventHandler(this.SpeMinFilter_Click);
            // 
            // defMax
            // 
            this.defMax.Location = new System.Drawing.Point(403, 58);
            this.defMax.Name = "defMax";
            this.defMax.Size = new System.Drawing.Size(28, 20);
            this.defMax.TabIndex = 25;
            this.defMax.Text = "31";
            this.defMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(387, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "-";
            // 
            // spdMinFilter
            // 
            this.spdMinFilter.Location = new System.Drawing.Point(436, 110);
            this.spdMinFilter.Name = "spdMinFilter";
            this.spdMinFilter.Size = new System.Drawing.Size(29, 20);
            this.spdMinFilter.TabIndex = 41;
            this.spdMinFilter.Text = "0";
            this.spdMinFilter.UseVisualStyleBackColor = true;
            this.spdMinFilter.Click += new System.EventHandler(this.SpdMinFilter_Click);
            // 
            // spdMaxFilter
            // 
            this.spdMaxFilter.Location = new System.Drawing.Point(471, 110);
            this.spdMaxFilter.Name = "spdMaxFilter";
            this.spdMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.spdMaxFilter.TabIndex = 42;
            this.spdMaxFilter.Text = "31";
            this.spdMaxFilter.UseVisualStyleBackColor = true;
            this.spdMaxFilter.Click += new System.EventHandler(this.SpdMaxFilter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "-";
            // 
            // speMaxFilter
            // 
            this.speMaxFilter.Location = new System.Drawing.Point(471, 136);
            this.speMaxFilter.Name = "speMaxFilter";
            this.speMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.speMaxFilter.TabIndex = 44;
            this.speMaxFilter.Text = "31";
            this.speMaxFilter.UseVisualStyleBackColor = true;
            this.speMaxFilter.Click += new System.EventHandler(this.SpeMaxFilter_Click);
            // 
            // spaMin
            // 
            this.spaMin.Location = new System.Drawing.Point(353, 84);
            this.spaMin.Name = "spaMin";
            this.spaMin.Size = new System.Drawing.Size(28, 20);
            this.spaMin.TabIndex = 10;
            this.spaMin.Text = "0";
            this.spaMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // atkMinFilter
            // 
            this.atkMinFilter.Location = new System.Drawing.Point(437, 32);
            this.atkMinFilter.Name = "atkMinFilter";
            this.atkMinFilter.Size = new System.Drawing.Size(29, 20);
            this.atkMinFilter.TabIndex = 35;
            this.atkMinFilter.Text = "0";
            this.atkMinFilter.UseVisualStyleBackColor = true;
            this.atkMinFilter.Click += new System.EventHandler(this.AtkMinFilter_Click);
            // 
            // spdMin
            // 
            this.spdMin.Location = new System.Drawing.Point(353, 110);
            this.spdMin.Name = "spdMin";
            this.spdMin.Size = new System.Drawing.Size(28, 20);
            this.spdMin.TabIndex = 12;
            this.spdMin.Text = "0";
            this.spdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spdMax
            // 
            this.spdMax.Location = new System.Drawing.Point(403, 110);
            this.spdMax.Name = "spdMax";
            this.spdMax.Size = new System.Drawing.Size(28, 20);
            this.spdMax.TabIndex = 29;
            this.spdMax.Text = "31";
            this.spdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speMin
            // 
            this.speMin.Location = new System.Drawing.Point(353, 136);
            this.speMin.Name = "speMin";
            this.speMin.Size = new System.Drawing.Size(28, 20);
            this.speMin.TabIndex = 14;
            this.speMin.Text = "0";
            this.speMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speMax
            // 
            this.speMax.Location = new System.Drawing.Point(403, 136);
            this.speMax.Name = "speMax";
            this.speMax.Size = new System.Drawing.Size(28, 20);
            this.speMax.TabIndex = 31;
            this.speMax.Text = "31";
            this.speMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // atkMax
            // 
            this.atkMax.Location = new System.Drawing.Point(403, 32);
            this.atkMax.Name = "atkMax";
            this.atkMax.Size = new System.Drawing.Size(28, 20);
            this.atkMax.TabIndex = 23;
            this.atkMax.Text = "31";
            this.atkMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // atkMaxFilter
            // 
            this.atkMaxFilter.Location = new System.Drawing.Point(471, 32);
            this.atkMaxFilter.Name = "atkMaxFilter";
            this.atkMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.atkMaxFilter.TabIndex = 36;
            this.atkMaxFilter.Text = "31";
            this.atkMaxFilter.UseVisualStyleBackColor = true;
            this.atkMaxFilter.Click += new System.EventHandler(this.AtkMaxFilter_Click);
            // 
            // defMin
            // 
            this.defMin.Location = new System.Drawing.Point(353, 58);
            this.defMin.Name = "defMin";
            this.defMin.Size = new System.Drawing.Size(28, 20);
            this.defMin.TabIndex = 8;
            this.defMin.Text = "0";
            this.defMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // defMinFilter
            // 
            this.defMinFilter.Location = new System.Drawing.Point(437, 58);
            this.defMinFilter.Name = "defMinFilter";
            this.defMinFilter.Size = new System.Drawing.Size(29, 20);
            this.defMinFilter.TabIndex = 37;
            this.defMinFilter.Text = "0";
            this.defMinFilter.UseVisualStyleBackColor = true;
            this.defMinFilter.Click += new System.EventHandler(this.DefMinFilter_Click);
            // 
            // spaMinFilter
            // 
            this.spaMinFilter.Location = new System.Drawing.Point(437, 84);
            this.spaMinFilter.Name = "spaMinFilter";
            this.spaMinFilter.Size = new System.Drawing.Size(29, 20);
            this.spaMinFilter.TabIndex = 39;
            this.spaMinFilter.Text = "0";
            this.spaMinFilter.UseVisualStyleBackColor = true;
            this.spaMinFilter.Click += new System.EventHandler(this.SpaMinFilter_Click);
            // 
            // defMaxFilter
            // 
            this.defMaxFilter.Location = new System.Drawing.Point(471, 58);
            this.defMaxFilter.Name = "defMaxFilter";
            this.defMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.defMaxFilter.TabIndex = 38;
            this.defMaxFilter.Text = "31";
            this.defMaxFilter.UseVisualStyleBackColor = true;
            this.defMaxFilter.Click += new System.EventHandler(this.DefMaxFilter_Click);
            // 
            // spaMax
            // 
            this.spaMax.Location = new System.Drawing.Point(403, 84);
            this.spaMax.Name = "spaMax";
            this.spaMax.Size = new System.Drawing.Size(28, 20);
            this.spaMax.TabIndex = 27;
            this.spaMax.Text = "31";
            this.spaMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "-";
            // 
            // atkMin
            // 
            this.atkMin.Location = new System.Drawing.Point(353, 32);
            this.atkMin.Name = "atkMin";
            this.atkMin.Size = new System.Drawing.Size(28, 20);
            this.atkMin.TabIndex = 6;
            this.atkMin.Text = "0";
            this.atkMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spaMaxFilter
            // 
            this.spaMaxFilter.Location = new System.Drawing.Point(471, 84);
            this.spaMaxFilter.Name = "spaMaxFilter";
            this.spaMaxFilter.Size = new System.Drawing.Size(29, 20);
            this.spaMaxFilter.TabIndex = 40;
            this.spaMaxFilter.Text = "31";
            this.spaMaxFilter.UseVisualStyleBackColor = true;
            this.spaMaxFilter.Click += new System.EventHandler(this.SpaMaxFilter_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectedShiny);
            this.Controls.Add(this.LabelShiny);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.LabelSlot);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.SlotMax);
            this.Controls.Add(this.SlotMin);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.LevelMax);
            this.Controls.Add(this.LevelMin);
            this.Controls.Add(this.CheckExtraRoll);
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
            this.Controls.Add(this.LabelSID);
            this.Controls.Add(this.LabelTID);
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
            this.Controls.Add(this.ImageRareMark);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SwSh OWRNG Generator GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageRareMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label LabelTID;
        private System.Windows.Forms.Label LabelSID;
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
        private System.Windows.Forms.CheckBox CheckExtraRoll;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox LevelMax;
        private System.Windows.Forms.TextBox LevelMin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox SlotMax;
        private System.Windows.Forms.TextBox SlotMin;
        private System.Windows.Forms.Label LabelLevel;
        private System.Windows.Forms.Label LabelSlot;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ComboBox SelectedShiny;
        private System.Windows.Forms.Label LabelShiny;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Def;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
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
    }
}

