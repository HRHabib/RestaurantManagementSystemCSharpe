using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    class EmployeeDAO
    {
        

        Connector connector = new Connector();
        
        public DataSet getEmployees()
        {
            connector.sqlConnection.Open();
            string query = "select * from tbl_Emplyee";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }

        
        public DataSet GetEmployees()
        {
            connector.sqlConnection.Open();
            string query = "select Emp_name, Emp_salary from tbl_Emplyee";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlAdaper = new SqlDataAdapter(connector.sqlCommand);
            connector.dataSet = new DataSet();
            connector.sqlAdaper.Fill(connector.dataSet);
            connector.sqlConnection.Close();
            return connector.dataSet;
        }

        public void addEmployee(EmployeeDTO employeeDto)
        {
            connector.sqlConnection.Open();
            

            string query = " insert into tbl_Emplyee values ('"
                                                            + employeeDto.EMPLOYEE_NAME + "','"
                                                            + employeeDto.EMPLOYEE_PASSWORD + "','"
                                                            + employeeDto.EMPLOYEE_AGE + "','"
                                                            + employeeDto.EMPLOYEE_EMAIL + "','"
                                                            + employeeDto.EMPLOYEE_SALARY + "','"
                                                            + employeeDto.EMPLOYEE_DUTYTIME + "','"
                                                            + employeeDto.EMPLOYEE_DESIGNATION + "')";


            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }

        
        public void updateEmployee(EmployeeDTO employeeDto)
        {
            connector.sqlConnection.Open();
            string query = " update tbl_Emplyee set Emp_salary ='" + employeeDto.EMPLOYEE_SALARY + "', Emp_dutyTime = '" + employeeDto.EMPLOYEE_DUTYTIME + "', Emp_overtime = '" + employeeDto.EMPLOYEE_OVERTIME + "', Emp_designation = '" + employeeDto.EMPLOYEE_DESIGNATION + "' where Emp_id = '" + employeeDto.EMPLOYEE_ID + "'";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }

        /*public void loginEmployee(EmployeeDTO employeeDto)
        {
            sqlConnection.Open();
            //string query = " update tbl_Emplyee set Emp_salary ='" + employeeDto.EMPLOYEE_SALARY + "', Emp_dutyTime = '" + employeeDto.EMPLOYEE_DUTYTIME + "', Emp_designation = '" + employeeDto.EMPLOYEE_DESIGNATION + "' where Emp_id = '" + employeeDto.EMPLOYEE_ID + "'";
            string query = "select * from tbl_Emplyee where Emp_email = '" + employeeDto.EMPLOYEE_EMAIL + "'and Emp_password = '" + employeeDto.EMPLOYEE_PASSWORD + "'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            //DataTable datatable = new DataTable();
            //sqlAdaper.Fill(datatable);
            //if (datatable.Rows.Count == 1)
            //{
            //    
            //    FormEmployeeLogin objFormEmployeeLogin = new FormEmployeeLogin();
            //    objFormEmployeeLogin.Hide();
            //    
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Username or/and Password");
            //}
            sqlConnection.Close();
        }*/

        public void delEmployee(EmployeeDTO employeeDto)
        {
            connector.sqlConnection.Open();
            string query = " delete from tbl_Emplyee where Emp_id = '" + employeeDto.EMPLOYEE_ID + "'";
            connector.sqlCommand = new SqlCommand(query, connector.sqlConnection);
            connector.sqlCommand.ExecuteNonQuery();
            connector.sqlConnection.Close();
        }

    }
}
