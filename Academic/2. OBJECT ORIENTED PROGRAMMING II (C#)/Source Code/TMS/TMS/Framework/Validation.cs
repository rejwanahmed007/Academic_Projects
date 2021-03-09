using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using TMS.ApplicationLayer;
using TMS.Data;
using TMS.Entity;
using TMS.Repository;

namespace TMS.Framework
{
    public static class Validation
    {
        internal static UserEntity SignInAuthentication(List<UserEntity> userList, string email, String password)
        {
            UserEntity user = null;
            int counter = 0;
            while(counter<userList.Count)
            {
                if(userList.ElementAt(counter)!=null)
                {
                    if(userList.ElementAt(counter).Email.Equals(email) && userList.ElementAt(counter).Password.Equals(password))
                    {
                        user = userList.ElementAt(counter);
                    }
                }
                counter++;
            }


            return user;
        }
        internal static bool EmailCrossCheckingWithDatabase(List<UserEntity> userList,string email)
        {
            int counter = 0; bool cross = true;
            while(counter<userList.Count)
            {
                if(userList.ElementAt(counter)!=null)
                {
                    if(userList.ElementAt(counter).Email.Equals(email))
                    {
                        cross = false;
                        break;
                    }
                }
                counter++;
            }
            return cross;
        }
        internal static bool IsPassengerEmailValid(List<string> PassengerEmailList, string email)
        {
            int counter = 0; bool cross = false ;
            while (counter < PassengerEmailList.Count)
            {
                if (PassengerEmailList[counter].ToString() != null)
                {
                    if (PassengerEmailList[counter].ToString().Equals(email))
                    {
                        cross = true;
                        break;
                    }
                }
                counter++;
            }
            return cross;
        }

        public static bool MobileNumberValidation(string value)
        {
            if (value.Length.Equals(11))
            {

                if (value.Substring(0, 3).Equals("011") || value.Substring(0, 3).Equals("013") || value.Substring(0, 3).Equals("014") || value.Substring(0, 3).Equals("015") || value.Substring(0, 3).Equals("016") || value.Substring(0, 3).Equals("017") || value.Substring(0, 3).Equals("018") || value.Substring(0, 3).Equals("019"))
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            else
            {
                return false;

            }
        }
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;
            else
            return true;
        }
        public static bool EmailAuthentication(string value)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(value, pattern) == false)
            {
                return false;
            }
            else
                return true;
        }
        public static bool IsIntValid(string value)
        {
            int i;
            return Int32.TryParse(value, out i);
        }

        

    }
}
