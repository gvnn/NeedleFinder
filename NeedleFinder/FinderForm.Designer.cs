namespace NeedleFinder
{
    partial class FinderForm
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
            this.HaystackLabel = new System.Windows.Forms.Label();
            this.HaystackTextBox = new System.Windows.Forms.TextBox();
            this.NeedleLabel = new System.Windows.Forms.Label();
            this.NeedleTextBox = new System.Windows.Forms.TextBox();
            this.MatchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchButton = new System.Windows.Forms.Button();
            this.MatchesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HaystackLabel
            // 
            this.HaystackLabel.AutoSize = true;
            this.HaystackLabel.Location = new System.Drawing.Point(25, 18);
            this.HaystackLabel.Name = "HaystackLabel";
            this.HaystackLabel.Size = new System.Drawing.Size(28, 13);
            this.HaystackLabel.TabIndex = 0;
            this.HaystackLabel.Text = "Text";
            // 
            // HaystackTextBox
            // 
            this.HaystackTextBox.Location = new System.Drawing.Point(59, 15);
            this.HaystackTextBox.Multiline = true;
            this.HaystackTextBox.Name = "HaystackTextBox";
            this.HaystackTextBox.Size = new System.Drawing.Size(249, 44);
            this.HaystackTextBox.TabIndex = 0;
            // 
            // NeedleLabel
            // 
            this.NeedleLabel.AutoSize = true;
            this.NeedleLabel.Location = new System.Drawing.Point(12, 68);
            this.NeedleLabel.Name = "NeedleLabel";
            this.NeedleLabel.Size = new System.Drawing.Size(43, 13);
            this.NeedleLabel.TabIndex = 0;
            this.NeedleLabel.Text = "Subtext";
            // 
            // NeedleTextBox
            // 
            this.NeedleTextBox.Location = new System.Drawing.Point(59, 65);
            this.NeedleTextBox.Multiline = true;
            this.NeedleTextBox.Name = "NeedleTextBox";
            this.NeedleTextBox.Size = new System.Drawing.Size(249, 46);
            this.NeedleTextBox.TabIndex = 1;
            // 
            // MatchCaseCheckBox
            // 
            this.MatchCaseCheckBox.AutoSize = true;
            this.MatchCaseCheckBox.Location = new System.Drawing.Point(140, 125);
            this.MatchCaseCheckBox.Name = "MatchCaseCheckBox";
            this.MatchCaseCheckBox.Size = new System.Drawing.Size(83, 17);
            this.MatchCaseCheckBox.TabIndex = 3;
            this.MatchCaseCheckBox.Text = "Ignore Case";
            this.MatchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchButton
            // 
            this.MatchButton.Location = new System.Drawing.Point(59, 121);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(75, 23);
            this.MatchButton.TabIndex = 2;
            this.MatchButton.Text = "Find";
            this.MatchButton.UseVisualStyleBackColor = true;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // MatchesTextBox
            // 
            this.MatchesTextBox.Location = new System.Drawing.Point(59, 157);
            this.MatchesTextBox.Multiline = true;
            this.MatchesTextBox.Name = "MatchesTextBox";
            this.MatchesTextBox.Size = new System.Drawing.Size(249, 67);
            this.MatchesTextBox.TabIndex = 100;
            // 
            // FinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 236);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.MatchCaseCheckBox);
            this.Controls.Add(this.MatchesTextBox);
            this.Controls.Add(this.NeedleTextBox);
            this.Controls.Add(this.NeedleLabel);
            this.Controls.Add(this.HaystackTextBox);
            this.Controls.Add(this.HaystackLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinderForm";
            this.Text = "Needle in a haystack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HaystackLabel;
        private System.Windows.Forms.TextBox HaystackTextBox;
        private System.Windows.Forms.Label NeedleLabel;
        private System.Windows.Forms.TextBox NeedleTextBox;
        private System.Windows.Forms.CheckBox MatchCaseCheckBox;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.TextBox MatchesTextBox;
    }
}

