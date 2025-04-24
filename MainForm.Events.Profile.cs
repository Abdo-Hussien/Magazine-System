using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
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
            OpenUpdateProfileBtn.Click += OpenUpdateProfileBtn_Click;
            UpdateProfileBtn.Click += UpdateProfileBtn_Click;
            DiscardUpdateProfileBtn.Click += DiscardUpdateProfileBtn_Click;
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

    }
}

