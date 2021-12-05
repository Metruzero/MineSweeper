namespace CS350MineSweeper
{
    partial class HighScoreForm
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
            this.scoreTabControl = new System.Windows.Forms.TabControl();
            this.easyTab = new System.Windows.Forms.TabPage();
            this.mediumTab = new System.Windows.Forms.TabPage();
            this.hardTab = new System.Windows.Forms.TabPage();
            this.easyDataGridView = new System.Windows.Forms.DataGridView();
            this.mediumDataGridView = new System.Windows.Forms.DataGridView();
            this.hardDataGridView = new System.Windows.Forms.DataGridView();
            this.easyPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreTabControl.SuspendLayout();
            this.easyTab.SuspendLayout();
            this.mediumTab.SuspendLayout();
            this.hardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.easyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTabControl
            // 
            this.scoreTabControl.Controls.Add(this.easyTab);
            this.scoreTabControl.Controls.Add(this.mediumTab);
            this.scoreTabControl.Controls.Add(this.hardTab);
            this.scoreTabControl.Location = new System.Drawing.Point(12, 12);
            this.scoreTabControl.Name = "scoreTabControl";
            this.scoreTabControl.SelectedIndex = 0;
            this.scoreTabControl.Size = new System.Drawing.Size(307, 226);
            this.scoreTabControl.TabIndex = 1;
            // 
            // easyTab
            // 
            this.easyTab.Controls.Add(this.easyDataGridView);
            this.easyTab.Location = new System.Drawing.Point(4, 22);
            this.easyTab.Name = "easyTab";
            this.easyTab.Padding = new System.Windows.Forms.Padding(3);
            this.easyTab.Size = new System.Drawing.Size(299, 200);
            this.easyTab.TabIndex = 0;
            this.easyTab.Text = "Easy";
            this.easyTab.UseVisualStyleBackColor = true;
            // 
            // mediumTab
            // 
            this.mediumTab.Controls.Add(this.mediumDataGridView);
            this.mediumTab.Location = new System.Drawing.Point(4, 22);
            this.mediumTab.Name = "mediumTab";
            this.mediumTab.Padding = new System.Windows.Forms.Padding(3);
            this.mediumTab.Size = new System.Drawing.Size(299, 200);
            this.mediumTab.TabIndex = 1;
            this.mediumTab.Text = "Medium";
            this.mediumTab.UseVisualStyleBackColor = true;
            // 
            // hardTab
            // 
            this.hardTab.Controls.Add(this.hardDataGridView);
            this.hardTab.Location = new System.Drawing.Point(4, 22);
            this.hardTab.Name = "hardTab";
            this.hardTab.Size = new System.Drawing.Size(299, 200);
            this.hardTab.TabIndex = 2;
            this.hardTab.Text = "Hard";
            this.hardTab.UseVisualStyleBackColor = true;
            // 
            // easyDataGridView
            // 
            this.easyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.easyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.easyPlace,
            this.easyName,
            this.easyTime});
            this.easyDataGridView.Location = new System.Drawing.Point(6, 6);
            this.easyDataGridView.Name = "easyDataGridView";
            this.easyDataGridView.RowHeadersVisible = false;
            this.easyDataGridView.Size = new System.Drawing.Size(287, 188);
            this.easyDataGridView.TabIndex = 0;
            // 
            // mediumDataGridView
            // 
            this.mediumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mediumDataGridView.Location = new System.Drawing.Point(6, 6);
            this.mediumDataGridView.Name = "mediumDataGridView";
            this.mediumDataGridView.RowHeadersVisible = false;
            this.mediumDataGridView.Size = new System.Drawing.Size(287, 188);
            this.mediumDataGridView.TabIndex = 1;
            // 
            // hardDataGridView
            // 
            this.hardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hardDataGridView.Location = new System.Drawing.Point(6, 6);
            this.hardDataGridView.Name = "hardDataGridView";
            this.hardDataGridView.RowHeadersVisible = false;
            this.hardDataGridView.Size = new System.Drawing.Size(287, 188);
            this.hardDataGridView.TabIndex = 1;
            // 
            // easyPlace
            // 
            this.easyPlace.HeaderText = "Place";
            this.easyPlace.Name = "easyPlace";
            this.easyPlace.Width = 50;
            // 
            // easyName
            // 
            this.easyName.HeaderText = "Name";
            this.easyName.Name = "easyName";
            this.easyName.Width = 163;
            // 
            // easyTime
            // 
            this.easyTime.HeaderText = "Time";
            this.easyTime.Name = "easyTime";
            this.easyTime.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Place";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 163;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Place";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 163;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreTabControl);
            this.Name = "HighScoreForm";
            this.Text = "High Scores";
            this.scoreTabControl.ResumeLayout(false);
            this.easyTab.ResumeLayout(false);
            this.mediumTab.ResumeLayout(false);
            this.hardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.easyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl scoreTabControl;
        private System.Windows.Forms.TabPage easyTab;
        private System.Windows.Forms.TabPage mediumTab;
        private System.Windows.Forms.TabPage hardTab;
        private System.Windows.Forms.DataGridView easyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn easyPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn easyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn easyTime;
        private System.Windows.Forms.DataGridView mediumDataGridView;
        private System.Windows.Forms.DataGridView hardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}