using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Configuration;

using System.Xml;

namespace Magazine_System
{
    internal class Context
    {

        private readonly string CONNECTION_STR = GetConnectionString("MainDb");

        private OracleConnection Connection { get; set; }
        private OracleCommand Command { get; set; }

        public Context()
        {
            Connection = new OracleConnection(CONNECTION_STR);
        }

        private static string GetConnectionString(string name)
        {
            var config = new ExeConfigurationFileMap();
            config.ExeConfigFilename = "db.config";
            Configuration cfg = ConfigurationManager.OpenMappedExeConfiguration(config, ConfigurationUserLevel.None);

            foreach (ConnectionStringSettings cs in cfg.ConnectionStrings.ConnectionStrings)
            {
                Console.WriteLine($"Name: {cs.Name}, ConnectionString: {cs.ConnectionString}");
            }

            return cfg.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }


        private void OpenConnection()
        {
            try
            {
                this.Connection.Open();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return;
            }
        }

        private void CloseConnection()
        {
            if (this.Connection != null && this.Connection.State == ConnectionState.Open)
            {
                this.Connection.Close();
            }
        }

        private void CreateCommand(string Text, List<OracleParameter> Parameters = null, CommandType Type = CommandType.Text)
        {
            this.Command = new OracleCommand(Text, this.Connection);
            this.Command.CommandType = Type;
            if (Parameters != null)
            {
                foreach (var param in Parameters)
                {
                    this.Command.Parameters.Add(param);
                }
            }
        }
        public void ExecuteCrud(string Text, List<OracleParameter> Parameters = null)
        {
            OpenConnection();
            CreateCommand(Text, Parameters, CommandType.Text);
            try
            {
                //this.Command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void ExecuteSelect(string Text, ComboBox Component, List<OracleParameter> Parameters = null)
        {
            OpenConnection();
            CreateCommand(Text, Parameters, CommandType.Text);
            try
            {
                OracleDataReader dr = this.Command.ExecuteReader();
                while (dr.Read())
                {
                    Component.Items.Add(dr[0]);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }





    }
}
