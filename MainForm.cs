using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Magazine_System.ErrorHandler;

namespace Magazine_System
{
    public partial class Mag_Store_App : Form
    {
        Context context;
        DataSet Dataset1;
        DataSet Dataset2;

        public Mag_Store_App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new Context();

            LogInBtn.Size = new Size(249, LogInBtn.Size.Height);

            LogOutBtn.Hide();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void GoToLogIn_Click(object sender, EventArgs e)
        {
            SignUpPanel.Hide();
            LogInPanel.Show();
        }

        private void GoToSignUp_Click(object sender, EventArgs e)
        {
            LogInPanel.Hide();
            SignUpPanel.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (UsernameBoxSignUp.Text == "" || EmailBoxSignUp.Text == "" || PasswordBoxSignUp.Text == "" || GenderComboSignUp.SelectedIndex == -1)
                {
                    throw new MissingValuesException();
                }

                decimal numOfEmailsFound = (decimal)context.ExecuteScalar("SELECT COUNT(*) FROM T_Users WHERE email = :email", new List<OracleParameter>
            {
                new OracleParameter(":email", EmailBoxSignUp.Text.ToLower())
            });

                if (numOfEmailsFound > 0)
                {
                    throw new DatabaseException("Email already exists..");
                }

                ValidateUserInfo(EmailBoxSignUp.Text, PasswordBoxSignUp.Text);

                context.ExecuteCrud(@"INSERT INTO T_Users 
                                (username, email, password, gender, created_at) 
                                VALUES (:name, :email, :pass, :gender, :created_at)
                                ",
                    new List<OracleParameter>
                    {
                    new OracleParameter(":name", UsernameBoxSignUp.Text),
                    new OracleParameter(":email",  EmailBoxSignUp.Text.ToLower()),
                    new OracleParameter(":pass", PasswordBoxSignUp.Text),
                    new OracleParameter(":gender", GenderComboSignUp.SelectedIndex == 0 ? 'M' : 'F'),
                    new OracleParameter(":created_at", OracleDbType.Date, DateTime.Now, ParameterDirection.Input)
                    }
                );

                MessageBox.Show($"User {UsernameBoxSignUp.Text} Created, Log in to start your journey!", "Signup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ErrorHandler.ErrorHandler) { }
        }

        private void ValidateUserInfo(string email, string password)
        {
            Regex emailRegex = new Regex(@"^[^\@\s]+\@[^\@\s]+\.[^\@\s]+$");
            Regex passwordRegex = new Regex(@"^[a-zA-Z\d]{8,}$");

            if (!emailRegex.IsMatch(email))
            {
                throw new ValidationException("Invalid email format");
            }
            //if (!passwordRegex.IsMatch(password))
            //{
            //   throw new ValidationException("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number");
            //}
        }


        private void LogInBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (EmailBoxLogIn.Text == "" || PasswordBoxLogIn.Text == "")
                {
                    throw new MissingValuesException();
                }
                if (SessionStorage.AuthToken.Length > 0)
                {
                    // If the user is already logged in, we can skip the login process and just show a message
                    MessageBox.Show($"You are already logged in as {SessionStorage.Username}, Try Logging out then Log in with the new credentials.", "Aleady Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ValidateUserInfo(EmailBoxLogIn.Text, PasswordBoxLogIn.Text);

                OracleDataReader dr = context.ExecuteSelect("SELECT user_id, username FROM T_Users WHERE email = :email AND password = :pass", new List<OracleParameter>
                {
                    new OracleParameter(":email", EmailBoxLogIn.Text.ToLower()),
                    new OracleParameter(":pass", PasswordBoxLogIn.Text)
                });

                if (!dr.Read())
                {
                    context.CloseConnection();
                    throw new DatabaseException("Credentials not found.");
                }
                Console.WriteLine(dr[0]);

                // Create Token Here
                SessionStorage.SetToken();
                int userId = Convert.ToInt32(dr[0]);
                // Read the username
                SessionStorage.Username = (string)dr[1];
                context.CloseConnection();

                LogInBtn.Size = new Size(110, LogInBtn.Size.Height);

                LogOutBtn.Show();

                MessageBox.Show($"Logged into {SessionStorage.Username}'s Account !", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ErrorHandler.ErrorHandler) { }
        }

        private void ApplyUsersBtnAdmin_Click(object sender, EventArgs e)
        {
            context.Builder = new OracleCommandBuilder(context.Adapter);
            context.Adapter.Update(Dataset1.Tables[0]);
            MessageBox.Show("User table has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyMagazinesBtnAdmin_Click(object sender, EventArgs e)
        {
            context.Builder = new OracleCommandBuilder(context.Adapter);
            context.Adapter.Update(Dataset2.Tables[0]);
            MessageBox.Show("Magazine table has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == AdminTab)
            {
                if (SessionStorage.Username != "admin")
                {
                    e.Cancel = true;
                    MessageBox.Show("You are not an admin, please contact the admin to gain access.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Dataset1 = context.ExecuteDisconnectedMode("select * from t_users", Dataset1);
                UsersGrid.DataSource = Dataset1.Tables[0];

                Dataset2 = context.ExecuteDisconnectedMode("select * from t_magazines", Dataset2);
                MagazinesGrid.DataSource = Dataset2.Tables[0];
            }
            if (e.TabPage == DashboardTab && SessionStorage.AuthToken.Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("You are not logged in, please log in to access the dashboard.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogInBtn.Size = new Size(249, LogInBtn.Size.Height);

            LogOutBtn.Hide();
            SessionStorage.DeleteCreds();
            MessageBox.Show("Logged out successfully!");

        }
    }
}
