namespace SWSH_OWRNG_Generator.WinForms
{
    partial class EncounterLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncounterLookup));
            this.LabelGameVersion = new System.Windows.Forms.Label();
            this.SelectedGame = new System.Windows.Forms.ComboBox();
            this.SelectedSpecies = new System.Windows.Forms.ComboBox();
            this.LabelSpecies = new System.Windows.Forms.Label();
            this.EncounterLookupResults = new System.Windows.Forms.DataGridView();
            this.EncounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EncounterLookupResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncounterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelGameVersion
            // 
            this.LabelGameVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameVersion.AutoSize = true;
            this.LabelGameVersion.Location = new System.Drawing.Point(620, 15);
            this.LabelGameVersion.Name = "LabelGameVersion";
            this.LabelGameVersion.Size = new System.Drawing.Size(41, 15);
            this.LabelGameVersion.TabIndex = 0;
            this.LabelGameVersion.Text = "Game:";
            // 
            // SelectedGame
            // 
            this.SelectedGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedGame.FormattingEnabled = true;
            this.SelectedGame.Items.AddRange(new object[] {
            "Shield",
            "Sword"});
            this.SelectedGame.Location = new System.Drawing.Point(667, 12);
            this.SelectedGame.Name = "SelectedGame";
            this.SelectedGame.Size = new System.Drawing.Size(121, 23);
            this.SelectedGame.TabIndex = 1;
            this.SelectedGame.SelectedIndexChanged += new System.EventHandler(this.PopulateEncounterDataTable);
            // 
            // SelectedSpecies
            // 
            this.SelectedSpecies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedSpecies.FormattingEnabled = true;
            this.SelectedSpecies.Location = new System.Drawing.Point(67, 12);
            this.SelectedSpecies.Name = "SelectedSpecies";
            this.SelectedSpecies.Size = new System.Drawing.Size(547, 23);
            this.SelectedSpecies.TabIndex = 2;
            this.SelectedSpecies.SelectedIndexChanged += new System.EventHandler(this.PopulateEncounterDataTable);
            // 
            // LabelSpecies
            // 
            this.LabelSpecies.AutoSize = true;
            this.LabelSpecies.Location = new System.Drawing.Point(12, 15);
            this.LabelSpecies.Name = "LabelSpecies";
            this.LabelSpecies.Size = new System.Drawing.Size(49, 15);
            this.LabelSpecies.TabIndex = 3;
            this.LabelSpecies.Text = "Species:";
            // 
            // EncounterLookupResults
            // 
            this.EncounterLookupResults.AllowUserToAddRows = false;
            this.EncounterLookupResults.AllowUserToDeleteRows = false;
            this.EncounterLookupResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncounterLookupResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EncounterLookupResults.Location = new System.Drawing.Point(12, 41);
            this.EncounterLookupResults.Name = "EncounterLookupResults";
            this.EncounterLookupResults.ReadOnly = true;
            this.EncounterLookupResults.RowTemplate.Height = 25;
            this.EncounterLookupResults.Size = new System.Drawing.Size(776, 397);
            this.EncounterLookupResults.TabIndex = 4;
            // 
            // EncounterLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EncounterLookupResults);
            this.Controls.Add(this.LabelSpecies);
            this.Controls.Add(this.SelectedSpecies);
            this.Controls.Add(this.SelectedGame);
            this.Controls.Add(this.LabelGameVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncounterLookup";
            this.Text = "Encounter Lookup";
            ((System.ComponentModel.ISupportInitialize)(this.EncounterLookupResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncounterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGameVersion;
        private System.Windows.Forms.ComboBox SelectedGame;
        private System.Windows.Forms.ComboBox SelectedSpecies;
        private System.Windows.Forms.Label LabelSpecies;
        private System.Windows.Forms.DataGridView EncounterLookupResults;
        private System.Windows.Forms.BindingSource EncounterBindingSource;
    }
}