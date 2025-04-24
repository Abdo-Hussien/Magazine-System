namespace Magazine_System
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
            this.components = new System.ComponentModel.Container();
            this.FormTabControl = new System.Windows.Forms.TabControl();
            this.ProfileTab = new System.Windows.Forms.TabPage();
            this.ProfileTableEditor = new System.Windows.Forms.Panel();
            this.table2 = new System.Windows.Forms.TableLayoutPanel();
            this.GenderComboProfile = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.UsernameBoxProfile = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.EmailBoxProfile = new System.Windows.Forms.TextBox();
            this.PasswordBoxProfile = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateProfileBtn = new System.Windows.Forms.Button();
            this.DiscardUpdateProfileBtn = new System.Windows.Forms.Button();
            this.ProfileTableViewer = new System.Windows.Forms.Panel();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.UpdatedAtValue = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CreatedAtValue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.genderValue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.passwordValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LogOutProfileBtn = new System.Windows.Forms.Button();
            this.OpenUpdateProfileBtn = new System.Windows.Forms.Button();
            this.AuthTab = new System.Windows.Forms.TabPage();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
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
            this.FormTabControl.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            this.ProfileTableEditor.SuspendLayout();
            this.table2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ProfileTableViewer.SuspendLayout();
            this.table1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.AuthTab.SuspendLayout();
            this.LogInPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.DashboardTab.SuspendLayout();
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
            this.FormTabControl.Controls.Add(this.ProfileTab);
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
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.ProfileTableEditor);
            this.ProfileTab.Controls.Add(this.ProfileTableViewer);
            this.ProfileTab.Location = new System.Drawing.Point(4, 25);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Size = new System.Drawing.Size(1088, 474);
            this.ProfileTab.TabIndex = 3;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
            // 
            // ProfileTableEditor
            // 
            this.ProfileTableEditor.AutoSize = true;
            this.ProfileTableEditor.Controls.Add(this.table2);
            this.ProfileTableEditor.Controls.Add(this.panel3);
            this.ProfileTableEditor.Location = new System.Drawing.Point(12, 60);
            this.ProfileTableEditor.Name = "ProfileTableEditor";
            this.ProfileTableEditor.Size = new System.Drawing.Size(441, 359);
            this.ProfileTableEditor.TabIndex = 15;
            // 
            // table2
            // 
            this.table2.ColumnCount = 2;
            this.table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.82456F));
            this.table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.17544F));
            this.table2.Controls.Add(this.GenderComboProfile, 1, 3);
            this.table2.Controls.Add(this.label21, 0, 3);
            this.table2.Controls.Add(this.label24, 0, 0);
            this.table2.Controls.Add(this.UsernameBoxProfile, 1, 0);
            this.table2.Controls.Add(this.label26, 0, 1);
            this.table2.Controls.Add(this.label25, 0, 2);
            this.table2.Controls.Add(this.EmailBoxProfile, 1, 1);
            this.table2.Controls.Add(this.PasswordBoxProfile, 1, 2);
            this.table2.Location = new System.Drawing.Point(9, 4);
            this.table2.Name = "table2";
            this.table2.RowCount = 4;
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table2.Size = new System.Drawing.Size(427, 290);
            this.table2.TabIndex = 11;
            // 
            // GenderComboProfile
            // 
            this.GenderComboProfile.AllowDrop = true;
            this.GenderComboProfile.FormattingEnabled = true;
            this.GenderComboProfile.IntegralHeight = false;
            this.GenderComboProfile.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboProfile.Location = new System.Drawing.Point(130, 218);
            this.GenderComboProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderComboProfile.Name = "GenderComboProfile";
            this.GenderComboProfile.Size = new System.Drawing.Size(294, 24);
            this.GenderComboProfile.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(5, 218);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 16);
            this.label21.TabIndex = 10;
            this.label21.Text = "Gender";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(5, 2);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 16);
            this.label24.TabIndex = 5;
            this.label24.Text = "Username";
            // 
            // UsernameBoxProfile
            // 
            this.UsernameBoxProfile.Location = new System.Drawing.Point(130, 2);
            this.UsernameBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameBoxProfile.Name = "UsernameBoxProfile";
            this.UsernameBoxProfile.Size = new System.Drawing.Size(294, 22);
            this.UsernameBoxProfile.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(5, 74);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 16);
            this.label26.TabIndex = 2;
            this.label26.Text = "Email";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(5, 146);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 16);
            this.label25.TabIndex = 3;
            this.label25.Text = "Password";
            // 
            // EmailBoxProfile
            // 
            this.EmailBoxProfile.Location = new System.Drawing.Point(130, 74);
            this.EmailBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailBoxProfile.Name = "EmailBoxProfile";
            this.EmailBoxProfile.Size = new System.Drawing.Size(294, 22);
            this.EmailBoxProfile.TabIndex = 0;
            // 
            // PasswordBoxProfile
            // 
            this.PasswordBoxProfile.Location = new System.Drawing.Point(130, 146);
            this.PasswordBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBoxProfile.Name = "PasswordBoxProfile";
            this.PasswordBoxProfile.Size = new System.Drawing.Size(294, 22);
            this.PasswordBoxProfile.TabIndex = 1;
            this.PasswordBoxProfile.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.UpdateProfileBtn);
            this.panel3.Controls.Add(this.DiscardUpdateProfileBtn);
            this.panel3.Location = new System.Drawing.Point(9, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 46);
            this.panel3.TabIndex = 10;
            // 
            // UpdateProfileBtn
            // 
            this.UpdateProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UpdateProfileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateProfileBtn.Location = new System.Drawing.Point(132, 3);
            this.UpdateProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateProfileBtn.Name = "UpdateProfileBtn";
            this.UpdateProfileBtn.Size = new System.Drawing.Size(135, 41);
            this.UpdateProfileBtn.TabIndex = 6;
            this.UpdateProfileBtn.Text = "Update Profile";
            this.UpdateProfileBtn.UseVisualStyleBackColor = false;
            this.UpdateProfileBtn.Click += new System.EventHandler(this.UpdateProfileBtn_Click);
            // 
            // DiscardUpdateProfileBtn
            // 
            this.DiscardUpdateProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DiscardUpdateProfileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DiscardUpdateProfileBtn.Location = new System.Drawing.Point(4, 3);
            this.DiscardUpdateProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiscardUpdateProfileBtn.Name = "DiscardUpdateProfileBtn";
            this.DiscardUpdateProfileBtn.Size = new System.Drawing.Size(122, 41);
            this.DiscardUpdateProfileBtn.TabIndex = 11;
            this.DiscardUpdateProfileBtn.Text = "Discard";
            this.DiscardUpdateProfileBtn.UseVisualStyleBackColor = false;
            this.DiscardUpdateProfileBtn.Click += new System.EventHandler(this.DiscardUpdateProfileBtn_Click);
            // 
            // ProfileTableViewer
            // 
            this.ProfileTableViewer.AutoSize = true;
            this.ProfileTableViewer.Controls.Add(this.table1);
            this.ProfileTableViewer.Controls.Add(this.panel4);
            this.ProfileTableViewer.Location = new System.Drawing.Point(12, 60);
            this.ProfileTableViewer.Name = "ProfileTableViewer";
            this.ProfileTableViewer.Size = new System.Drawing.Size(438, 359);
            this.ProfileTableViewer.TabIndex = 14;
            // 
            // table1
            // 
            this.table1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.table1.AutoScroll = true;
            this.table1.ColumnCount = 2;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.75366F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.24634F));
            this.table1.Controls.Add(this.label22, 0, 5);
            this.table1.Controls.Add(this.UpdatedAtValue, 1, 5);
            this.table1.Controls.Add(this.label19, 0, 4);
            this.table1.Controls.Add(this.CreatedAtValue, 1, 4);
            this.table1.Controls.Add(this.label17, 0, 3);
            this.table1.Controls.Add(this.genderValue, 1, 3);
            this.table1.Controls.Add(this.label15, 0, 2);
            this.table1.Controls.Add(this.passwordValue, 1, 2);
            this.table1.Controls.Add(this.label13, 0, 1);
            this.table1.Controls.Add(this.emailValue, 1, 1);
            this.table1.Controls.Add(this.label11, 0, 0);
            this.table1.Controls.Add(this.usernameValue, 1, 0);
            this.table1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.table1.Location = new System.Drawing.Point(8, 4);
            this.table1.Name = "table1";
            this.table1.RowCount = 6;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table1.Size = new System.Drawing.Size(427, 290);
            this.table1.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 240);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Last updated at:";
            // 
            // UpdatedAtValue
            // 
            this.UpdatedAtValue.AutoSize = true;
            this.UpdatedAtValue.Location = new System.Drawing.Point(155, 240);
            this.UpdatedAtValue.Name = "UpdatedAtValue";
            this.UpdatedAtValue.Size = new System.Drawing.Size(40, 16);
            this.UpdatedAtValue.TabIndex = 12;
            this.UpdatedAtValue.Text = "value";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "Account created at:";
            // 
            // CreatedAtValue
            // 
            this.CreatedAtValue.AutoSize = true;
            this.CreatedAtValue.Location = new System.Drawing.Point(155, 192);
            this.CreatedAtValue.Name = "CreatedAtValue";
            this.CreatedAtValue.Size = new System.Drawing.Size(40, 16);
            this.CreatedAtValue.TabIndex = 9;
            this.CreatedAtValue.Text = "value";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Gender:";
            // 
            // genderValue
            // 
            this.genderValue.AutoSize = true;
            this.genderValue.Location = new System.Drawing.Point(155, 144);
            this.genderValue.Name = "genderValue";
            this.genderValue.Size = new System.Drawing.Size(40, 16);
            this.genderValue.TabIndex = 7;
            this.genderValue.Text = "value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Password:";
            // 
            // passwordValue
            // 
            this.passwordValue.AutoSize = true;
            this.passwordValue.Location = new System.Drawing.Point(155, 96);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.Size = new System.Drawing.Size(40, 16);
            this.passwordValue.TabIndex = 5;
            this.passwordValue.Text = "value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Email:";
            // 
            // emailValue
            // 
            this.emailValue.AutoSize = true;
            this.emailValue.Location = new System.Drawing.Point(155, 48);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(40, 16);
            this.emailValue.TabIndex = 3;
            this.emailValue.Text = "value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Username:";
            // 
            // usernameValue
            // 
            this.usernameValue.AutoSize = true;
            this.usernameValue.Location = new System.Drawing.Point(155, 0);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(40, 16);
            this.usernameValue.TabIndex = 1;
            this.usernameValue.Text = "value";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.LogOutProfileBtn);
            this.panel4.Controls.Add(this.OpenUpdateProfileBtn);
            this.panel4.Location = new System.Drawing.Point(8, 306);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 46);
            this.panel4.TabIndex = 13;
            // 
            // LogOutProfileBtn
            // 
            this.LogOutProfileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOutProfileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LogOutProfileBtn.Location = new System.Drawing.Point(3, 3);
            this.LogOutProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutProfileBtn.Name = "LogOutProfileBtn";
            this.LogOutProfileBtn.Size = new System.Drawing.Size(123, 41);
            this.LogOutProfileBtn.TabIndex = 10;
            this.LogOutProfileBtn.Text = "Log Out";
            this.LogOutProfileBtn.UseVisualStyleBackColor = false;
            this.LogOutProfileBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // OpenUpdateProfileBtn
            // 
            this.OpenUpdateProfileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OpenUpdateProfileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.OpenUpdateProfileBtn.Location = new System.Drawing.Point(132, 3);
            this.OpenUpdateProfileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenUpdateProfileBtn.Name = "OpenUpdateProfileBtn";
            this.OpenUpdateProfileBtn.Size = new System.Drawing.Size(135, 41);
            this.OpenUpdateProfileBtn.TabIndex = 6;
            this.OpenUpdateProfileBtn.Text = "Update Profile...";
            this.OpenUpdateProfileBtn.UseVisualStyleBackColor = false;
            this.OpenUpdateProfileBtn.Click += new System.EventHandler(this.OpenUpdateProfileBtn_Click);
            // 
            // AuthTab
            // 
            this.AuthTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.LogInPanel.Location = new System.Drawing.Point(13, 18);
            this.LogInPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(351, 322);
            this.LogInPanel.TabIndex = 10;
            this.LogInPanel.Visible = false;
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
            // GoToSignUp
            // 
            this.GoToSignUp.AutoSize = true;
            this.GoToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.GoToSignUp.Location = new System.Drawing.Point(73, 288);
            this.GoToSignUp.Name = "GoToSignUp";
            this.GoToSignUp.Size = new System.Drawing.Size(200, 16);
            this.GoToSignUp.TabIndex = 8;
            this.GoToSignUp.Text = "Don\'t Have an account? Sign Up";
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
            this.GoToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.GoToLogIn.Location = new System.Drawing.Point(94, 288);
            this.GoToLogIn.Name = "GoToLogIn";
            this.GoToLogIn.Size = new System.Drawing.Size(154, 16);
            this.GoToLogIn.TabIndex = 8;
            this.GoToLogIn.Text = "Have an account? Log In";
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
            this.DashboardTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DashboardTab.Controls.Add(this.panel5);
            this.DashboardTab.Controls.Add(this.label12);
            this.DashboardTab.Location = new System.Drawing.Point(4, 25);
            this.DashboardTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardTab.Size = new System.Drawing.Size(1088, 474);
            this.DashboardTab.TabIndex = 1;
            this.DashboardTab.Text = "Home";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(1, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1100, 1);
            this.panel5.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Welcome to Mag Store!";
            // 
            // AdminTab
            // 
            this.AdminTab.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1120, 527);
            this.Controls.Add(this.FormTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Mag Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormTabControl.ResumeLayout(false);
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            this.ProfileTableEditor.ResumeLayout(false);
            this.table2.ResumeLayout(false);
            this.table2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ProfileTableViewer.ResumeLayout(false);
            this.table1.ResumeLayout(false);
            this.table1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.AuthTab.ResumeLayout(false);
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.DashboardTab.ResumeLayout(false);
            this.DashboardTab.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel table1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label CreatedAtValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label genderValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label passwordValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label emailValue;
        private System.Windows.Forms.Label usernameValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox GenderComboProfile;
        private System.Windows.Forms.Button UpdateProfileBtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox UsernameBoxProfile;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox PasswordBoxProfile;
        private System.Windows.Forms.TextBox EmailBoxProfile;
        private System.Windows.Forms.TableLayoutPanel table2;
        private System.Windows.Forms.Button DiscardUpdateProfileBtn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label UpdatedAtValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button OpenUpdateProfileBtn;
        private System.Windows.Forms.Button LogOutProfileBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel ProfileTableViewer;
        private System.Windows.Forms.Panel ProfileTableEditor;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.TabControl FormTabControl;
    }
}

