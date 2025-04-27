using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_System
{
    partial class MainForm
    {
        public string baseImagePath = @"E:\Abdo-Projects\C#Projects\Software Engineering\Magazine System\Assets\Images\";
        private List<int> magazines_ids;
        private int currentMagazineIndex = 0;
        private void InitHomeEvents()
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentMagazineIndex < magazines_ids.Count - 1)
            {
                currentMagazineIndex++;
                FetchOneMagazine(currentMagazineIndex, magazines_ids);

                PreviousBtn.Enabled = true;

                NextBtn.Enabled = currentMagazineIndex < magazines_ids.Count - 1;
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (currentMagazineIndex > 0)
            {
                currentMagazineIndex--;
                FetchOneMagazine(currentMagazineIndex, magazines_ids);

                NextBtn.Enabled = true;

                PreviousBtn.Enabled = currentMagazineIndex > 0;
            }
        }

        private List<int> FetchMagazinesIds()
        {
            List<int> magazines_ids = new List<int>();
            OracleDataReader dr = Context.ExecuteSelect("FETCH_MAGAZINES_IDS", new List<OracleParameter> {
                    new OracleParameter(":mag_id", OracleDbType.RefCursor, ParameterDirection.Output)
                }, CommandType.StoredProcedure);
            while (dr.Read())
            {
                magazines_ids.Add((int)Convert.ToDecimal(dr[0]));
            }
            Context.CloseConnection();
            return magazines_ids;
        }

        private void FetchOneMagazine(int index, List<int> magazines_ids)
        {
            Context.OpenConnection();
            using (var cmd = new OracleCommand("Fetch_Magazine", Context.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new OracleParameter(":mag_id", OracleDbType.Int32, ParameterDirection.InputOutput) { Value = magazines_ids[index] });
                cmd.Parameters.Add(new OracleParameter(":mag_title", OracleDbType.Varchar2, 200) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new OracleParameter(":mag_price", OracleDbType.Decimal) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new OracleParameter(":mag_category", OracleDbType.Varchar2, 200) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new OracleParameter(":mag_createdAt", OracleDbType.Date) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new OracleParameter(":mag_updatedAt", OracleDbType.Date) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new OracleParameter(":mag_image_url", OracleDbType.Varchar2, 500) { Direction = ParameterDirection.Output });

                cmd.ExecuteNonQuery();

                // Now you can read output parameters
                MagazineTitleLabel.Text = cmd.Parameters[":mag_title"].Value?.ToString();
                MagazineCategoryLabel.Text = $"{cmd.Parameters[":mag_price"].Value.ToString()} L.E.";
                MagazinePriceLabel.Text = cmd.Parameters[":mag_category"].Value?.ToString();
                MagazineCreatedAtLabel.Text = ((Oracle.DataAccess.Types.OracleDate)cmd.Parameters[":mag_createdAt"].Value).Value.ToString("f");


                string filename = cmd.Parameters[":mag_image_url"].Value?.ToString();
                string fullPath = Path.Combine(baseImagePath, filename);

                if (File.Exists(fullPath))
                {
                    MagazineUrlImage.Image = Image.FromFile(fullPath);

                    //int size = Math.Min(MagazineUrlImage.Width, MagazineUrlImage.Height);
                    //MagazineUrlImage.Size = new Size(size, size);
                }
                else
                    MagazineUrlImage.Image = null;

                Context.CloseConnection();
            }


        }

        private void SubscriptionReportsBtn_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(HideComponents: true);
            reportsForm.ShowDialog();
        }
    }
}
