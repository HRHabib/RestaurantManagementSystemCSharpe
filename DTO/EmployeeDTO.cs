using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    class EmployeeDTO
    {
        private int Emp_id, Emp_age, Emp_salary;
        private string Emp_name, Emp_password, Emp_email, Emp_dutyTime, Emp_overtime, Emp_designation;

        public EmployeeDTO(string Emp_name, int Emp_age, int Emp_salary, string Emp_password, string Emp_email, string Emp_dutyTime, string Emp_designation)
        {
            this.Emp_age = Emp_age;
            this.Emp_name = Emp_name;
            this.Emp_salary = Emp_salary;
            this.Emp_password = Emp_password;
            this.Emp_email = Emp_email;
            this.Emp_dutyTime = Emp_dutyTime;
            this.Emp_designation = Emp_designation;
        }

        public EmployeeDTO(int Emp_id, int Emp_salary, string Emp_dutyTime, string Emp_overtime, string Emp_designation)
        {
            this.Emp_id = Emp_id;
            this.Emp_salary = Emp_salary;
            this.Emp_dutyTime = Emp_dutyTime;
            this.Emp_overtime = Emp_overtime;
            this.Emp_designation = Emp_designation;
        }

        public EmployeeDTO(string Emp_email, string Emp_password)
        {
            this.Emp_email = Emp_email;
            this.Emp_password = Emp_password;
        }

        public int EMPLOYEE_ID
        {
            get { return Emp_id; }
            set { Emp_id = value; }
        }

        public int EMPLOYEE_AGE
        {
            get { return Emp_age; }
            set { Emp_age = value; }
        }

        public string EMPLOYEE_NAME
        {
            get { return Emp_name; }
            set { Emp_name = value; }
        }
        public int EMPLOYEE_SALARY
        {
            get { return Emp_salary; }
            set { Emp_salary = value; }
        }
        public string EMPLOYEE_PASSWORD
        {
            get { return Emp_password; }
            set { Emp_password = value; }
        }
        public string EMPLOYEE_EMAIL
        {
            get { return Emp_email; }
            set { Emp_email = value; }
        }
        public string EMPLOYEE_DUTYTIME
        {
            get { return Emp_dutyTime; }
            set { Emp_dutyTime = value; }
        }
        public string EMPLOYEE_OVERTIME
        {
            get { return Emp_overtime; }
            set { Emp_overtime = value; }
        }
        public string EMPLOYEE_DESIGNATION
        {
            get { return Emp_designation; }
            set { Emp_designation = value; }
        }
    }
}
