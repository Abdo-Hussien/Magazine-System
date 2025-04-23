using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using Magazine_System.ErrorHandler;

namespace Magazine_System
{
    internal class Context
    {

        private readonly string CONNECTION_STR = GetConnectionString("MainDb");

        private OracleConnection Connection { get; set; }
        public OracleCommand Command { get; set; }

        public OracleDataAdapter Adapter { get; set; }
        public OracleCommandBuilder Builder { get; set; }

        public Context()
        {
            Connection = new OracleConnection(CONNECTION_STR);
        }

        private static string GetConnectionString(string name)
        {
            var config = new ExeConfigurationFileMap();
            config.ExeConfigFilename = "db.config";
            Configuration cfg = ConfigurationManager.OpenMappedExeConfiguration(config, ConfigurationUserLevel.None);

            //foreach (ConnectionStringSettings cs in cfg.ConnectionStrings.ConnectionStrings)
            //{
            //    Console.WriteLine($"Name: {cs.Name}, ConnectionString: {cs.ConnectionString}");
            //}

            return cfg.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }


        private void OpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (OracleException ex)
            {
                throw new DatabaseException(ex.Message);
            }
        }

        public void CloseConnection()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        private void CreateCommand(string Text, List<OracleParameter> Parameters = null, CommandType Type = CommandType.Text)
        {
            Command = new OracleCommand(Text, Connection);
            Command.CommandType = Type;
            if (Parameters != null)
            {
                foreach (var param in Parameters)
                {
                    Command.Parameters.Add(param);
                }
            }
        }
        public void ExecuteCrud(string Text, List<OracleParameter> Parameters = null)
        {
            OpenConnection();
            CreateCommand(Text, Parameters, CommandType.Text);
            try
            {
                Command.ExecuteNonQuery();
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

        public object ExecuteScalar(string text, List<OracleParameter> parameters = null)
        {
            OpenConnection();
            CreateCommand(text, parameters, CommandType.Text);
            try
            {
                return Command.ExecuteScalar() ?? 0;
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public OracleDataReader ExecuteSelect(string Text, List<OracleParameter> Parameters = null)
        {
            OpenConnection();
            CreateCommand(Text, Parameters, CommandType.Text);
            try
            {
                OracleDataReader dr = Command.ExecuteReader();
                return dr;
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        
        public DataSet ExecuteDisconnectedMode(string Text, DataSet ds, List<OracleParameter> Parameters = null)
        {
            OpenConnection();
            CreateCommand(Text, Parameters);
            Adapter = new OracleDataAdapter(Command);
            ds = new DataSet();
            Adapter.Fill(ds);
            CloseConnection();
            return ds;
        }


    }
    internal enum ExecuteMethod
    {
        ExecuteNonQuery,
        ExecuteScalar,
        ExecuteReader
    }
}
