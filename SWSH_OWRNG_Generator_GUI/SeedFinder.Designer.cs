
namespace SWSH_OWRNG_Generator_GUI
{
    partial class SeedFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeedFinder));
            this.OKButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultState1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultState0 = new System.Windows.Forms.TextBox();
            this.MotionsSequenceInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhysicalButton = new System.Windows.Forms.Button();
            this.SpecialButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LabelCompletedInputs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            resources.ApplyResources(this.OKButton, "OKButton");
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Name = "OKButton";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ResultState1
            // 
            resources.ApplyResources(this.ResultState1, "ResultState1");
            this.ResultState1.Name = "ResultState1";
            this.ResultState1.ReadOnly = true;
            this.ResultState1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ResultState0
            // 
            resources.ApplyResources(this.ResultState0, "ResultState0");
            this.ResultState0.Name = "ResultState0";
            this.ResultState0.ReadOnly = true;
            this.ResultState0.TabStop = false;
            // 
            // MotionsSequenceInput
            // 
            resources.ApplyResources(this.MotionsSequenceInput, "MotionsSequenceInput");
            this.MotionsSequenceInput.Name = "MotionsSequenceInput";
            this.MotionsSequenceInput.TextChanged += new System.EventHandler(this.MotionsSequenceInput_TextChanged);
            this.MotionsSequenceInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BinInput_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PhysicalButton
            // 
            resources.ApplyResources(this.PhysicalButton, "PhysicalButton");
            this.PhysicalButton.Name = "PhysicalButton";
            this.PhysicalButton.UseVisualStyleBackColor = true;
            this.PhysicalButton.Click += new System.EventHandler(this.PhysicalButton_Click);
            // 
            // SpecialButton
            // 
            resources.ApplyResources(this.SpecialButton, "SpecialButton");
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.UseVisualStyleBackColor = true;
            this.SpecialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // LabelCompletedInputs
            // 
            resources.ApplyResources(this.LabelCompletedInputs, "LabelCompletedInputs");
            this.LabelCompletedInputs.Name = "LabelCompletedInputs";
            // 
            // SeedFinder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCompletedInputs);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SpecialButton);
            this.Controls.Add(this.PhysicalButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MotionsSequenceInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultState1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultState0);
            this.Controls.Add(this.OKButton);
            this.Name = "SeedFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultState1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultState0;
        private System.Windows.Forms.TextBox MotionsSequenceInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PhysicalButton;
        private System.Windows.Forms.Button SpecialButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label LabelCompletedInputs;
    }
}