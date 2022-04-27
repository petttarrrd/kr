using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KR
{
    
    interface IpropertyObserver
    {
        void Masseg();
    }
    internal class User: IpropertyObserver
    {
        Regex regex = new Regex(@"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        public string Name { get; set; }
        
        public User(string nam, string mail, string phone)
        {
            Name = nam;
            SGEmail = mail;
            Phone = phone;
        }

        public string SGEmail
        {
            get { return Email; }
            set
            {
                if (regex.IsMatch(value))
                {
                    Email = value;
                }
            }
        } 

        protected string Email;
        
       public string Phone { get; set; }

        public void Masseg() 
        {
            Console.WriteLine($"Привет {Name}!");
        }
    }
}
