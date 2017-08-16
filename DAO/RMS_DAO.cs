using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    
    class RMS_DAO
    {
        //private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=RMSdb;Integrated Security=True";

        //private SqlConnection sqlConnection;
        //private SqlCommand sqlCommand;
        //private SqlDataAdapter sqlAdaper;
        //private DataSet dataSet;
        
           
        //public RMS_DAO()
        //{
        //    sqlConnection = new SqlConnection(connectionString);
        //}

        Connector connector = new Connector();

        public DataSet getManager()
        {
            connector.sqlConnection.Open();
            string query = "select * from RMS_Manager";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }
    }
}
