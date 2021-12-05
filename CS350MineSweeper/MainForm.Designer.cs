namespace CS350MineSweeper
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.mineCountPanel = new System.Windows.Forms.Panel();
            this.mineCountLabel = new System.Windows.Forms.Label();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagPictureBox = new System.Windows.Forms.PictureBox();
            this.timerPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.mineCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem});
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.scoresToolStripMenuItem.Text = "Configuration";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.customToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.easyToolStripMenuItem.Text = "Easy (10x10) 10 Mines";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mediumToolStripMenuItem.Text = "Medium (16x16) 40 Mines";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.hardToolStripMenuItem.Text = "Hard (30x16) 99 Mines";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.customToolStripMenuItem.Text = "Custom...";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // timePanel
            // 
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Controls.Add(this.timerPictureBox);
            this.timePanel.Location = new System.Drawing.Point(12, 30);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(85, 35);
            this.timePanel.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(35, 6);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(16, 25);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "0";
            this.timeLabel.UseCompatibleTextRendering = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(136, 30);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(35, 35);
            this.resetButton.TabIndex = 3;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // mineCountPanel
            // 
            this.mineCountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mineCountPanel.Controls.Add(this.mineCountLabel);
            this.mineCountPanel.Controls.Add(this.flagPictureBox);
            this.mineCountPanel.Location = new System.Drawing.Point(374, 30);
            this.mineCountPanel.Name = "mineCountPanel";
            this.mineCountPanel.Size = new System.Drawing.Size(85, 35);
            this.mineCountPanel.TabIndex = 4;
            // 
            // mineCountLabel
            // 
            this.mineCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineCountLabel.Location = new System.Drawing.Point(13, 6);
            this.mineCountLabel.Name = "mineCountLabel";
            this.mineCountLabel.Size = new System.Drawing.Size(36, 23);
            this.mineCountLabel.TabIndex = 3;
            this.mineCountLabel.Text = "0";
            this.mineCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.mineCountLabel.UseCompatibleTextRendering = true;
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
            // 
            // flagPictureBox
            // 
            this.flagPictureBox.Location = new System.Drawing.Point(55, 3);
            this.flagPictureBox.Name = "flagPictureBox";
            this.flagPictureBox.Size = new System.Drawing.Size(25, 25);
            this.flagPictureBox.TabIndex = 2;
            this.flagPictureBox.TabStop = false;
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.timerPictureBox.Name = "timerPictureBox";
            this.timerPictureBox.Size = new System.Drawing.Size(25, 25);
            this.timerPictureBox.TabIndex = 0;
            this.timerPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.mineCountPanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.mineCountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flagPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.PictureBox timerPictureBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel mineCountPanel;
        private System.Windows.Forms.Label mineCountLabel;
        private System.Windows.Forms.PictureBox flagPictureBox;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
    }
}

