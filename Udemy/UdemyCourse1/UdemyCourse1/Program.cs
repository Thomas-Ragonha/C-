using System;
using UdemyCourse1.PointsAndLines;

namespace UdemyCourse1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Thomas Ragonha");
            User u2 = new User();
            Console.WriteLine(User.ID);

            Console.Read();
        }
    }
}
