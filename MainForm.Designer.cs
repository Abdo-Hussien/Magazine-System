namespace Magazine_System
{
    partial class Mag_Store_App
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
            this.FormTabControl = new System.Windows.Forms.TabControl();
            this.AuthTab = new System.Windows.Forms.TabPage();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.GoToSignUp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmailBoxLogIn = new System.Windows.Forms.TextBox();
            this.PasswordBoxLogIn = new System.Windows.Forms.TextBox();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderComboSignUp = new System.Windows.Forms.ComboBox();
            this.GoToLogIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameBoxSignUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordBoxSignUp = new System.Windows.Forms.TextBox();
            this.EmailBoxSignUp = new System.Windows.Forms.TextBox();
            this.DashboardTab = new System.Windows.Forms.TabPage();
            this.AdminTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ApplyMagazinesBtnAdmin = new System.Windows.Forms.Button();
            this.MagazinesGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ApplyUsersBtnAdmin = new System.Windows.Forms.Button();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.FormTabControl.SuspendLayout();
            this.AuthTab.SuspendLayout();
            this.LogInPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.AdminTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagazinesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTabControl
            // 
            this.FormTabControl.Controls.Add(this.AuthTab);
            this.FormTabControl.Controls.Add(this.DashboardTab);
            this.FormTabControl.Controls.Add(this.AdminTab);
            this.FormTabControl.Location = new System.Drawing.Point(12, 12);
            this.FormTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FormTabControl.Name = "FormTabControl";
            this.FormTabControl.SelectedIndex = 0;
            this.FormTabControl.Size = new System.Drawing.Size(1096, 503);
            this.FormTabControl.TabIndex = 0;
            this.FormTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.FormTabControl_Selecting);
            // 
            // AuthTab
            // 
            this.AuthTab.BackColor = System.Drawing.SystemColors.Control;
            this.AuthTab.Controls.Add(this.LogInPanel);
            this.AuthTab.Controls.Add(this.SignUpPanel);
            this.AuthTab.Location = new System.Drawing.Point(4, 25);
            this.AuthTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthTab.Name = "AuthTab";
            this.AuthTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthTab.Size = new System.Drawing.Size(1088, 474);
            this.AuthTab.TabIndex = 0;
            this.AuthTab.Text = "Authentication";
            // 
            // LogInPanel
            // 
            this.LogInPanel.Controls.Add(this.LogOutBtn);
            this.LogInPanel.Controls.Add(this.GoToSignUp);
            this.LogInPanel.Controls.Add(this.label7);
            this.LogInPanel.Controls.Add(this.LogInBtn);
            this.LogInPanel.Controls.Add(this.label8);
            this.LogInPanel.Controls.Add(this.label10);
            this.LogInPanel.Controls.Add(this.EmailBoxLogIn);
            this.LogInPanel.Controls.Add(this.PasswordBoxLogIn);
            this.LogInPanel.Location = new System.Drawing.Point(13, 20);
            this.LogInPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(351, 322);
            this.LogInPanel.TabIndex = 10;
            this.LogInPanel.Visible = false;
            // 
            // GoToSignUp
            // 
            this.GoToSignUp.AutoSize = true;
            this.GoToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToSignUp.Location = new System.Drawing.Point(136, 290);
            this.GoToSignUp.Name = "GoToSignUp";
            this.GoToSignUp.Size = new System.Drawing.Size(75, 20);
            this.GoToSignUp.TabIndex = 8;
            this.GoToSignUp.Text = "Sign Up";
            this.GoToSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoToSignUp.Click += new System.EventHandler(this.GoToSignUp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Or";
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LogInBtn.Location = new System.Drawing.Point(11, 140);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(153, 78);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(8, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email";
            // 
            // EmailBoxLogIn
            // 
            this.EmailBoxLogIn.Location = new System.Drawing.Point(11, 25);
            this.EmailBoxLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailBoxLogIn.Name = "EmailBoxLogIn";
            this.EmailBoxLogIn.Size = new System.Drawing.Size(329, 22);
            this.EmailBoxLogIn.TabIndex = 0;
            // 
            // PasswordBoxLogIn
            // 
            this.PasswordBoxLogIn.Location = new System.Drawing.Point(11, 100);
            this.PasswordBoxLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBoxLogIn.Name = "PasswordBoxLogIn";
            this.PasswordBoxLogIn.Size = new System.Drawing.Size(329, 22);
            this.PasswordBoxLogIn.TabIndex = 4;
            this.PasswordBoxLogIn.UseSystemPasswordChar = true;
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.label5);
            this.SignUpPanel.Controls.Add(this.GenderComboSignUp);
            this.SignUpPanel.Controls.Add(this.GoToLogIn);
            this.SignUpPanel.Controls.Add(this.label4);
            this.SignUpPanel.Controls.Add(this.SignUpBtn);
            this.SignUpPanel.Controls.Add(this.label3);
            this.SignUpPanel.Controls.Add(this.UsernameBoxSignUp);
            this.SignUpPanel.Controls.Add(this.label2);
            this.SignUpPanel.Controls.Add(this.label1);
            this.SignUpPanel.Controls.Add(this.PasswordBoxSignUp);
            this.SignUpPanel.Controls.Add(this.EmailBoxSignUp);
            this.SignUpPanel.Location = new System.Drawing.Point(13, 18);
            this.SignUpPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(351, 322);
            this.SignUpPanel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(216, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // GenderComboSignUp
            // 
            this.GenderComboSignUp.AllowDrop = true;
            this.GenderComboSignUp.FormattingEnabled = true;
            this.GenderComboSignUp.IntegralHeight = false;
            this.GenderComboSignUp.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboSignUp.Location = new System.Drawing.Point(219, 100);
            this.GenderComboSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboSignUp.Name = "GenderComboSignUp";
            this.GenderComboSignUp.Size = new System.Drawing.Size(121, 24);
            this.GenderComboSignUp.TabIndex = 9;
            // 
            // GoToLogIn
            // 
            this.GoToLogIn.AutoSize = true;
            this.GoToLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToLogIn.Location = new System.Drawing.Point(143, 290);
            this.GoToLogIn.Name = "GoToLogIn";
            this.GoToLogIn.Size = new System.Drawing.Size(61, 20);
            this.GoToLogIn.TabIndex = 8;
            this.GoToLogIn.Text = "Log In";
            this.GoToLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GoToLogIn.Click += new System.EventHandler(this.GoToLogIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Or";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SignUpBtn.Location = new System.Drawing.Point(11, 140);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(329, 78);
            this.SignUpBtn.TabIndex = 6;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // UsernameBoxSignUp
            // 
            this.UsernameBoxSignUp.Location = new System.Drawing.Point(11, 25);
            this.UsernameBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameBoxSignUp.Name = "UsernameBoxSignUp";
            this.UsernameBoxSignUp.Size = new System.Drawing.Size(119, 22);
            this.UsernameBoxSignUp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(141, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // PasswordBoxSignUp
            // 
            this.PasswordBoxSignUp.Location = new System.Drawing.Point(11, 101);
            this.PasswordBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBoxSignUp.Name = "PasswordBoxSignUp";
            this.PasswordBoxSignUp.Size = new System.Drawing.Size(193, 22);
            this.PasswordBoxSignUp.TabIndex = 1;
            this.PasswordBoxSignUp.UseSystemPasswordChar = true;
            // 
            // EmailBoxSignUp
            // 
            this.EmailBoxSignUp.Location = new System.Drawing.Point(144, 25);
            this.EmailBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailBoxSignUp.Name = "EmailBoxSignUp";
            this.EmailBoxSignUp.Size = new System.Drawing.Size(196, 22);
            this.EmailBoxSignUp.TabIndex = 0;
            // 
            // DashboardTab
            // 
            this.DashboardTab.BackColor = System.Drawing.SystemColors.Control;
            this.DashboardTab.Location = new System.Drawing.Point(4, 25);
            this.DashboardTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardTab.Size = new System.Drawing.Size(1088, 474);
            this.DashboardTab.TabIndex = 1;
            this.DashboardTab.Text = "Dashboard";
            // 
            // AdminTab
            // 
            this.AdminTab.BackColor = System.Drawing.SystemColors.Control;
            this.AdminTab.Controls.Add(this.panel2);
            this.AdminTab.Controls.Add(this.panel1);
            this.AdminTab.Location = new System.Drawing.Point(4, 25);
            this.AdminTab.Name = "AdminTab";
            this.AdminTab.Size = new System.Drawing.Size(1088, 474);
            this.AdminTab.TabIndex = 2;
            this.AdminTab.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ApplyMagazinesBtnAdmin);
            this.panel2.Controls.Add(this.MagazinesGrid);
            this.panel2.Location = new System.Drawing.Point(593, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 406);
            this.panel2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Magazines Table";
            // 
            // ApplyMagazinesBtnAdmin
            // 
            this.ApplyMagazinesBtnAdmin.Location = new System.Drawing.Point(12, 356);
            this.ApplyMagazinesBtnAdmin.Name = "ApplyMagazinesBtnAdmin";
            this.ApplyMagazinesBtnAdmin.Size = new System.Drawing.Size(455, 37);
            this.ApplyMagazinesBtnAdmin.TabIndex = 1;
            this.ApplyMagazinesBtnAdmin.Text = "Save Changes";
            this.ApplyMagazinesBtnAdmin.UseVisualStyleBackColor = true;
            this.ApplyMagazinesBtnAdmin.Click += new System.EventHandler(this.ApplyMagazinesBtnAdmin_Click);
            // 
            // MagazinesGrid
            // 
            this.MagazinesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MagazinesGrid.Location = new System.Drawing.Point(12, 33);
            this.MagazinesGrid.Name = "MagazinesGrid";
            this.MagazinesGrid.RowHeadersWidth = 51;
            this.MagazinesGrid.RowTemplate.Height = 24;
            this.MagazinesGrid.Size = new System.Drawing.Size(455, 317);
            this.MagazinesGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ApplyUsersBtnAdmin);
            this.panel1.Controls.Add(this.UsersGrid);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 406);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Users Table";
            // 
            // ApplyUsersBtnAdmin
            // 
            this.ApplyUsersBtnAdmin.Location = new System.Drawing.Point(12, 356);
            this.ApplyUsersBtnAdmin.Name = "ApplyUsersBtnAdmin";
            this.ApplyUsersBtnAdmin.Size = new System.Drawing.Size(455, 37);
            this.ApplyUsersBtnAdmin.TabIndex = 1;
            this.ApplyUsersBtnAdmin.Text = "Save Changes";
            this.ApplyUsersBtnAdmin.UseVisualStyleBackColor = true;
            this.ApplyUsersBtnAdmin.Click += new System.EventHandler(this.ApplyUsersBtnAdmin_Click);
            // 
            // UsersGrid
            // 
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(12, 33);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.RowHeadersWidth = 51;
            this.UsersGrid.RowTemplate.Height = 24;
            this.UsersGrid.Size = new System.Drawing.Size(455, 317);
            this.UsersGrid.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LogOutBtn.Location = new System.Drawing.Point(187, 140);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(153, 78);
            this.LogOutBtn.TabIndex = 9;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Mag_Store_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1120, 527);
            this.Controls.Add(this.FormTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mag_Store_App";
            this.Text = "Mag Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormTabControl.ResumeLayout(false);
            this.AuthTab.ResumeLayout(false);
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.AdminTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagazinesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FormTabControl;
        private System.Windows.Forms.TabPage AuthTab;
        private System.Windows.Forms.TabPage DashboardTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordBoxSignUp;
        private System.Windows.Forms.TextBox EmailBoxSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameBoxSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GoToLogIn;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Label GoToSignUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PasswordBoxLogIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EmailBoxLogIn;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.ComboBox GenderComboSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage AdminTab;
        private System.Windows.Forms.Button ApplyUsersBtnAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ApplyMagazinesBtnAdmin;
        private System.Windows.Forms.DataGridView MagazinesGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogOutBtn;
    }
}

