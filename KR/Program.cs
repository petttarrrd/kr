using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop magazin = new Shop();

            User user1 = new User("Максим","maksim.andrukhlenko@mail.ru","89832791689");
            User user2 = new User("Адик", "228@mail.ru", "895768957");

            magazin.Add(user1);
            magazin.Add(user2);

            magazin.Notify();

            magazin.Remove(user1);

            magazin.Notify();
            Console.ReadLine();
        }
    }
}
