using Magazine_System.ErrorHandler;
using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Magazine_System
{
    public partial class MainForm
    {
        private void InitAdminEvents()
        {
        }
        private void ApplyUsersBtnAdmin_Click(object sender, EventArgs e)
        {
            //usernameFilteringField;
            Context.Builder = new OracleCommandBuilder(Context.Adapter);
            Context.Adapter.Update(Dataset1.Tables[0]);
            MessageBox.Show("User table has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyMagazinesBtnAdmin_Click(object sender, EventArgs e)
        {
            //magazineFilteringField;
            Context.Builder = new OracleCommandBuilder(Context.Adapter);
            Context.Adapter.Update(Dataset2.Tables[0]);
            MessageBox.Show("Magazine table has been updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadUsers()
        {
            Dataset1 = Context.ExecuteDisconnectedMode("select * from t_users where username = :username", Dataset1, new List<OracleParameter>
            {
                new OracleParameter(":username", usernameFilteringField.Text)
            });
            UsersGrid.DataSource = Dataset1.Tables[0];

        }
        private void LoadMagazines()
        {
            Dataset2 = Context.ExecuteDisconnectedMode("select * from t_magazines where magazine_title = :mag_title", Dataset2, new List<OracleParameter>
            {
                new OracleParameter(":mag_title", magazineFilteringField.Text)
            });
            MagazinesGrid.DataSource = Dataset2.Tables[0];
        }

        private void LoadUsersAdmin_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadMagazinesAdmin_Click(object sender, EventArgs e)
        {
            LoadMagazines();
        }

    }
}
