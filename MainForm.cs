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
            if (UsernameBoxSignUp.Text == "" || EmailBoxSignUp.Text == "" || PasswordBoxSignUp.Text == "" || GenderComboSignUp.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            decimal numOfEmailsFound = (decimal)context.ExecuteScalar("SELECT COUNT(*) FROM T_Users WHERE email = :email", new List<OracleParameter>
            {
                new OracleParameter(":email", EmailBoxSignUp.Text)
            });

            if (numOfEmailsFound > 0)
            {
                MessageBox.Show("Email already exists");
                return;
            }

            ValidateUserInfo(EmailBoxSignUp.Text, PasswordBoxSignUp.Text);

            context.ExecuteCrud(@"INSERT INTO T_Users 
                                (username, email, password, gender, created_at) 
                                VALUES (:name, :email, :pass, :gender, :created_at)
                                ",
                new List<OracleParameter>
                {
                    new OracleParameter(":name", UsernameBoxSignUp.Text),
                    new OracleParameter(":email",  EmailBoxSignUp.Text),
                    new OracleParameter(":pass", PasswordBoxSignUp.Text),
                    new OracleParameter(":gender", GenderComboSignUp.SelectedIndex == 0 ? 'M' : 'F'),
                    new OracleParameter(":created_at", OracleDbType.Date, DateTime.Now, ParameterDirection.Input)
                }
            );

            MessageBox.Show($"User {UsernameBoxSignUp.Text} Created !");
        }

        private void ValidateUserInfo(string email, string password)
        {
            Regex emailRegex = new Regex(@"^[^\@\s]+\@[^\@\s]+\.[^\@\s]+$");
            Regex passwordRegex = new Regex(@"^([a-zA-Z\d]{8,})$");

            if (!emailRegex.IsMatch(email))
            {
                //MessageBox.Show("Invalid email format");
                throw new Exception("Invalid email format");
            }
            //if (!passwordRegex.IsMatch(password))
            //{
            //    throw new Exception("Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number");
            //}
        }
        

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (EmailBoxLogIn.Text == "" || PasswordBoxLogIn.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            decimal isUserFound = (decimal)context.ExecuteScalar("SELECT COUNT(*) FROM T_Users WHERE email = :email AND password = :pass", new List<OracleParameter>
            {
                new OracleParameter(":email", EmailBoxLogIn.Text),
                new OracleParameter(":pass", PasswordBoxLogIn.Text)
            });

            if (isUserFound <= 0)
            {
                MessageBox.Show("Credentials not found, try signing up.");
                return;
            }

            ValidateUserInfo(EmailBoxLogIn.Text, PasswordBoxLogIn.Text);

            // Create Token Here
            MessageBox.Show($"Logged into {EmailBoxLogIn.Text}'s Account !");
        }

        private void AdminTab_Click(object sender, EventArgs e)
        {
            Dataset1 = context.ExecuteDisconnectedMode("select * from t_users", Dataset1);
            UsersGrid.DataSource = Dataset1.Tables[0];
            
            Dataset2 = context.ExecuteDisconnectedMode("select * from t_magazines", Dataset2);
            MagazinesGrid.DataSource = Dataset2.Tables[0];
            
        }

        private void ApplyUsersBtnAdmin_Click(object sender, EventArgs e)
        {
            context.Builder = new OracleCommandBuilder(context.Adapter);
            context.Adapter.Update(Dataset1.Tables[0]);
            MessageBox.Show("User table has been updated!");
        }

        private void ApplyMagazinesBtnAdmin_Click(object sender, EventArgs e)
        {
            context.Builder = new OracleCommandBuilder(context.Adapter);
            context.Adapter.Update(Dataset2.Tables[0]);
            MessageBox.Show("Magazine table has been updated!");
        }
    }
}
