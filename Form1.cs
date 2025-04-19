using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Magazine_System
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.ExecuteCrud("INSERT INTO magazines (magazine_id, magazine_name, magazine_price) VALUES (:id, :name, :price)",
                new List<OracleParameter>
                {
                    new OracleParameter(":id", 1),
                    new OracleParameter(":name", "Test Magazine"),
                    new OracleParameter(":price", 9.99)
                });
        }
    }
}
