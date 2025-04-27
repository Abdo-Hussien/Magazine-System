using Magazine_System.ErrorHandler;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Magazine_System
{
    public partial class MainForm
    {
        private void InitAuthEvents()
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

                decimal numOfEmailsFound = (decimal)Context.ExecuteScalar("SELECT COUNT(*) FROM T_Users WHERE email = :email", new List<OracleParameter>
            {
                new OracleParameter(":email", EmailBoxSignUp.Text.ToLower())
            });

                if (numOfEmailsFound > 0)
                {
                    throw new DatabaseException("Email already exists..");
                }

                ValidateUserInfo(EmailBoxSignUp.Text, PasswordBoxSignUp.Text);

                Context.ExecuteCrud(@"INSERT INTO T_Users 
                                (username, email, password, gender, created_at, updated_at) 
                                VALUES (:name, :email, :pass, :gender, :created_at, :updated_at)
                                ",
                    new List<OracleParameter>
                    {
                    new OracleParameter(":name", UsernameBoxSignUp.Text),
                    new OracleParameter(":email",  EmailBoxSignUp.Text.ToLower()),
                    new OracleParameter(":pass", PasswordBoxSignUp.Text),
                    new OracleParameter(":gender", GenderComboSignUp.SelectedIndex == 0 ? 'M' : 'F'),
                    new OracleParameter(":created_at", OracleDbType.Date, DateTime.Now, ParameterDirection.Input),
                    new OracleParameter(":updated_at", OracleDbType.Date, DateTime.Now, ParameterDirection.Input)
                    }
                );
                GoToLogIn_Click(sender, e);
                MessageBox.Show($"User {UsernameBoxSignUp.Text} Created, Log in to start your journey!", "Signup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ErrorHandler.ErrorHandler) { }
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
                    MessageBox.Show($"You are already logged in as {SessionStorage.CurrentUser.Name}, Try Logging out then Log in with the new credentials.", "Aleady Logged In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ValidateUserInfo(EmailBoxLogIn.Text, PasswordBoxLogIn.Text);

                OracleDataReader dr = Context.ExecuteSelect("SELECT * FROM T_Users WHERE email = :email AND password = :pass", new List<OracleParameter>
                {
                    new OracleParameter(":email", EmailBoxLogIn.Text.ToLower()),
                    new OracleParameter(":pass", PasswordBoxLogIn.Text)
                });

                if (!dr.Read())
                {
                    Context.CloseConnection();
                    throw new DatabaseException("Credentials not found.");
                }
                //Console.WriteLine(dr[0]);

                // Create Token Here
                SessionStorage.SetToken();
                // Read the user

                DateTime CreatedAtDate = dr.IsDBNull(5) ? DateTime.MinValue : Convert.ToDateTime(dr[5]);
                DateTime UpdatedAtDate = dr.IsDBNull(6) ? DateTime.MinValue : Convert.ToDateTime(dr[6]);

                SessionStorage.CurrentUser = new User(Convert.ToInt32(dr[0]), (string)dr[1], (string)dr[2], (string)dr[3], (string)dr[4], CreatedAtDate, UpdatedAtDate, (string)dr[7]);
                Context.CloseConnection();


                ActiveForm.Text = $"Mag Store - {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(SessionStorage.CurrentUser.Name.ToLower())}";

                LogInBtn.Size = new Size(110, LogInBtn.Size.Height);

                LogOutBtn.Show();
                FormTabControl.TabPages.Insert(0, ProfileTab);
                FormTabControl.TabPages.Remove(AuthTab);
                // Use Role Based Access Control Later
                if (SessionStorage.CurrentUser.role == "admin")
                    FormTabControl.TabPages.Add(AdminTab);

                MessageBox.Show($"Logged into {SessionStorage.CurrentUser.Name}'s Account !", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ErrorHandler.ErrorHandler) { }
        }

        protected void ValidateUserInfo(string email, string password)
        {
            Regex emailRegex = new Regex(@"^[^\@\s]+\@[^\@\s]+\.[^\@\s]+$");
            Regex passwordRegex = new Regex(@"^[a-zA-Z\d]{8,}$");

            //if (!emailRegex.IsMatch(email))
            //{
            //    throw new ValidationException("Invalid email format");
            //}
            //if (!passwordRegex.IsMatch(password))
            //{
            //   throw new ValidationException("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number");
            //}
        }



    }
}
