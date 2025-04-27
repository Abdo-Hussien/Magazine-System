using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Magazine_System
{
    public partial class ReportsForm : Form
    {
        User_Subscriptions userSubscriptions_report;
        User_sub_no_param userSubscriptions_no_param_report;
        Show_Authors showAuthors_report;
        magazine_subscriptions GroupByAuthors_report;
        bool HideComponents;
        public ReportsForm(bool HideComponents = false)
        {
            InitializeComponent();
            this.HideComponents = HideComponents;
            if (HideComponents)
            {

                magTitleFilteringPanel.Hide();
                usernameFilteringPanel.Hide();
                GroupByAuthorsBtn.Hide();
                ShowAuthorsBtn.Hide();
                GenerateBtnReport.Hide();
                userSubscriptions_no_param_report = new User_sub_no_param();
                userSubscriptions_no_param_report.SetParameterValue(0, SessionStorage.CurrentUser.Id);
                crystalReportViewer.ReportSource = userSubscriptions_no_param_report;
            }
            else
            {
                magTitleFilteringPanel.Show();
                usernameFilteringPanel.Show();
                GroupByAuthorsBtn.Show();
                ShowAuthorsBtn.Show();
                GenerateBtnReport.Show();
                userSubscriptions_report = new User_Subscriptions();
                showAuthors_report = new Show_Authors();
                GroupByAuthors_report = new magazine_subscriptions();
            }

        }

        private void GenerateBtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HideComponents)
                {
                    userSubscriptions_report.SetParameterValue(0, magazineFilteringField.Text);
                    userSubscriptions_report.SetParameterValue(1, usernameFilteringField.Text);

                    crystalReportViewer.ReportSource = userSubscriptions_report;
                }
                // Refresh the report
                crystalReportViewer.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message);
            }

        }

        private void ShowAuthorsBtn_Click(object sender, EventArgs e)
        {
            crystalReportViewer.ReportSource = showAuthors_report;
            crystalReportViewer.Refresh();
        }

        private void GroupByAuthorsBtn_Click(object sender, EventArgs e)
        {
            crystalReportViewer.ReportSource = GroupByAuthors_report;
            crystalReportViewer.Refresh();
        }
    }

}
