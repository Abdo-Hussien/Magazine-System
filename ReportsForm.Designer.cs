namespace Magazine_System
{
    partial class ReportsForm
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GenerateBtnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameFilteringPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameFilteringField = new System.Windows.Forms.TextBox();
            this.magTitleFilteringPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.magazineFilteringField = new System.Windows.Forms.TextBox();
            this.ShowAuthorsBtn = new System.Windows.Forms.Button();
            this.GroupByAuthorsBtn = new System.Windows.Forms.Button();
            this.usernameFilteringPanel.SuspendLayout();
            this.magTitleFilteringPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(12, 49);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1134, 512);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // GenerateBtnReport
            // 
            this.GenerateBtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GenerateBtnReport.Location = new System.Drawing.Point(1041, 9);
            this.GenerateBtnReport.Name = "GenerateBtnReport";
            this.GenerateBtnReport.Size = new System.Drawing.Size(105, 34);
            this.GenerateBtnReport.TabIndex = 1;
            this.GenerateBtnReport.Text = "Generate";
            this.GenerateBtnReport.UseVisualStyleBackColor = true;
            this.GenerateBtnReport.Click += new System.EventHandler(this.GenerateBtnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // usernameFilteringPanel
            // 
            this.usernameFilteringPanel.AutoSize = true;
            this.usernameFilteringPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usernameFilteringPanel.Controls.Add(this.panel1);
            this.usernameFilteringPanel.Controls.Add(this.label1);
            this.usernameFilteringPanel.Controls.Add(this.usernameFilteringField);
            this.usernameFilteringPanel.Location = new System.Drawing.Point(12, 12);
            this.usernameFilteringPanel.Name = "usernameFilteringPanel";
            this.usernameFilteringPanel.Size = new System.Drawing.Size(255, 31);
            this.usernameFilteringPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 5;
            // 
            // usernameFilteringField
            // 
            this.usernameFilteringField.Location = new System.Drawing.Point(84, 6);
            this.usernameFilteringField.Name = "usernameFilteringField";
            this.usernameFilteringField.Size = new System.Drawing.Size(168, 22);
            this.usernameFilteringField.TabIndex = 2;
            // 
            // magTitleFilteringPanel
            // 
            this.magTitleFilteringPanel.AutoSize = true;
            this.magTitleFilteringPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.magTitleFilteringPanel.Controls.Add(this.panel3);
            this.magTitleFilteringPanel.Controls.Add(this.label4);
            this.magTitleFilteringPanel.Controls.Add(this.magazineFilteringField);
            this.magTitleFilteringPanel.Location = new System.Drawing.Point(284, 12);
            this.magTitleFilteringPanel.Name = "magTitleFilteringPanel";
            this.magTitleFilteringPanel.Size = new System.Drawing.Size(299, 31);
            this.magTitleFilteringPanel.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Magazine Title";
            // 
            // magazineFilteringField
            // 
            this.magazineFilteringField.Location = new System.Drawing.Point(109, 6);
            this.magazineFilteringField.Name = "magazineFilteringField";
            this.magazineFilteringField.Size = new System.Drawing.Size(187, 22);
            this.magazineFilteringField.TabIndex = 2;
            // 
            // ShowAuthorsBtn
            // 
            this.ShowAuthorsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ShowAuthorsBtn.Location = new System.Drawing.Point(871, 9);
            this.ShowAuthorsBtn.Name = "ShowAuthorsBtn";
            this.ShowAuthorsBtn.Size = new System.Drawing.Size(164, 34);
            this.ShowAuthorsBtn.TabIndex = 7;
            this.ShowAuthorsBtn.Text = "Show All Authors";
            this.ShowAuthorsBtn.UseVisualStyleBackColor = true;
            this.ShowAuthorsBtn.Click += new System.EventHandler(this.ShowAuthorsBtn_Click);
            // 
            // GroupByAuthorsBtn
            // 
            this.GroupByAuthorsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GroupByAuthorsBtn.Location = new System.Drawing.Point(701, 9);
            this.GroupByAuthorsBtn.Name = "GroupByAuthorsBtn";
            this.GroupByAuthorsBtn.Size = new System.Drawing.Size(164, 34);
            this.GroupByAuthorsBtn.TabIndex = 8;
            this.GroupByAuthorsBtn.Text = "Group By Authors";
            this.GroupByAuthorsBtn.UseVisualStyleBackColor = true;
            this.GroupByAuthorsBtn.Click += new System.EventHandler(this.GroupByAuthorsBtn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 573);
            this.Controls.Add(this.GroupByAuthorsBtn);
            this.Controls.Add(this.ShowAuthorsBtn);
            this.Controls.Add(this.magTitleFilteringPanel);
            this.Controls.Add(this.usernameFilteringPanel);
            this.Controls.Add(this.GenerateBtnReport);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.usernameFilteringPanel.ResumeLayout(false);
            this.usernameFilteringPanel.PerformLayout();
            this.magTitleFilteringPanel.ResumeLayout(false);
            this.magTitleFilteringPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Button GenerateBtnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel usernameFilteringPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameFilteringField;
        private System.Windows.Forms.Panel magTitleFilteringPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox magazineFilteringField;
        private System.Windows.Forms.Button ShowAuthorsBtn;
        private System.Windows.Forms.Button GroupByAuthorsBtn;
    }
}