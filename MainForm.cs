using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Magazine_System
{
    public partial class MainForm : Form
    {
        DataSet Dataset1;
        DataSet Dataset2;

        public MainForm()
        {
            InitializeComponent();
            InitProfileEvents();
            InitAuthEvents();
            InitAdminEvents();
            InitHomeEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LogInBtn.Size = new Size(249, LogInBtn.Size.Height);

            LogOutBtn.Hide();
            FormTabControl.TabPages.Remove(ProfileTab);
            FormTabControl.TabPages.Remove(AdminTab);

            SignUpPanel.Hide();
            LogInPanel.Show();
        }

        private void FormTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == AdminTab)
            {
                Dataset1 = Context.ExecuteDisconnectedMode("select * from t_users", Dataset1);
                UsersGrid.DataSource = Dataset1.Tables[0];
                UsersGrid.Columns["user_id"].Visible = false;

                UsersGrid.Columns["Password"].Visible = false;

                Dataset2 = Context.ExecuteDisconnectedMode("select * from t_magazines", Dataset2);
                MagazinesGrid.DataSource = Dataset2.Tables[0];
                MagazinesGrid.Columns[0].Visible = false;
                MagazinesGrid.Columns[1].Visible = false;
                MagazinesGrid.Columns[MagazinesGrid.Columns.Count - 1].Visible = false;


            }
            if (e.TabPage == HomeTab && SessionStorage.AuthToken.Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("You are not logged in, please log in to access the dashboard.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.TabPage == ProfileTab)
            {
                ProfileTableViewer.Show();
                ProfileTableEditor.Hide();

                SetUserProfileValues();
            }
            if (e.TabPage == HomeTab)
            {
                magazines_ids = FetchMagazinesIds();
                FetchOneMagazine(currentMagazineIndex, magazines_ids);
            }

        }

        private void OpenReportsFormBtn_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            // Insert new subscription record of user_id = SessionStorage.CurrentUser.Id
            // and magazine_id = magazines_ids[currentMagazineIndex]
            // start date = dateTime.Now
            // subscribe_until = DateTime.Now.AddMonths(1)
            var subscribeUntil = DateTime.Now.AddMonths(1);
            Context.ExecuteCrud("INSERT INTO T_Subscriptions (user_id, magazine_id, start_date, subscribe_until) VALUES (:user_id, :magazine_id, :start_date, :subscribe_until)", new List<OracleParameter>
            {
                new OracleParameter(":user_id", SessionStorage.CurrentUser.Id),
                new OracleParameter(":magazine_id", magazines_ids[currentMagazineIndex]),
                new OracleParameter(":start_date", DateTime.Now),
                new OracleParameter(":subscribe_until", subscribeUntil)
            });
            MessageBox.Show($"You have successfully subscribed to the magazine until {subscribeUntil}!\nEnjoy Reading :)", "Subscription Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
