using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250909_user_properties
{
    internal class Program
    {
        static public void NewPWD(string eredeti, string csere)
        {
            eredeti = csere;
        }
        static void Main(string[] args)
        {
            Console.Write("Felhsználónév: ");
            string username = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Jelszó: ");
            string password = Console.ReadLine();

            user user1 = new user(username,email,password);
            user1.Kiir();

            Console.Write("Szeretnél jelszót változtatni?(I/N) ");
            string check = Console.ReadLine();
            if (check.ToUpper() == "I")
            {
                Console.Write("Új jelszó: ");
                string csere = Console.ReadLine();
                if (csere.Length > 8 && csere.All(char.IsDigit))
                {
                    NewPWD(password, csere);
                }
                else
                {
                    Console.WriteLine("Helytelen jelszó! ");
                    throw new Exception("Helytelen jelszó! ");
                }
            }
            Console.ReadKey();
        }
    }
}
