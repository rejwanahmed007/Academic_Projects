using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TMS.ApplicationLayer;
using TMS.Data;
using TMS.Entity;
using TMS.Framework;

namespace TMS.Repository
{
    internal class UserRepo
    {
        internal bool SaveEmployeeInfo(Employee employee, string value)
        {
            try
            {
                
                if (value.ToString().Equals("change password"))
                {
                    string query5 = "update logininfo set password='" + employee.Password + "' where logininfo.email='" + employee.Email + "';";
                    int count5 = DataAccess.ExecuteQuery(query5);
                    if (count5 > 0)
                        return true;
                    else
                        return false;
                }
                else if (value.ToString().Equals("update"))
                {
                    string query3 = "update employeeinfo set  mobilenumber='" + employee.Mobile + "',address='" + employee.Address + "' where email='" + employee.Email + "';";
                    int count3 = DataAccess.ExecuteQuery(query3);
                    if (count3 > 0)
                        return true;
                    else
                        return false;
                }

                else
                    return false;
            }
            catch (Exception exception)
            {
                return false;
            }

        }

        internal bool SavePassengerInfo(UserEntity passenger,string value)
        {
            try
            {
                if (value.ToString().Equals("new"))
                {
                    string query1 = "insert into logininfo values ('" + passenger.Email + "','" + passenger.Password + "','Passenger');";
                    string query2 = "insert into passengerinfo values ('" + passenger.Name + "','" + passenger.Mobile + "','" + passenger.Email + "','" + passenger.Address + "');";
                    int count1 = DataAccess.ExecuteQuery(query1);
                    int count2 = DataAccess.ExecuteQuery(query2);
                    if (count1 > 0 && count2 > 0) { return true; }
                    else { return false; }
                }
                else if (value.ToString().Equals("change password"))
                {
                    string query5 = "update logininfo set password='" + passenger.Password + "' where logininfo.email='" + passenger.Email + "';";
                    int count5 = DataAccess.ExecuteQuery(query5);
                    if (count5 > 0)
                        return true;
                    else
                        return false;
                }
                else if (value.ToString().Equals("update"))
                {
                    string query3 = "update passengerinfo set  passengername='" + passenger.Name + "',mobilenumber='" + passenger.Mobile + "',address='" + passenger.Address + "' where email='" + passenger.Email + "';";
                    int count3 = DataAccess.ExecuteQuery(query3);
                    if (count3 > 0)
                        return true;
                    else
                        return false;
                }

                else
                    return false;
            }
            catch (Exception exception)
            {
                return false;
            }

        }
        internal List<UserEntity> GetAll()
        {
            var userList = new List<UserEntity>();
            try
            {
                string query1 = "select employeeid,password,usertype,employeename,mobilenumber,logininfo.email,address,designation,salary,hiredate,commission from logininfo,employeeinfo where logininfo.email=employeeinfo.email;";
                string query2 = "select passengerid,password,usertype,passengername,mobilenumber,logininfo.email,address from logininfo,passengerinfo where logininfo.email=passengerinfo.email;";
                var dt = DataAccess.GetDataTable(query1);
                int counter = 0;
                while (counter < dt.Rows.Count)
                {
                    UserEntity employee = ConvertToEmployee(dt.Rows[counter]);
                    userList.Add(employee);
                    counter++;
                }
                dt = DataAccess.GetDataTable(query2);
                counter = 0;
                while (counter < dt.Rows.Count)
                {
                    UserEntity passenger = ConvertToPassenger(dt.Rows[counter]);
                    userList.Add(passenger);
                    counter++;
                }


                return userList;
            }
            catch (Exception exception)
            {
                return null;
            }
            

        }
        internal Employee GetEmployeeInfo(string email,string password)
        {
            string query = "select employeeid,password,usertype,employeename,mobilenumber,logininfo.email,address,designation,salary,hiredate,commission from logininfo,employeeinfo where logininfo.email=employeeinfo.email and logininfo.email='" + email + "' and logininfo.password='" + password + "'";
            var dt = DataAccess.GetDataTable(query);
            
            Employee employee = this.ConvertToEmployee(dt.Rows[0]);
            return employee;
            
        }
        
        private Employee ConvertToEmployee(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            int userID= Convert.ToInt32(row["employeeid"].ToString());
            string password = row["password"].ToString();
            string name = row["employeename"].ToString();
            string mobile = row["mobilenumber"].ToString();
            string email = row["email"].ToString();
            string address = row["address"].ToString();
            string userType = row["usertype"].ToString();
            string designation = row["designation"].ToString();
            int salary= Convert.ToInt32(row["salary"].ToString());
            string hiredate = row["hiredate"].ToString();
            double commission= Convert.ToDouble(row["commission"].ToString());
            Employee employee = new Employee(userID, password, name, mobile, email, address, userType, designation, salary, hiredate, commission);
            return employee;
        }
        private Passenger ConvertToPassenger(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            int userID = Convert.ToInt32(row["passengerid"].ToString());
            string password = row["password"].ToString();
            string name = row["passengername"].ToString();
            string mobile = row["mobilenumber"].ToString();
            string email = row["email"].ToString();
            string address = row["address"].ToString();
            string userType = row["usertype"].ToString();
            Passenger passenger = new Passenger(userID, password, name, mobile, email, address, userType);
            return passenger;
        }
    }
}
