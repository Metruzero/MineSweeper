namespace CS350MineSweeper
{
    partial class CustomDifficultyForm
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
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.mineTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.mineLabel = new System.Windows.Forms.Label();
            this.ErrorOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(120, 60);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Text = "10";
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(120, 103);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Text = "10";
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // mineTextBox
            // 
            this.mineTextBox.Location = new System.Drawing.Point(120, 149);
            this.mineTextBox.Name = "mineTextBox";
            this.mineTextBox.Size = new System.Drawing.Size(100, 20);
            this.mineTextBox.TabIndex = 2;
            this.mineTextBox.Text = "10";
            this.mineTextBox.TextChanged += new System.EventHandler(this.mineTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(98, 200);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(46, 63);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(65, 13);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width(8-30):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(43, 106);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(68, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height(8-30):";
            // 
            // mineLabel
            // 
            this.mineLabel.AutoSize = true;
            this.mineLabel.Location = new System.Drawing.Point(24, 152);
            this.mineLabel.Name = "mineLabel";
            this.mineLabel.Size = new System.Drawing.Size(90, 13);
            this.mineLabel.TabIndex = 6;
            this.mineLabel.Text = "Mine count(1-99):";
            // 
            // ErrorOutput
            // 
            this.ErrorOutput.AutoSize = true;
            this.ErrorOutput.ForeColor = System.Drawing.Color.Red;
            this.ErrorOutput.Location = new System.Drawing.Point(95, 179);
            this.ErrorOutput.Name = "ErrorOutput";
            this.ErrorOutput.Size = new System.Drawing.Size(0, 13);
            this.ErrorOutput.TabIndex = 7;
            // 
            // CustomDifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 262);
            this.Controls.Add(this.ErrorOutput);
            this.Controls.Add(this.mineLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.mineTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Name = "CustomDifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox mineTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label mineLabel;
        private System.Windows.Forms.Label ErrorOutput;
    }
}