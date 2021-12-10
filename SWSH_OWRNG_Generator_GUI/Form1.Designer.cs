
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
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(15, 162);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(156, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "Update Main Form";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Current State[1]:";
            // 
            // ResultState1
            // 
            this.ResultState1.Location = new System.Drawing.Point(15, 68);
            this.ResultState1.MaxLength = 16;
            this.ResultState1.Name = "ResultState1";
            this.ResultState1.ReadOnly = true;
            this.ResultState1.Size = new System.Drawing.Size(207, 20);
            this.ResultState1.TabIndex = 90;
            this.ResultState1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Current State[0]:";
            // 
            // ResultState0
            // 
            this.ResultState0.Location = new System.Drawing.Point(15, 25);
            this.ResultState0.MaxLength = 16;
            this.ResultState0.Name = "ResultState0";
            this.ResultState0.ReadOnly = true;
            this.ResultState0.Size = new System.Drawing.Size(207, 20);
            this.ResultState0.TabIndex = 88;
            this.ResultState0.TabStop = false;
            // 
            // MotionsSequenceInput
            // 
            this.MotionsSequenceInput.Location = new System.Drawing.Point(15, 107);
            this.MotionsSequenceInput.MaxLength = 128;
            this.MotionsSequenceInput.Name = "MotionsSequenceInput";
            this.MotionsSequenceInput.Size = new System.Drawing.Size(776, 20);
            this.MotionsSequenceInput.TabIndex = 92;
            this.MotionsSequenceInput.TextChanged += new System.EventHandler(this.MotionsSequenceInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Motions:";
            // 
            // PhysicalButton
            // 
            this.PhysicalButton.Location = new System.Drawing.Point(15, 133);
            this.PhysicalButton.Name = "PhysicalButton";
            this.PhysicalButton.Size = new System.Drawing.Size(75, 23);
            this.PhysicalButton.TabIndex = 94;
            this.PhysicalButton.Text = "(0) Physical";
            this.PhysicalButton.UseVisualStyleBackColor = true;
            this.PhysicalButton.Click += new System.EventHandler(this.PhysicalButton_Click);
            // 
            // SpecialButton
            // 
            this.SpecialButton.Location = new System.Drawing.Point(96, 133);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(75, 23);
            this.SpecialButton.TabIndex = 95;
            this.SpecialButton.Text = "(1) Special";
            this.SpecialButton.UseVisualStyleBackColor = true;
            this.SpecialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(15, 191);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(156, 23);
            this.CancelButton.TabIndex = 96;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 225);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Seed Finder";
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
        private System.Windows.Forms.Button CancelButton;
    }
}