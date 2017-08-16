using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    class Connector
    {
        public string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=RMSdb;Integrated Security=True";

        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataAdapter sqlAdaper;
        public DataSet dataSet;
        public DataTable dataTable;

        public Connector()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
    }
}
