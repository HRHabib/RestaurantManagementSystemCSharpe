using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    class ProfitDAO
    {
        Connector connector = new Connector();

        public DataSet getProfits()
        {
            connector.sqlConnection.Open();
            string query = "select * from tbl_Profit";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }
    }
}
