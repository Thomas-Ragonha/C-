using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse1.PointsAndLines
{
    class User
    {
        public static int ID;

        private string username;
        private int password;

        public string Username
        {
            get
            {
                return "The username is: " + username;
            }
        }

        public int Password
        {
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Invalid Pass");
                }
            }
        }


        public User()
        {
            ID++;
        }

        public User(string username)
        {
            this.username = username;
            ID++;
        }

    }
}
