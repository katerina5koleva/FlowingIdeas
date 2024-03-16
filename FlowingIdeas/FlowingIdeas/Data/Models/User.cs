using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowingIdeas.Data.Models
{
    /// <summary>
    /// This class is the structure of the table "Users" in the database. It validates the username and password.
    /// </summary>
    internal class User
    {
        private int id;
        private string username;
        private string password;

        public User()
        {
           
        }

        private int Id { get; set; }
        public string Username 
        { 
            get
            {
                return username;
            }
            set
            {
                if (username.Length < 5 || username.Length > 15)
                {
                    throw new ArgumentException("Your username should be between 5 and 15 characters!");
                }
                else
                {
                    this.username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password.Length < 4)
                {
                    throw new ArgumentException("Please, enter a password longer than 4 characters.");
                }
                else if (password.Length >= 4)
                {
                    foreach (char i in password)
                    {
                        if (char.IsNumber(i))
                        {
                            this.password = value;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Your password should include a digit.");
                }
            }
        }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
// this class is pretty much done