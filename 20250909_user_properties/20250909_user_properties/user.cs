using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250909_user_properties
{
    internal class user
    {
        string username;
        string email;
        string password;
        DateTime regdate;

        public user(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            Regdate = DateTime.Now;
        }

        public user(string username2,string email2)
        {
            Username = username2;
            Email = email2;
        }

        public string Username
        {
            get => username;
            set => username = value != "" ? value.ToString().ToLower() : throw new Exception("Hibás felhasználónév!");
        }
        public string Email
        {
            get => email;
            set => email = value != "" && value.ToString().Contains("@") ? value : throw new Exception("Hibás email cím!");
        }
        public string Password
        {
            get => password;
            set {
                if (value.ToString().Length > 8 && value.Any(char.IsDigit) == true)
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Helytelen jelszó");
                }

            }
        }
        public DateTime Regdate
        {
            get => regdate;
            set => value = regdate;
        }

        public void Kiir()
        {
            Console.WriteLine($"Felhsználónév: {Username}\nEmail: {Email}\nJelszó: {Password}\nRegisztrálás ideje: {Regdate}");
        }
    }
}
