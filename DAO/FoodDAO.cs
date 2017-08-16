using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    class FoodDAO
    {
        Connector connector = new Connector();
        
        public DataSet getFoods()
        {
            connector.sqlConnection.Open();
            string query = "select * from tbl_Food";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }

        public DataTable getBillFoods()
        {
            connector.sqlConnection.Open();
            string query = "select * from tbl_Food";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataTable = new DataTable();
            connector.sqlAdaper.Fill(connector.dataTable);
            connector.sqlConnection.Close();
            return connector.dataTable;
        }


        
        public void createFood(FoodDTO foodDto)
        {
            connector.sqlConnection.Open();
            string query = " insert into tbl_Food values ('" + foodDto.FOOD_ID + "','"
                                                            + foodDto.FOOD_NAME + "','"
                                                            + foodDto.FOOD_PRICE + "')";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }

        public void delFood(FoodDTO foodDto)
        {
            connector.sqlConnection.Open();
            string query = " delete from tbl_Food where Food_id = '" + foodDto.FOOD_ID + "'";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }

        public void updateFood(FoodDTO foodDto)
        {
            connector.sqlConnection.Open();
            string query = " update tbl_Food set Food_name ='" + foodDto.FOOD_NAME + "', Food_price = '" + foodDto.FOOD_PRICE + "' where Food_id = '" + foodDto.FOOD_ID + "'";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }

        public DataSet searchFoods(string query)
        {
            connector.sqlConnection.Open();
            //string query = "select * from tbl_Food";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }

        /*public DataSet getStock(int id)
        {
            connector.sqlConnection.Open();
            string query = "select * from tbl_Food where Food_id = '" + id + "'";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }*/

    }
}
