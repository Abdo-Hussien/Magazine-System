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
    internal static class Context
    {

        private readonly static string CONNECTION_STR = GetConnectionString("MainDb");

        public static OracleConnection Connection { get; set; } = new OracleConnection(CONNECTION_STR);
        public static OracleCommand Command { get; set; }

        public static OracleDataAdapter Adapter { get; set; }
        public static OracleCommandBuilder Builder { get; set; }


        public static string GetConnectionString(string name)
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


        public static void OpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception caught!");
                Console.WriteLine("Message: " + ex.Message);
                throw new DatabaseException("General error: " + ex.Message);
            }
            //catch (OracleException ex)
            //{
            //    throw new DatabaseException(ex.Message);
            //}
        }

        public static void CloseConnection()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        private static void CreateCommand(string Text, List<OracleParameter> Parameters = null, CommandType Type = CommandType.Text)
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
        public static void ExecuteCrud(string Text, List<OracleParameter> Parameters = null)
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

        public static object ExecuteScalar(string text, List<OracleParameter> parameters = null)
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

        // Doesn't close the connection
        public static OracleDataReader ExecuteSelect(string Text, List<OracleParameter> Parameters = null, CommandType commandType = CommandType.Text)
        {
            OpenConnection();
            CreateCommand(Text, Parameters, commandType);
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

        public static DataSet ExecuteDisconnectedMode(string Text, DataSet ds, List<OracleParameter> Parameters = null)
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
    //internal enum ExecuteMethod
    //{
    //    ExecuteNonQuery,
    //    ExecuteScalar,
    //    ExecuteReader
    //}
}
