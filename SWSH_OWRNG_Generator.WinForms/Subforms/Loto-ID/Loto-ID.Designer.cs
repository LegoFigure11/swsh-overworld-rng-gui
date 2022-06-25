namespace SWSH_OWRNG_Generator.WinForms
{
    partial class Loto_ID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loto_ID));
            this.LotoIDProgressBar = new System.Windows.Forms.ProgressBar();
            this.LotoIDSearch = new System.Windows.Forms.Button();
            this.LabelInitialAdv = new System.Windows.Forms.Label();
            this.InputInitialAdv = new System.Windows.Forms.TextBox();
            this.LabelMaxAdv = new System.Windows.Forms.Label();
            this.InputMaxAdv = new System.Windows.Forms.TextBox();
            this.LotoIdResults = new System.Windows.Forms.DataGridView();
            this.LabelDisplayIDInput = new System.Windows.Forms.Label();
            this.LabelState1 = new System.Windows.Forms.Label();
            this.InputState1 = new System.Windows.Forms.TextBox();
            this.InputState0 = new System.Windows.Forms.TextBox();
            this.LabelState0 = new System.Windows.Forms.Label();
            this.InputDisplayID = new System.Windows.Forms.TextBox();
            this.LabelLoadedFromFile = new System.Windows.Forms.Label();
            this.ButtonReload = new System.Windows.Forms.Button();
            this.InputLoadedFromFile = new System.Windows.Forms.TextBox();
            this.LotoIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CheckMaster = new System.Windows.Forms.CheckBox();
            this.CheckRareCandy = new System.Windows.Forms.CheckBox();
            this.CheckPPMax = new System.Windows.Forms.CheckBox();
            this.CheckPPUp = new System.Windows.Forms.CheckBox();
            this.CheckMooMoo = new System.Windows.Forms.CheckBox();
            this.CheckNoItem = new System.Windows.Forms.CheckBox();
            this.LabelNPCs = new System.Windows.Forms.Label();
            this.InputNPCs = new System.Windows.Forms.TextBox();
            this.CheckMenuClose = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LotoIdResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotoIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LotoIDProgressBar
            // 
            this.LotoIDProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LotoIDProgressBar.Location = new System.Drawing.Point(14, 182);
            this.LotoIDProgressBar.Name = "LotoIDProgressBar";
            this.LotoIDProgressBar.Size = new System.Drawing.Size(243, 10);
            this.LotoIDProgressBar.TabIndex = 157;
            // 
            // LotoIDSearch
            // 
            this.LotoIDSearch.Location = new System.Drawing.Point(12, 145);
            this.LotoIDSearch.Name = "LotoIDSearch";
            this.LotoIDSearch.Size = new System.Drawing.Size(245, 31);
            this.LotoIDSearch.TabIndex = 6;
            this.LotoIDSearch.Text = "Search!";
            this.LotoIDSearch.UseVisualStyleBackColor = true;
            this.LotoIDSearch.Click += new System.EventHandler(this.LotoIDSearch_Click);
            // 
            // LabelInitialAdv
            // 
            this.LabelInitialAdv.AutoSize = true;
            this.LabelInitialAdv.Location = new System.Drawing.Point(5, 93);
            this.LabelInitialAdv.Name = "LabelInitialAdv";
            this.LabelInitialAdv.Size = new System.Drawing.Size(57, 15);
            this.LabelInitialAdv.TabIndex = 156;
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
            // LabelMaxAdv
            // 
            this.LabelMaxAdv.AutoSize = true;
            this.LabelMaxAdv.Location = new System.Drawing.Point(47, 119);
            this.LabelMaxAdv.Name = "LabelMaxAdv";
            this.LabelMaxAdv.Size = new System.Drawing.Size(15, 15);
            this.LabelMaxAdv.TabIndex = 155;
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
            // LotoIdResults
            // 
            this.LotoIdResults.AllowUserToAddRows = false;
            this.LotoIdResults.AllowUserToDeleteRows = false;
            this.LotoIdResults.AllowUserToResizeRows = false;
            this.LotoIdResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LotoIdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LotoIdResults.Location = new System.Drawing.Point(263, 12);
            this.LotoIdResults.MultiSelect = false;
            this.LotoIdResults.Name = "LotoIdResults";
            this.LotoIdResults.ReadOnly = true;
            this.LotoIdResults.RowHeadersVisible = false;
            this.LotoIdResults.RowTemplate.Height = 25;
            this.LotoIdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LotoIdResults.Size = new System.Drawing.Size(627, 406);
            this.LotoIdResults.TabIndex = 154;
            // 
            // LabelDisplayIDInput
            // 
            this.LabelDisplayIDInput.AutoSize = true;
            this.LabelDisplayIDInput.Location = new System.Drawing.Point(41, 67);
            this.LabelDisplayIDInput.Name = "LabelDisplayIDInput";
            this.LabelDisplayIDInput.Size = new System.Drawing.Size(21, 15);
            this.LabelDisplayIDInput.TabIndex = 153;
            this.LabelDisplayIDInput.Text = "ID:";
            // 
            // LabelState1
            // 
            this.LabelState1.AutoSize = true;
            this.LabelState1.Location = new System.Drawing.Point(12, 42);
            this.LabelState1.Name = "LabelState1";
            this.LabelState1.Size = new System.Drawing.Size(50, 15);
            this.LabelState1.TabIndex = 151;
            this.LabelState1.Text = "State[1]:";
            // 
            // InputState1
            // 
            this.InputState1.Location = new System.Drawing.Point(68, 38);
            this.InputState1.MaxLength = 16;
            this.InputState1.Name = "InputState1";
            this.InputState1.Size = new System.Drawing.Size(189, 23);
            this.InputState1.TabIndex = 2;
            // 
            // InputState0
            // 
            this.InputState0.Location = new System.Drawing.Point(68, 12);
            this.InputState0.MaxLength = 16;
            this.InputState0.Name = "InputState0";
            this.InputState0.Size = new System.Drawing.Size(189, 23);
            this.InputState0.TabIndex = 1;
            // 
            // LabelState0
            // 
            this.LabelState0.AutoSize = true;
            this.LabelState0.Location = new System.Drawing.Point(12, 15);
            this.LabelState0.Name = "LabelState0";
            this.LabelState0.Size = new System.Drawing.Size(53, 15);
            this.LabelState0.TabIndex = 149;
            this.LabelState0.Text = "State[0]: ";
            // 
            // InputDisplayID
            // 
            this.InputDisplayID.Location = new System.Drawing.Point(68, 64);
            this.InputDisplayID.MaxLength = 6;
            this.InputDisplayID.Name = "InputDisplayID";
            this.InputDisplayID.Size = new System.Drawing.Size(189, 23);
            this.InputDisplayID.TabIndex = 3;
            // 
            // LabelLoadedFromFile
            // 
            this.LabelLoadedFromFile.AutoSize = true;
            this.LabelLoadedFromFile.Location = new System.Drawing.Point(12, 203);
            this.LabelLoadedFromFile.Name = "LabelLoadedFromFile";
            this.LabelLoadedFromFile.Size = new System.Drawing.Size(116, 15);
            this.LabelLoadedFromFile.TabIndex = 159;
            this.LabelLoadedFromFile.Text = "Loaded IDs from file:";
            // 
            // ButtonReload
            // 
            this.ButtonReload.Location = new System.Drawing.Point(206, 198);
            this.ButtonReload.Name = "ButtonReload";
            this.ButtonReload.Size = new System.Drawing.Size(51, 25);
            this.ButtonReload.TabIndex = 7;
            this.ButtonReload.Text = "Reload";
            this.ButtonReload.UseVisualStyleBackColor = true;
            this.ButtonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // InputLoadedFromFile
            // 
            this.InputLoadedFromFile.Location = new System.Drawing.Point(134, 199);
            this.InputLoadedFromFile.MaxLength = 16;
            this.InputLoadedFromFile.Name = "InputLoadedFromFile";
            this.InputLoadedFromFile.ReadOnly = true;
            this.InputLoadedFromFile.Size = new System.Drawing.Size(66, 23);
            this.InputLoadedFromFile.TabIndex = 161;
            this.InputLoadedFromFile.TabStop = false;
            // 
            // CheckMaster
            // 
            this.CheckMaster.AutoSize = true;
            this.CheckMaster.Checked = true;
            this.CheckMaster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckMaster.Location = new System.Drawing.Point(12, 398);
            this.CheckMaster.Name = "CheckMaster";
            this.CheckMaster.Size = new System.Drawing.Size(116, 19);
            this.CheckMaster.TabIndex = 15;
            this.CheckMaster.Text = "Show Master Ball";
            this.CheckMaster.UseVisualStyleBackColor = true;
            // 
            // CheckRareCandy
            // 
            this.CheckRareCandy.AutoSize = true;
            this.CheckRareCandy.Location = new System.Drawing.Point(12, 373);
            this.CheckRareCandy.Name = "CheckRareCandy";
            this.CheckRareCandy.Size = new System.Drawing.Size(118, 19);
            this.CheckRareCandy.TabIndex = 14;
            this.CheckRareCandy.Text = "Show Rare Candy";
            this.CheckRareCandy.UseVisualStyleBackColor = true;
            // 
            // CheckPPMax
            // 
            this.CheckPPMax.AutoSize = true;
            this.CheckPPMax.Location = new System.Drawing.Point(12, 348);
            this.CheckPPMax.Name = "CheckPPMax";
            this.CheckPPMax.Size = new System.Drawing.Size(98, 19);
            this.CheckPPMax.TabIndex = 13;
            this.CheckPPMax.Text = "Show PP Max";
            this.CheckPPMax.UseVisualStyleBackColor = true;
            // 
            // CheckPPUp
            // 
            this.CheckPPUp.AutoSize = true;
            this.CheckPPUp.Location = new System.Drawing.Point(12, 323);
            this.CheckPPUp.Name = "CheckPPUp";
            this.CheckPPUp.Size = new System.Drawing.Size(90, 19);
            this.CheckPPUp.TabIndex = 12;
            this.CheckPPUp.Text = "Show PP Up";
            this.CheckPPUp.UseVisualStyleBackColor = true;
            // 
            // CheckMooMoo
            // 
            this.CheckMooMoo.AutoSize = true;
            this.CheckMooMoo.Location = new System.Drawing.Point(12, 298);
            this.CheckMooMoo.Name = "CheckMooMoo";
            this.CheckMooMoo.Size = new System.Drawing.Size(134, 19);
            this.CheckMooMoo.TabIndex = 11;
            this.CheckMooMoo.Text = "Show MooMoo Milk";
            this.CheckMooMoo.UseVisualStyleBackColor = true;
            // 
            // CheckNoItem
            // 
            this.CheckNoItem.AutoSize = true;
            this.CheckNoItem.Location = new System.Drawing.Point(12, 273);
            this.CheckNoItem.Name = "CheckNoItem";
            this.CheckNoItem.Size = new System.Drawing.Size(101, 19);
            this.CheckNoItem.TabIndex = 10;
            this.CheckNoItem.Text = "Show No Item";
            this.CheckNoItem.UseVisualStyleBackColor = true;
            // 
            // LabelNPCs
            // 
            this.LabelNPCs.AutoSize = true;
            this.LabelNPCs.Location = new System.Drawing.Point(23, 232);
            this.LabelNPCs.Name = "LabelNPCs";
            this.LabelNPCs.Size = new System.Drawing.Size(39, 15);
            this.LabelNPCs.TabIndex = 169;
            this.LabelNPCs.Text = "NPCs:";
            // 
            // InputNPCs
            // 
            this.InputNPCs.Enabled = false;
            this.InputNPCs.Location = new System.Drawing.Point(68, 229);
            this.InputNPCs.MaxLength = 2;
            this.InputNPCs.Name = "InputNPCs";
            this.InputNPCs.Size = new System.Drawing.Size(34, 23);
            this.InputNPCs.TabIndex = 8;
            this.InputNPCs.Text = "5";
            // 
            // CheckMenuClose
            // 
            this.CheckMenuClose.AutoSize = true;
            this.CheckMenuClose.Location = new System.Drawing.Point(108, 232);
            this.CheckMenuClose.Name = "CheckMenuClose";
            this.CheckMenuClose.Size = new System.Drawing.Size(139, 19);
            this.CheckMenuClose.TabIndex = 9;
            this.CheckMenuClose.Text = "Consider Menu Close";
            this.CheckMenuClose.UseVisualStyleBackColor = true;
            this.CheckMenuClose.CheckedChanged += new System.EventHandler(this.CheckMenuClose_CheckedChanged);
            // 
            // Loto_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 430);
            this.Controls.Add(this.CheckMenuClose);
            this.Controls.Add(this.LabelNPCs);
            this.Controls.Add(this.InputNPCs);
            this.Controls.Add(this.CheckNoItem);
            this.Controls.Add(this.CheckMaster);
            this.Controls.Add(this.CheckRareCandy);
            this.Controls.Add(this.CheckPPMax);
            this.Controls.Add(this.CheckPPUp);
            this.Controls.Add(this.CheckMooMoo);
            this.Controls.Add(this.InputLoadedFromFile);
            this.Controls.Add(this.ButtonReload);
            this.Controls.Add(this.LabelLoadedFromFile);
            this.Controls.Add(this.InputDisplayID);
            this.Controls.Add(this.LotoIDProgressBar);
            this.Controls.Add(this.LotoIDSearch);
            this.Controls.Add(this.LabelInitialAdv);
            this.Controls.Add(this.InputInitialAdv);
            this.Controls.Add(this.LabelMaxAdv);
            this.Controls.Add(this.InputMaxAdv);
            this.Controls.Add(this.LotoIdResults);
            this.Controls.Add(this.LabelDisplayIDInput);
            this.Controls.Add(this.LabelState1);
            this.Controls.Add(this.InputState1);
            this.Controls.Add(this.InputState0);
            this.Controls.Add(this.LabelState0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loto_ID";
            this.Text = "Loto-ID";
            ((System.ComponentModel.ISupportInitialize)(this.LotoIdResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotoIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LotoIDProgressBar;
        private System.Windows.Forms.Button LotoIDSearch;
        private System.Windows.Forms.Label LabelInitialAdv;
        private System.Windows.Forms.TextBox InputInitialAdv;
        private System.Windows.Forms.Label LabelMaxAdv;
        private System.Windows.Forms.TextBox InputMaxAdv;
        private System.Windows.Forms.DataGridView LotoIdResults;
        private System.Windows.Forms.Label LabelDisplayIDInput;
        private System.Windows.Forms.Label LabelState1;
        private System.Windows.Forms.TextBox InputState1;
        private System.Windows.Forms.TextBox InputState0;
        private System.Windows.Forms.Label LabelState0;
        private System.Windows.Forms.TextBox InputDisplayID;
        private System.Windows.Forms.Label LabelLoadedFromFile;
        private System.Windows.Forms.Button ButtonReload;
        private System.Windows.Forms.TextBox InputLoadedFromFile;
        private System.Windows.Forms.BindingSource LotoIDBindingSource;
        private System.Windows.Forms.CheckBox CheckMaster;
        private System.Windows.Forms.CheckBox CheckRareCandy;
        private System.Windows.Forms.CheckBox CheckPPMax;
        private System.Windows.Forms.CheckBox CheckPPUp;
        private System.Windows.Forms.CheckBox CheckMooMoo;
        private System.Windows.Forms.CheckBox CheckNoItem;
        private System.Windows.Forms.Label LabelNPCs;
        private System.Windows.Forms.TextBox InputNPCs;
        private System.Windows.Forms.CheckBox CheckMenuClose;
    }
}