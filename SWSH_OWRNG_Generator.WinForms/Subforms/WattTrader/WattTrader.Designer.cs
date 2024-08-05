namespace SWSH_OWRNG_Generator.WinForms.Subforms.WattTrader
{
    partial class WattTrader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WattTrader));
            CheckMenuClose = new System.Windows.Forms.CheckBox();
            LabelNPCs = new System.Windows.Forms.Label();
            InputNPCs = new System.Windows.Forms.TextBox();
            WattProgressBar = new System.Windows.Forms.ProgressBar();
            WattSearch = new System.Windows.Forms.Button();
            LabelInitialAdv = new System.Windows.Forms.Label();
            InputInitialAdv = new System.Windows.Forms.TextBox();
            LabelMaxAdv = new System.Windows.Forms.Label();
            InputMaxAdv = new System.Windows.Forms.TextBox();
            WattResults = new System.Windows.Forms.DataGridView();
            SelectedItem = new System.Windows.Forms.ComboBox();
            LabelItemInput = new System.Windows.Forms.Label();
            LabelState1 = new System.Windows.Forms.Label();
            InputState1 = new System.Windows.Forms.TextBox();
            InputState0 = new System.Windows.Forms.TextBox();
            LabelState0 = new System.Windows.Forms.Label();
            LabelSlot = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            InputSlotMax = new System.Windows.Forms.TextBox();
            InputSlotMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)WattResults).BeginInit();
            SuspendLayout();
            // 
            // CheckMenuClose
            // 
            CheckMenuClose.AutoSize = true;
            CheckMenuClose.Location = new System.Drawing.Point(108, 233);
            CheckMenuClose.Name = "CheckMenuClose";
            CheckMenuClose.Size = new System.Drawing.Size(139, 19);
            CheckMenuClose.TabIndex = 182;
            CheckMenuClose.Text = "Consider Menu Close";
            CheckMenuClose.UseVisualStyleBackColor = true;
            CheckMenuClose.CheckedChanged += CheckMenuClose_CheckedChanged;
            // 
            // LabelNPCs
            // 
            LabelNPCs.AutoSize = true;
            LabelNPCs.Location = new System.Drawing.Point(23, 233);
            LabelNPCs.Name = "LabelNPCs";
            LabelNPCs.Size = new System.Drawing.Size(39, 15);
            LabelNPCs.TabIndex = 188;
            LabelNPCs.Text = "NPCs:";
            // 
            // InputNPCs
            // 
            InputNPCs.Enabled = false;
            InputNPCs.Location = new System.Drawing.Point(68, 230);
            InputNPCs.MaxLength = 2;
            InputNPCs.Name = "InputNPCs";
            InputNPCs.Size = new System.Drawing.Size(34, 23);
            InputNPCs.TabIndex = 180;
            InputNPCs.Text = "4";
            // 
            // WattProgressBar
            // 
            WattProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            WattProgressBar.Location = new System.Drawing.Point(14, 214);
            WattProgressBar.Name = "WattProgressBar";
            WattProgressBar.Size = new System.Drawing.Size(243, 10);
            WattProgressBar.TabIndex = 187;
            // 
            // WattSearch
            // 
            WattSearch.Location = new System.Drawing.Point(12, 177);
            WattSearch.Name = "WattSearch";
            WattSearch.Size = new System.Drawing.Size(245, 31);
            WattSearch.TabIndex = 179;
            WattSearch.Text = "Search!";
            WattSearch.UseVisualStyleBackColor = true;
            WattSearch.Click += WattSearchSearch_Click;
            // 
            // LabelInitialAdv
            // 
            LabelInitialAdv.AutoSize = true;
            LabelInitialAdv.Location = new System.Drawing.Point(5, 122);
            LabelInitialAdv.Name = "LabelInitialAdv";
            LabelInitialAdv.Size = new System.Drawing.Size(57, 15);
            LabelInitialAdv.TabIndex = 186;
            LabelInitialAdv.Text = "Init. Adv.:";
            // 
            // InputInitialAdv
            // 
            InputInitialAdv.Location = new System.Drawing.Point(68, 119);
            InputInitialAdv.MaxLength = 13;
            InputInitialAdv.Name = "InputInitialAdv";
            InputInitialAdv.Size = new System.Drawing.Size(189, 23);
            InputInitialAdv.TabIndex = 176;
            InputInitialAdv.Text = "0";
            // 
            // LabelMaxAdv
            // 
            LabelMaxAdv.AutoSize = true;
            LabelMaxAdv.Location = new System.Drawing.Point(47, 148);
            LabelMaxAdv.Name = "LabelMaxAdv";
            LabelMaxAdv.Size = new System.Drawing.Size(15, 15);
            LabelMaxAdv.TabIndex = 185;
            LabelMaxAdv.Text = "+";
            // 
            // InputMaxAdv
            // 
            InputMaxAdv.Location = new System.Drawing.Point(68, 145);
            InputMaxAdv.MaxLength = 13;
            InputMaxAdv.Name = "InputMaxAdv";
            InputMaxAdv.Size = new System.Drawing.Size(189, 23);
            InputMaxAdv.TabIndex = 177;
            InputMaxAdv.Text = "5000";
            // 
            // WattResults
            // 
            WattResults.AllowUserToAddRows = false;
            WattResults.AllowUserToDeleteRows = false;
            WattResults.AllowUserToResizeRows = false;
            WattResults.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            WattResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WattResults.Location = new System.Drawing.Point(263, 6);
            WattResults.MultiSelect = false;
            WattResults.Name = "WattResults";
            WattResults.ReadOnly = true;
            WattResults.RowHeadersVisible = false;
            WattResults.RowTemplate.Height = 25;
            WattResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            WattResults.Size = new System.Drawing.Size(612, 244);
            WattResults.TabIndex = 183;
            // 
            // SelectedItem
            // 
            SelectedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SelectedItem.FormattingEnabled = true;
            SelectedItem.ItemHeight = 15;
            SelectedItem.Items.AddRange(new object[] { "(None)", "Beast or Dream Ball", "Beast Ball x1", "Dream Ball x1", "Bottle Cap x1", "Bottle Cap x3", "Gold Bottle Cap x1", "Red Apricorn x5", "Blue Apricorn x5", "Yellow Apricorn x5", "Green Apricorn x5", "White Apricorn x5", "Black Apricorn x5", "Pink Apricorn x5", "Red Apricorn x10", "Blue Apricorn x10", "Yellow Apricorn x10", "Green Apricorn x10", "White Apricorn x10", "Black Apricorn x10", "Pink Apricorn x10", "PP Up x1", "PP Up x2", "PP Max x1", "Rare Candy x1", "Rare Candy x5", "Gigantamix x1", "Armorite Ore x1", "Armorite Ore x3", "Armorite Ore x8", "Dynite Ore x1", "Dynite Ore x5", "Max Mushrooms x1", "Max Elixir x1", "Galarica Twig x3", "Galarica Twig x5", "Strawberry Sweet x1", "Love Sweet x1", "Berry Sweet x1", "Clover Sweet x1", "Flower Sweet x1", "Star Sweet x1", "Ribbon Sweet x1", "Big Nugget x1", "Lansat Berry x1", "Starf Berry x1", "Lucky Egg x1", "Electirizer x1", "Magmarizer x1", "Cracked Pot x1", "Chipped Pot x1", "King's Rock x1" });
            SelectedItem.Location = new System.Drawing.Point(68, 61);
            SelectedItem.Name = "SelectedItem";
            SelectedItem.Size = new System.Drawing.Size(189, 23);
            SelectedItem.TabIndex = 175;
            SelectedItem.SelectedIndexChanged += SelectedItem_SelectedIndexChanged;
            // 
            // LabelItemInput
            // 
            LabelItemInput.AutoSize = true;
            LabelItemInput.Location = new System.Drawing.Point(28, 64);
            LabelItemInput.Name = "LabelItemInput";
            LabelItemInput.Size = new System.Drawing.Size(34, 15);
            LabelItemInput.TabIndex = 184;
            LabelItemInput.Text = "Item:";
            // 
            // LabelState1
            // 
            LabelState1.AutoSize = true;
            LabelState1.Location = new System.Drawing.Point(12, 36);
            LabelState1.Name = "LabelState1";
            LabelState1.Size = new System.Drawing.Size(50, 15);
            LabelState1.TabIndex = 181;
            LabelState1.Text = "State[1]:";
            // 
            // InputState1
            // 
            InputState1.Location = new System.Drawing.Point(68, 32);
            InputState1.MaxLength = 16;
            InputState1.Name = "InputState1";
            InputState1.Size = new System.Drawing.Size(189, 23);
            InputState1.TabIndex = 174;
            // 
            // InputState0
            // 
            InputState0.Location = new System.Drawing.Point(68, 6);
            InputState0.MaxLength = 16;
            InputState0.Name = "InputState0";
            InputState0.Size = new System.Drawing.Size(189, 23);
            InputState0.TabIndex = 173;
            // 
            // LabelState0
            // 
            LabelState0.AutoSize = true;
            LabelState0.Location = new System.Drawing.Point(12, 9);
            LabelState0.Name = "LabelState0";
            LabelState0.Size = new System.Drawing.Size(53, 15);
            LabelState0.TabIndex = 178;
            LabelState0.Text = "State[0]: ";
            // 
            // LabelSlot
            // 
            LabelSlot.AutoSize = true;
            LabelSlot.Location = new System.Drawing.Point(32, 93);
            LabelSlot.Name = "LabelSlot";
            LabelSlot.Size = new System.Drawing.Size(30, 15);
            LabelSlot.TabIndex = 192;
            LabelSlot.Text = "Slot:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(157, 93);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(12, 15);
            label21.TabIndex = 191;
            label21.Text = "-";
            // 
            // InputSlotMax
            // 
            InputSlotMax.Location = new System.Drawing.Point(174, 90);
            InputSlotMax.MaxLength = 3;
            InputSlotMax.Name = "InputSlotMax";
            InputSlotMax.Size = new System.Drawing.Size(83, 23);
            InputSlotMax.TabIndex = 190;
            InputSlotMax.Text = "828";
            InputSlotMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputSlotMin
            // 
            InputSlotMin.Location = new System.Drawing.Point(68, 90);
            InputSlotMin.MaxLength = 3;
            InputSlotMin.Name = "InputSlotMin";
            InputSlotMin.Size = new System.Drawing.Size(83, 23);
            InputSlotMin.TabIndex = 189;
            InputSlotMin.Text = "827";
            InputSlotMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WattTrader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(887, 262);
            Controls.Add(LabelSlot);
            Controls.Add(label21);
            Controls.Add(InputSlotMax);
            Controls.Add(InputSlotMin);
            Controls.Add(CheckMenuClose);
            Controls.Add(LabelNPCs);
            Controls.Add(InputNPCs);
            Controls.Add(WattProgressBar);
            Controls.Add(WattSearch);
            Controls.Add(LabelInitialAdv);
            Controls.Add(InputInitialAdv);
            Controls.Add(LabelMaxAdv);
            Controls.Add(InputMaxAdv);
            Controls.Add(WattResults);
            Controls.Add(SelectedItem);
            Controls.Add(LabelItemInput);
            Controls.Add(LabelState1);
            Controls.Add(InputState1);
            Controls.Add(InputState0);
            Controls.Add(LabelState0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "WattTrader";
            Text = "WattTrader";
            FormClosed += WattTrader_FormClosed;
            ((System.ComponentModel.ISupportInitialize)WattResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox CheckMenuClose;
        private System.Windows.Forms.Label LabelNPCs;
        private System.Windows.Forms.TextBox InputNPCs;
        private System.Windows.Forms.ProgressBar WattProgressBar;
        private System.Windows.Forms.Button WattSearch;
        private System.Windows.Forms.Label LabelInitialAdv;
        private System.Windows.Forms.TextBox InputInitialAdv;
        private System.Windows.Forms.Label LabelMaxAdv;
        private System.Windows.Forms.TextBox InputMaxAdv;
        private System.Windows.Forms.DataGridView WattResults;
        private System.Windows.Forms.ComboBox SelectedItem;
        private System.Windows.Forms.Label LabelItemInput;
        private System.Windows.Forms.Label LabelState1;
        private System.Windows.Forms.TextBox InputState1;
        private System.Windows.Forms.TextBox InputState0;
        private System.Windows.Forms.Label LabelState0;
        private System.Windows.Forms.Label LabelSlot;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox InputSlotMax;
        public System.Windows.Forms.TextBox InputSlotMin;
    }
}