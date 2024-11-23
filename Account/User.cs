using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
 
    public class User : IAccount
    {
        private static int _idCounter = 1; 
        private string _password;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public User(string email, string password, string fullname)
        {
            Id = _idCounter++;
            Email = email;
            Password = password;
            Fullname = fullname;

           
            if (!PasswordChecker(password))
            {
                throw new ArgumentException("Password must contain at least one digit.");
            }
        }

        
        public bool PasswordChecker(string password)
        {
            return password.Any(char.IsDigit); 
        }

        
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Email: {Email}");
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                    _password = value;
                else
                    throw new ArgumentException("Password must contain at least one digit.");
            }
        }
    }

}
