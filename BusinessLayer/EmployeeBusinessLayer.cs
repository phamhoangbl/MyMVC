using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

                List<Employee> employess = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.ID = Convert.ToInt32(rdr["EmployeeId"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.DateOfBirth = DateTime.Parse(rdr["DateOfBirth"].ToString());
                        employee.City = rdr["City"].ToString();
                        employess.Add(employee);
                    }
                }
                return employess;
            }
        }

        public void AddEmployee(Employee emp)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;

            List<Employee> employess = new List<Employee>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = emp.Name;
                cmd.Parameters.Add(paraName);

                SqlParameter paraGender = new SqlParameter();
                paraGender.ParameterName = "@Gender";
                paraGender.Value = emp.Gender;
                cmd.Parameters.Add(paraGender);

                SqlParameter paraCity = new SqlParameter();
                paraCity.ParameterName = "@City";
                paraCity.Value = emp.City;
                cmd.Parameters.Add(paraCity);

                SqlParameter paraDateOfBirth = new SqlParameter();
                paraDateOfBirth.ParameterName = "@DateOfBirth";
                paraDateOfBirth.Value = emp.DateOfBirth;
                cmd.Parameters.Add(paraDateOfBirth);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        } 
    }
}
