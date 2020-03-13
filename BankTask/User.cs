using System;
using System.Collections.Generic;
using System.Text;

namespace BankTask
{
    public class User
    {
        private string name;
        private int id;

        public string Name
        {
            get
            {
                return "Name : "+name;
            }
            set
            {
                name = value;
            }
        }

        public int Id {
            get
            {
                return id;
            }
            set
            {
                if (value > 100)
                {
                    Console.Write("Invalid value");
                }
                else id = value;
            }

        }

        public static List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
