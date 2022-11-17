namespace SWSH_OWRNG_Generator.WinForms
{
    partial class MenuCloseTimeline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCloseTimeline));
            this.LabelNPCs = new System.Windows.Forms.Label();
            this.InputNPCs = new System.Windows.Forms.TextBox();
            this.CheckHoldingDirection = new System.Windows.Forms.CheckBox();
            this.CheckInCave = new System.Windows.Forms.CheckBox();
            this.TimelineProgressBar = new System.Windows.Forms.ProgressBar();
            this.TimelineSearch = new System.Windows.Forms.Button();
            this.LabelInitialAdv = new System.Windows.Forms.Label();
            this.InputInitialAdv = new System.Windows.Forms.TextBox();
            this.LabelMaxAdv = new System.Windows.Forms.Label();
            this.InputMaxAdv = new System.Windows.Forms.TextBox();
            this.TimelineResults = new System.Windows.Forms.DataGridView();
            this.LabelState1 = new System.Windows.Forms.Label();
            this.InputState1 = new System.Windows.Forms.TextBox();
            this.InputState0 = new System.Windows.Forms.TextBox();
            this.LabelState0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimelineResults)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNPCs
            // 
            this.LabelNPCs.AutoSize = true;
            this.LabelNPCs.Location = new System.Drawing.Point(182, 175);
            this.LabelNPCs.Name = "LabelNPCs";
            this.LabelNPCs.Size = new System.Drawing.Size(39, 15);
            this.LabelNPCs.TabIndex = 190;
            this.LabelNPCs.Text = "NPCs:";
            // 
            // InputNPCs
            // 
            this.InputNPCs.Location = new System.Drawing.Point(227, 172);
            this.InputNPCs.MaxLength = 2;
            this.InputNPCs.Name = "InputNPCs";
            this.InputNPCs.Size = new System.Drawing.Size(34, 23);
            this.InputNPCs.TabIndex = 189;
            this.InputNPCs.Text = "5";
            // 
            // CheckHoldingDirection
            // 
            this.CheckHoldingDirection.AutoSize = true;
            this.CheckHoldingDirection.Location = new System.Drawing.Point(16, 215);
            this.CheckHoldingDirection.Name = "CheckHoldingDirection";
            this.CheckHoldingDirection.Size = new System.Drawing.Size(124, 19);
            this.CheckHoldingDirection.TabIndex = 188;
            this.CheckHoldingDirection.Text = "Holding direction?";
            this.CheckHoldingDirection.UseVisualStyleBackColor = true;
            // 
            // CheckInCave
            // 
            this.CheckInCave.AutoSize = true;
            this.CheckInCave.Enabled = false;
            this.CheckInCave.Location = new System.Drawing.Point(16, 240);
            this.CheckInCave.Name = "CheckInCave";
            this.CheckInCave.Size = new System.Drawing.Size(77, 19);
            this.CheckInCave.TabIndex = 187;
            this.CheckInCave.Text = "In a cave?";
            this.CheckInCave.UseVisualStyleBackColor = true;
            // 
            // TimelineProgressBar
            // 
            this.TimelineProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimelineProgressBar.Location = new System.Drawing.Point(18, 156);
            this.TimelineProgressBar.Name = "TimelineProgressBar";
            this.TimelineProgressBar.Size = new System.Drawing.Size(243, 10);
            this.TimelineProgressBar.TabIndex = 182;
            // 
            // TimelineSearch
            // 
            this.TimelineSearch.Location = new System.Drawing.Point(16, 119);
            this.TimelineSearch.Name = "TimelineSearch";
            this.TimelineSearch.Size = new System.Drawing.Size(245, 31);
            this.TimelineSearch.TabIndex = 176;
            this.TimelineSearch.Text = "Search!";
            this.TimelineSearch.UseVisualStyleBackColor = true;
            this.TimelineSearch.Click += new System.EventHandler(this.TimelineSearch_Click);
            // 
            // LabelInitialAdv
            // 
            this.LabelInitialAdv.AutoSize = true;
            this.LabelInitialAdv.Location = new System.Drawing.Point(9, 67);
            this.LabelInitialAdv.Name = "LabelInitialAdv";
            this.LabelInitialAdv.Size = new System.Drawing.Size(57, 15);
            this.LabelInitialAdv.TabIndex = 181;
            this.LabelInitialAdv.Text = "Init. Adv.:";
            // 
            // InputInitialAdv
            // 
            this.InputInitialAdv.Location = new System.Drawing.Point(72, 64);
            this.InputInitialAdv.MaxLength = 13;
            this.InputInitialAdv.Name = "InputInitialAdv";
            this.InputInitialAdv.Size = new System.Drawing.Size(189, 23);
            this.InputInitialAdv.TabIndex = 173;
            this.InputInitialAdv.Text = "0";
            // 
            // LabelMaxAdv
            // 
            this.LabelMaxAdv.AutoSize = true;
            this.LabelMaxAdv.Location = new System.Drawing.Point(51, 93);
            this.LabelMaxAdv.Name = "LabelMaxAdv";
            this.LabelMaxAdv.Size = new System.Drawing.Size(15, 15);
            this.LabelMaxAdv.TabIndex = 180;
            this.LabelMaxAdv.Text = "+";
            // 
            // InputMaxAdv
            // 
            this.InputMaxAdv.Location = new System.Drawing.Point(72, 90);
            this.InputMaxAdv.MaxLength = 13;
            this.InputMaxAdv.Name = "InputMaxAdv";
            this.InputMaxAdv.Size = new System.Drawing.Size(189, 23);
            this.InputMaxAdv.TabIndex = 174;
            this.InputMaxAdv.Text = "5000";
            // 
            // TimelineResults
            // 
            this.TimelineResults.AllowUserToAddRows = false;
            this.TimelineResults.AllowUserToDeleteRows = false;
            this.TimelineResults.AllowUserToResizeRows = false;
            this.TimelineResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimelineResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimelineResults.Location = new System.Drawing.Point(267, 12);
            this.TimelineResults.MultiSelect = false;
            this.TimelineResults.Name = "TimelineResults";
            this.TimelineResults.ReadOnly = true;
            this.TimelineResults.RowHeadersVisible = false;
            this.TimelineResults.RowTemplate.Height = 25;
            this.TimelineResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimelineResults.Size = new System.Drawing.Size(627, 278);
            this.TimelineResults.TabIndex = 179;
            // 
            // LabelState1
            // 
            this.LabelState1.AutoSize = true;
            this.LabelState1.Location = new System.Drawing.Point(16, 42);
            this.LabelState1.Name = "LabelState1";
            this.LabelState1.Size = new System.Drawing.Size(50, 15);
            this.LabelState1.TabIndex = 177;
            this.LabelState1.Text = "State[1]:";
            // 
            // InputState1
            // 
            this.InputState1.Location = new System.Drawing.Point(72, 38);
            this.InputState1.MaxLength = 16;
            this.InputState1.Name = "InputState1";
            this.InputState1.Size = new System.Drawing.Size(189, 23);
            this.InputState1.TabIndex = 172;
            // 
            // InputState0
            // 
            this.InputState0.Location = new System.Drawing.Point(72, 12);
            this.InputState0.MaxLength = 16;
            this.InputState0.Name = "InputState0";
            this.InputState0.Size = new System.Drawing.Size(189, 23);
            this.InputState0.TabIndex = 171;
            // 
            // LabelState0
            // 
            this.LabelState0.AutoSize = true;
            this.LabelState0.Location = new System.Drawing.Point(16, 15);
            this.LabelState0.Name = "LabelState0";
            this.LabelState0.Size = new System.Drawing.Size(53, 15);
            this.LabelState0.TabIndex = 175;
            this.LabelState0.Text = "State[0]: ";
            // 
            // MenuCloseTimeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 302);
            this.Controls.Add(this.LabelNPCs);
            this.Controls.Add(this.InputNPCs);
            this.Controls.Add(this.CheckHoldingDirection);
            this.Controls.Add(this.CheckInCave);
            this.Controls.Add(this.TimelineProgressBar);
            this.Controls.Add(this.TimelineSearch);
            this.Controls.Add(this.LabelInitialAdv);
            this.Controls.Add(this.InputInitialAdv);
            this.Controls.Add(this.LabelMaxAdv);
            this.Controls.Add(this.InputMaxAdv);
            this.Controls.Add(this.TimelineResults);
            this.Controls.Add(this.LabelState1);
            this.Controls.Add(this.InputState1);
            this.Controls.Add(this.InputState0);
            this.Controls.Add(this.LabelState0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuCloseTimeline";
            this.Text = " MenuCloseTimeline";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuCloseTimeline_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TimelineResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelNPCs;
        private System.Windows.Forms.TextBox InputNPCs;
        private System.Windows.Forms.CheckBox CheckHoldingDirection;
        private System.Windows.Forms.CheckBox CheckInCave;
        private System.Windows.Forms.ProgressBar TimelineProgressBar;
        private System.Windows.Forms.Button TimelineSearch;
        private System.Windows.Forms.Label LabelInitialAdv;
        private System.Windows.Forms.TextBox InputInitialAdv;
        private System.Windows.Forms.Label LabelMaxAdv;
        private System.Windows.Forms.TextBox InputMaxAdv;
        private System.Windows.Forms.DataGridView TimelineResults;
        private System.Windows.Forms.Label LabelState1;
        private System.Windows.Forms.TextBox InputState1;
        private System.Windows.Forms.TextBox InputState0;
        private System.Windows.Forms.Label LabelState0;
    }
}