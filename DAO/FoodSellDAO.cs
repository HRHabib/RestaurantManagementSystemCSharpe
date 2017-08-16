using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    class FoodSellDAO
    {
        Connector connector = new Connector();

        public DataSet getFoodSell()
        {
            connector.sqlConnection.Open();
            string query = "select * from tbl_FoodSell";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }

        public void clearFoodSell()
        {
            connector.sqlConnection.Open();
            string query = " delete from tbl_FoodSell";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }
        
    }
}
