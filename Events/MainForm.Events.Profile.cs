using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_System
{
    public partial class MainForm
    {
        private void InitProfileEvents()
        {

        }

        private void OpenUpdateProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileTableEditor.Show();
            ProfileTableViewer.Hide();
        }

        private void DiscardUpdateProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileTableViewer.Show();
            ProfileTableEditor.Hide();
        }

        private void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            ProfileTableViewer.Show();
            ProfileTableEditor.Hide();

            ValidateUserInfo(EmailBoxProfile.Text, PasswordBoxProfile.Text);

            DateTime updatedAt = DateTime.Now;
            // Update the profile information in the database
            Context.ExecuteCrud("UPDATE T_Users Set username = :username, email = :email, password = :pass, gender = :gender, updated_at = :updatedAt WHERE user_id = :id", new List<OracleParameter>
            {
                new OracleParameter(":username", UsernameBoxProfile.Text),
                new OracleParameter(":email", EmailBoxProfile.Text),
                new OracleParameter(":pass", PasswordBoxProfile.Text),
                new OracleParameter(":gender", GenderComboProfile.SelectedIndex == 0 ? 'M' : 'F'),
                new OracleParameter(":updatedAt", updatedAt),
                new OracleParameter(":id", SessionStorage.CurrentUser.Id)
            });

            // Set the updated values to the user object
            SessionStorage.CurrentUser.Name = UsernameBoxProfile.Text;
            SessionStorage.CurrentUser.Email = EmailBoxProfile.Text;
            SessionStorage.CurrentUser.Password = PasswordBoxProfile.Text;
            SessionStorage.CurrentUser.Gender = GenderComboProfile.SelectedIndex == 0 ? "Male" : "Female";
            SessionStorage.CurrentUser.UpdatedAt = updatedAt;

            SetUserProfileValues();
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogInBtn.Size = new Size(249, LogInBtn.Size.Height);

            LogOutBtn.Hide();
            FormTabControl.TabPages.Insert(1, AuthTab);
            FormTabControl.TabPages.Remove(ProfileTab);
            FormTabControl.TabPages.Remove(AdminTab);
            ActiveForm.Text = "Mag Store";
            SessionStorage.DeleteCreds();
            MessageBox.Show("Logged out successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void SetUserProfileValues()
        {

            usernameValue.Text = SessionStorage.CurrentUser.Name;
            emailValue.Text = SessionStorage.CurrentUser.Email;
            passwordValue.Text = new string('•', SessionStorage.CurrentUser.Password.Length);
            genderValue.Text = SessionStorage.CurrentUser.Gender.Trim() == "M" ? "Male" : "Female";
            CreatedAtValue.Text = SessionStorage.CurrentUser.CreatedAt.ToString("f");
            UpdatedAtValue.Text = SessionStorage.CurrentUser.UpdatedAt.ToString("f");

            UsernameBoxProfile.Text = SessionStorage.CurrentUser.Name;
            EmailBoxProfile.Text = SessionStorage.CurrentUser.Email;
            PasswordBoxProfile.Text = SessionStorage.CurrentUser.Password;
            if (SessionStorage.CurrentUser.Gender.Trim() == "M")
                GenderComboProfile.SelectedIndex = 0;
            else
                GenderComboProfile.SelectedIndex = 1;
        }
    }
}

