using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    class DatabaseManager
    {
        #region Properties
        private string _connectionString = @"server=localhost;database=cadsystem;user=root;password=Mlpzaq123!;";
        private MySqlConnection _DBConnection = null;
        private MySqlDataReader _DBReader = null;
        private MySqlCommand _DBCommand = null;
        #endregion
        #region DatabaseHandling
        //Starts the DB connection
        public void Start()
        {
            try
            {
                _DBConnection = new MySqlConnection(_connectionString);
                _DBConnection.Open();
                _DBCommand = new MySqlCommand();
                _DBCommand.Connection = _DBConnection;
                Debug.WriteLine("Connection successful");
            }
            catch (MySqlException mse_var)
            {
                //Console.WriteLine(mse_var);
                Debug.WriteLine(mse_var.ToString());
            }
        }
        //This is for return queries such as SELECT,etc
        public string ReadString(string DataQuery)
        {
            _DBCommand.CommandText = DataQuery;
            _DBReader = _DBCommand.ExecuteReader();
            string Result;

            while (_DBReader.Read())
            {
                for (int i = 0; i < _DBReader.FieldCount; i++)
                {
                    //Debug.WriteLine(_DBReader.GetString(i));
                    Result = _DBReader.GetString(i);
                    _DBReader.Close();
                    return Result;
                }
                // return Result;
                // Debug.WriteLine(_DBReader.FieldCount.ToString());
                //  Debug.WriteLine(_DBReader.GetInt32(0) + ", " + _DBReader.GetString(1) + ", " + _DBReader.GetString(2) + ", " + _DBReader.GetString(3) + ", " + _DBReader.GetString(4));

            }
            return "No data";

        }
        //This is for UPDATE, CREATE, UPDATE queries
        public void Query(string DataQuery)
        {
            _DBCommand.CommandText = DataQuery;
            _DBCommand.Prepare();

            _DBCommand.ExecuteNonQuery();
        }
        //This destroys the connection to the MySQL server
        public void CloseConnection()
        {
            if (_DBConnection != null) _DBConnection.Close();
            if (_DBReader != null) _DBReader.Close();
        }
    }
    #endregion
}
