namespace SWSH_OWRNG_Generator.WinForms
{
    partial class Cram_o_matic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cram_o_matic));
            this.LabelState1 = new System.Windows.Forms.Label();
            this.InputState1 = new System.Windows.Forms.TextBox();
            this.InputState0 = new System.Windows.Forms.TextBox();
            this.LabelState0 = new System.Windows.Forms.Label();
            this.SelectedItem = new System.Windows.Forms.ComboBox();
            this.LabelItemInput = new System.Windows.Forms.Label();
            this.CramResults = new System.Windows.Forms.DataGridView();
            this.LabelMaxAdv = new System.Windows.Forms.Label();
            this.InputMaxAdv = new System.Windows.Forms.TextBox();
            this.LabelInitialAdv = new System.Windows.Forms.Label();
            this.InputInitialAdv = new System.Windows.Forms.TextBox();
            this.CramProgressBar = new System.Windows.Forms.ProgressBar();
            this.CramSearch = new System.Windows.Forms.Button();
            this.CramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CheckPoke = new System.Windows.Forms.CheckBox();
            this.CheckGreat = new System.Windows.Forms.CheckBox();
            this.CheckShop1 = new System.Windows.Forms.CheckBox();
            this.CheckShop2 = new System.Windows.Forms.CheckBox();
            this.CheckApricorn = new System.Windows.Forms.CheckBox();
            this.CheckSafariSport = new System.Windows.Forms.CheckBox();
            this.CheckBonus = new System.Windows.Forms.CheckBox();
            this.CheckMenuClose = new System.Windows.Forms.CheckBox();
            this.LabelNPCs = new System.Windows.Forms.Label();
            this.InputNPCs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CramResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelState1
            // 
            this.LabelState1.AutoSize = true;
            this.LabelState1.Location = new System.Drawing.Point(12, 36);
            this.LabelState1.Name = "LabelState1";
            this.LabelState1.Size = new System.Drawing.Size(50, 15);
            this.LabelState1.TabIndex = 7;
            this.LabelState1.Text = "State[1]:";
            // 
            // InputState1
            // 
            this.InputState1.Location = new System.Drawing.Point(68, 32);
            this.InputState1.MaxLength = 16;
            this.InputState1.Name = "InputState1";
            this.InputState1.Size = new System.Drawing.Size(189, 23);
            this.InputState1.TabIndex = 2;
            // 
            // InputState0
            // 
            this.InputState0.Location = new System.Drawing.Point(68, 6);
            this.InputState0.MaxLength = 16;
            this.InputState0.Name = "InputState0";
            this.InputState0.Size = new System.Drawing.Size(189, 23);
            this.InputState0.TabIndex = 1;
            // 
            // LabelState0
            // 
            this.LabelState0.AutoSize = true;
            this.LabelState0.Location = new System.Drawing.Point(12, 9);
            this.LabelState0.Name = "LabelState0";
            this.LabelState0.Size = new System.Drawing.Size(53, 15);
            this.LabelState0.TabIndex = 5;
            this.LabelState0.Text = "State[0]: ";
            // 
            // SelectedItem
            // 
            this.SelectedItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedItem.FormattingEnabled = true;
            this.SelectedItem.ItemHeight = 15;
            this.SelectedItem.Items.AddRange(new object[] {
            "Same Apricorn",
            "Mixed Apricorn"});
            this.SelectedItem.Location = new System.Drawing.Point(68, 61);
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(189, 23);
            this.SelectedItem.TabIndex = 3;
            // 
            // LabelItemInput
            // 
            this.LabelItemInput.AutoSize = true;
            this.LabelItemInput.Location = new System.Drawing.Point(28, 64);
            this.LabelItemInput.Name = "LabelItemInput";
            this.LabelItemInput.Size = new System.Drawing.Size(34, 15);
            this.LabelItemInput.TabIndex = 137;
            this.LabelItemInput.Text = "Item:";
            // 
            // CramResults
            // 
            this.CramResults.AllowUserToAddRows = false;
            this.CramResults.AllowUserToDeleteRows = false;
            this.CramResults.AllowUserToResizeRows = false;
            this.CramResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CramResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CramResults.Location = new System.Drawing.Point(263, 6);
            this.CramResults.MultiSelect = false;
            this.CramResults.Name = "CramResults";
            this.CramResults.ReadOnly = true;
            this.CramResults.RowHeadersVisible = false;
            this.CramResults.RowTemplate.Height = 25;
            this.CramResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CramResults.Size = new System.Drawing.Size(612, 388);
            this.CramResults.TabIndex = 16;
            // 
            // LabelMaxAdv
            // 
            this.LabelMaxAdv.AutoSize = true;
            this.LabelMaxAdv.Location = new System.Drawing.Point(47, 119);
            this.LabelMaxAdv.Name = "LabelMaxAdv";
            this.LabelMaxAdv.Size = new System.Drawing.Size(15, 15);
            this.LabelMaxAdv.TabIndex = 140;
            this.LabelMaxAdv.Text = "+";
            // 
            // InputMaxAdv
            // 
            this.InputMaxAdv.Location = new System.Drawing.Point(68, 116);
            this.InputMaxAdv.MaxLength = 13;
            this.InputMaxAdv.Name = "InputMaxAdv";
            this.InputMaxAdv.Size = new System.Drawing.Size(189, 23);
            this.InputMaxAdv.TabIndex = 5;
            this.InputMaxAdv.Text = "5000";
            // 
            // LabelInitialAdv
            // 
            this.LabelInitialAdv.AutoSize = true;
            this.LabelInitialAdv.Location = new System.Drawing.Point(5, 93);
            this.LabelInitialAdv.Name = "LabelInitialAdv";
            this.LabelInitialAdv.Size = new System.Drawing.Size(57, 15);
            this.LabelInitialAdv.TabIndex = 142;
            this.LabelInitialAdv.Text = "Init. Adv.:";
            // 
            // InputInitialAdv
            // 
            this.InputInitialAdv.Location = new System.Drawing.Point(68, 90);
            this.InputInitialAdv.MaxLength = 13;
            this.InputInitialAdv.Name = "InputInitialAdv";
            this.InputInitialAdv.Size = new System.Drawing.Size(189, 23);
            this.InputInitialAdv.TabIndex = 4;
            this.InputInitialAdv.Text = "0";
            // 
            // CramProgressBar
            // 
            this.CramProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CramProgressBar.Location = new System.Drawing.Point(14, 185);
            this.CramProgressBar.Name = "CramProgressBar";
            this.CramProgressBar.Size = new System.Drawing.Size(243, 10);
            this.CramProgressBar.TabIndex = 144;
            // 
            // CramSearch
            // 
            this.CramSearch.Location = new System.Drawing.Point(12, 148);
            this.CramSearch.Name = "CramSearch";
            this.CramSearch.Size = new System.Drawing.Size(245, 31);
            this.CramSearch.TabIndex = 6;
            this.CramSearch.Text = "Search!";
            this.CramSearch.UseVisualStyleBackColor = true;
            this.CramSearch.Click += new System.EventHandler(this.CramSearch_Click);
            // 
            // CheckPoke
            // 
            this.CheckPoke.AutoSize = true;
            this.CheckPoke.Location = new System.Drawing.Point(12, 230);
            this.CheckPoke.Name = "CheckPoke";
            this.CheckPoke.Size = new System.Drawing.Size(106, 19);
            this.CheckPoke.TabIndex = 9;
            this.CheckPoke.Text = "Show Poké Ball";
            this.CheckPoke.UseVisualStyleBackColor = true;
            // 
            // CheckGreat
            // 
            this.CheckGreat.AutoSize = true;
            this.CheckGreat.Location = new System.Drawing.Point(12, 255);
            this.CheckGreat.Name = "CheckGreat";
            this.CheckGreat.Size = new System.Drawing.Size(108, 19);
            this.CheckGreat.TabIndex = 10;
            this.CheckGreat.Text = "Show Great Ball";
            this.CheckGreat.UseVisualStyleBackColor = true;
            // 
            // CheckShop1
            // 
            this.CheckShop1.AutoSize = true;
            this.CheckShop1.Location = new System.Drawing.Point(12, 280);
            this.CheckShop1.Name = "CheckShop1";
            this.CheckShop1.Size = new System.Drawing.Size(116, 19);
            this.CheckShop1.TabIndex = 11;
            this.CheckShop1.Text = "Show Shop Ball 1";
            this.CheckShop1.UseVisualStyleBackColor = true;
            // 
            // CheckShop2
            // 
            this.CheckShop2.AutoSize = true;
            this.CheckShop2.Location = new System.Drawing.Point(12, 305);
            this.CheckShop2.Name = "CheckShop2";
            this.CheckShop2.Size = new System.Drawing.Size(116, 19);
            this.CheckShop2.TabIndex = 12;
            this.CheckShop2.Text = "Show Shop Ball 2";
            this.CheckShop2.UseVisualStyleBackColor = true;
            // 
            // CheckApricorn
            // 
            this.CheckApricorn.AutoSize = true;
            this.CheckApricorn.Checked = true;
            this.CheckApricorn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckApricorn.Location = new System.Drawing.Point(12, 330);
            this.CheckApricorn.Name = "CheckApricorn";
            this.CheckApricorn.Size = new System.Drawing.Size(99, 19);
            this.CheckApricorn.TabIndex = 13;
            this.CheckApricorn.Text = "Show Apriball";
            this.CheckApricorn.UseVisualStyleBackColor = true;
            // 
            // CheckSafariSport
            // 
            this.CheckSafariSport.AutoSize = true;
            this.CheckSafariSport.Checked = true;
            this.CheckSafariSport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSafariSport.Location = new System.Drawing.Point(12, 355);
            this.CheckSafariSport.Name = "CheckSafariSport";
            this.CheckSafariSport.Size = new System.Drawing.Size(142, 19);
            this.CheckSafariSport.TabIndex = 14;
            this.CheckSafariSport.Text = "Show Safari/Sport Ball";
            this.CheckSafariSport.UseVisualStyleBackColor = true;
            // 
            // CheckBonus
            // 
            this.CheckBonus.AutoSize = true;
            this.CheckBonus.Checked = true;
            this.CheckBonus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBonus.Location = new System.Drawing.Point(12, 380);
            this.CheckBonus.Name = "CheckBonus";
            this.CheckBonus.Size = new System.Drawing.Size(156, 19);
            this.CheckBonus.TabIndex = 15;
            this.CheckBonus.Text = "Show Bonus frames only";
            this.CheckBonus.UseVisualStyleBackColor = true;
            // 
            // CheckMenuClose
            // 
            this.CheckMenuClose.AutoSize = true;
            this.CheckMenuClose.Location = new System.Drawing.Point(108, 204);
            this.CheckMenuClose.Name = "CheckMenuClose";
            this.CheckMenuClose.Size = new System.Drawing.Size(139, 19);
            this.CheckMenuClose.TabIndex = 8;
            this.CheckMenuClose.Text = "Consider Menu Close";
            this.CheckMenuClose.UseVisualStyleBackColor = true;
            this.CheckMenuClose.CheckedChanged += new System.EventHandler(this.CheckMenuClose_CheckedChanged);
            // 
            // LabelNPCs
            // 
            this.LabelNPCs.AutoSize = true;
            this.LabelNPCs.Location = new System.Drawing.Point(23, 204);
            this.LabelNPCs.Name = "LabelNPCs";
            this.LabelNPCs.Size = new System.Drawing.Size(39, 15);
            this.LabelNPCs.TabIndex = 172;
            this.LabelNPCs.Text = "NPCs:";
            // 
            // InputNPCs
            // 
            this.InputNPCs.Enabled = false;
            this.InputNPCs.Location = new System.Drawing.Point(68, 201);
            this.InputNPCs.MaxLength = 2;
            this.InputNPCs.Name = "InputNPCs";
            this.InputNPCs.Size = new System.Drawing.Size(34, 23);
            this.InputNPCs.TabIndex = 7;
            this.InputNPCs.Text = "20";
            // 
            // Cram_o_matic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 406);
            this.Controls.Add(this.CheckMenuClose);
            this.Controls.Add(this.LabelNPCs);
            this.Controls.Add(this.InputNPCs);
            this.Controls.Add(this.CheckBonus);
            this.Controls.Add(this.CheckSafariSport);
            this.Controls.Add(this.CheckApricorn);
            this.Controls.Add(this.CheckShop2);
            this.Controls.Add(this.CheckShop1);
            this.Controls.Add(this.CheckGreat);
            this.Controls.Add(this.CheckPoke);
            this.Controls.Add(this.CramProgressBar);
            this.Controls.Add(this.CramSearch);
            this.Controls.Add(this.LabelInitialAdv);
            this.Controls.Add(this.InputInitialAdv);
            this.Controls.Add(this.LabelMaxAdv);
            this.Controls.Add(this.InputMaxAdv);
            this.Controls.Add(this.CramResults);
            this.Controls.Add(this.SelectedItem);
            this.Controls.Add(this.LabelItemInput);
            this.Controls.Add(this.LabelState1);
            this.Controls.Add(this.InputState1);
            this.Controls.Add(this.InputState0);
            this.Controls.Add(this.LabelState0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cram_o_matic";
            this.Text = "Cram-o-matic";
            ((System.ComponentModel.ISupportInitialize)(this.CramResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CramBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelState1;
        private System.Windows.Forms.TextBox InputState1;
        private System.Windows.Forms.TextBox InputState0;
        private System.Windows.Forms.Label LabelState0;
        private System.Windows.Forms.ComboBox SelectedItem;
        private System.Windows.Forms.Label LabelItemInput;
        private System.Windows.Forms.DataGridView CramResults;
        private System.Windows.Forms.Label LabelMaxAdv;
        private System.Windows.Forms.TextBox InputMaxAdv;
        private System.Windows.Forms.Label LabelInitialAdv;
        private System.Windows.Forms.TextBox InputInitialAdv;
        private System.Windows.Forms.ProgressBar CramProgressBar;
        private System.Windows.Forms.Button CramSearch;
        private System.Windows.Forms.BindingSource CramBindingSource;
        private System.Windows.Forms.CheckBox CheckPoke;
        private System.Windows.Forms.CheckBox CheckGreat;
        private System.Windows.Forms.CheckBox CheckShop1;
        private System.Windows.Forms.CheckBox CheckShop2;
        private System.Windows.Forms.CheckBox CheckApricorn;
        private System.Windows.Forms.CheckBox CheckSafariSport;
        private System.Windows.Forms.CheckBox CheckBonus;
        private System.Windows.Forms.CheckBox CheckMenuClose;
        private System.Windows.Forms.Label LabelNPCs;
        private System.Windows.Forms.TextBox InputNPCs;
    }
}