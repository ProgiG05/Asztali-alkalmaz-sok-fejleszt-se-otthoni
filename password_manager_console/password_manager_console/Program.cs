using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Security.Policy;
using System.Collections;
using System.IO;

namespace password_manager_console
{
    class login
    {
        //private int id;
        //private dateTime created_at;

        private string title;
        private string username;
        private string email;
        private string password;
        private string other;
        //public string Title { get => Title1; set => Title1 = value != "" ? value : throw new Exception("The title of the login can't be empty!"); }
        //public string Username { get => Username1; set => Username1 = value.Length < 25 ? value : throw new Exception("Username is too long! It should be less than 25 characters long!"); }
        //public string Email {
        //    get => Email1;
        //    set
        //    {
        //        if (value.Contains("@") && value.Contains("."))
        //        {
        //            Email1 = value;
        //        }
        //        else if (!value.Contains("@"))
        //        {
        //            throw new Exception("The email must contain at least one '@' character!");
        //        }
        //        else if (!value.Contains("."))
        //        {
        //            throw new Exception("The email must contain at least one '.' character!");
        //        }
        //        else
        //        {
        //            throw new Exception("The email is not valid! Must contain at least one '@' and one '.' character");
        //        }
        //    }
        //}
        //public string Password 
        //{ 
        //    get => Password1;
        //    set
        //    {
        //        string specialCharacters = "!@#$%^&*()-_=+[]{}|;:,.<>?/`~";
        //        bool hasSpecialcharacter = value.Any(x => specialCharacters.Contains(x));
        //        bool hasNumber = value.Any(x => char.IsDigit(x));
        //        bool hasUppercase = value.Any(x => char.IsUpper(x));
        //        if (hasSpecialcharacter && hasNumber && hasUppercase && value.Length >= 8) 
        //        {
        //            Password1 = value;
        //        }
        //        else if (value.Length < 8)
        //        {
        //            throw new Exception("Password is too short! It should be at least 8 characters long!");
        //        }
        //        else if (!hasSpecialcharacter)
        //        {
        //            throw new Exception("The password should have at least one special character!");
        //        }
        //        else if (!hasNumber)
        //        {
        //            throw new Exception("The password should have at least one number!");
        //        }
        //        else if (!hasUppercase)
        //        {
        //            throw new Exception("The password should have at least one uppercase letter!");
        //        }
        //        else
        //        {
        //            throw new Exception("Wrong password!");
        //        }
        //    }
        //}
        //public string Other { get => Other1; set => Other1 = value; }
        public string Title { get => title; set => title = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Other { get => other; set => other = value; }

        public login(string title, string username,string email, string password, string other)
        {
            Title = title;
            Username = username;
            Email = email;
            Password = password;
            Other = other;
        }
        public login(string title, string username, string email, string password)
        {
            Title = title;
            Username = username;
            Email = email;
            Password = password;
            Other = " ";
        }
        public login(string oneline)
        {
            string[] line = oneline.Split(';');
            Title = line[0];
            Username = line[1];
            Email = line[2];
            Password = line[3];
            Other = line[4];
        }
    }
    internal class Program
    {
        //public static string EncryptionDecryption(string passwordIn)
        //{
        //    var aes = Aes.Create();
        //    aes.Mode = CipherMode.CBC;
        //    aes.GenerateKey();
        //    aes.GenerateIV();
        //    var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        //    byte[] inputBuffer1 = Encoding.UTF8.GetBytes(passwordIn);
        //    byte[] encrypted = encryptor.TransformFinalBlock(inputBuffer1, 0, inputBuffer1.Length);

        //    var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        //    byte[] inputBuffer2 = Convert.FromBase64String(Convert.ToBase64String(encrypted));
        //    byte[] decrypted = decryptor.TransformFinalBlock(inputBuffer2, 0, inputBuffer2.Length);

        //    return $"Encrypted: {Convert.ToBase64String(encrypted)} - Decrypted: {Encoding.UTF8.GetString(decrypted)}";
        //}
        public static string ShowAllRules()
        {
            return "Username must be less the 25 characters long.\n" +
                "The email must contain at least one '@' and '.' character.\n" +
                "The password: \n" +
                "\tMust be at least 8 characters long.\n" +
                "\tMust contain at least one special character.\n" +
                "\tMust contain one number.\n" +
                "\tMust contain one uppercase letter.\n";
        }
        static List<login> data = new List<login>();
        static Hashtable hashedPasswords = new Hashtable();

        public static string Hashing(string password)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            var result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++) { result.Append(bytes[i].ToString("x2")); }
            return result.ToString();
        }

        public static void ShowAllLoginsText()
        {
            foreach (var item in System.IO.File.ReadAllLines("hashtable.csv").ToList())
            {
                string[] oneline = item.Split(';');
                hashedPasswords.Add(oneline[0], oneline[1]);
            }
            System.IO.File.ReadAllLines("logins.csv").ToList().ForEach(x => data.Add(new login(x)));
            foreach (var item in data)
            {
                Console.WriteLine($"Title: {item.Title}");
                Console.WriteLine($"Username: {item.Username}");
                Console.WriteLine($"Email: {item.Email}");
                foreach (DictionaryEntry item1 in hashedPasswords)
                {
                    if (item1.Key.ToString() == item.Password)
                    {
                        Console.WriteLine($"Password: {item1.Value} - ({item.Password})");
                    }
                }
                Console.WriteLine($"Other: {item.Other}");
                Console.WriteLine();
            }
        }
        public static void AddNewLogin(login newlog)
        {
            File.AppendAllText("logins.csv", $"{newlog.Title};{newlog.Username};{newlog.Email};{Hashing(newlog.Password)};{newlog.Other}" + Environment.NewLine);
            File.AppendAllText("hashtable.csv", $"{Hashing(newlog.Password)};{newlog.Password}" + Environment.NewLine);

            //File.AppendAllText(@"C:\\A0 #  P E R S O N A L  -  F O L D E R\\FONTOSAK", $"{newlog.Title}\t{newlog.Username}\t{newlog.Email}\t{newlog.Password}\t{newlog.Other}\t" + Environment.NewLine);
            //System.IO.StreamWriter sw = new System.IO.StreamWriter("logins.csv");
            //sw.WriteLine($"{newlog.Title}\t{newlog.Username}\t{newlog.Email}\t{newlog.Password}\t{newlog.Other}\t");
            //sw.Close();
        }
        static void Main(string[] args)
<<<<<<< HEAD
        {
            Console.WriteLine("Welcome to the password manager Console Application version!\n");
            Console.Write("Do you want to create new logins('c') or do you want to check out the logins('cc') (c/cc): ");
            string command = Console.ReadLine().ToLower();
            if (command == "c")
=======
        {  
            try
>>>>>>> 84cf48ff905565def4c745036e4ecc041aee8019
            {
                Console.WriteLine("Welcome to the password manager Console Application version!\n");
                Console.Write("Do you want to create new logins('c') or do you want to check out the logins('s') (c/s): ");
                string command = Console.ReadLine().ToLower();

                if (command == "c")
                {
                    Console.Write("Would you like to create multiple('m') or just one login('s')? (m/s): ");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "m")
                    {
                        while (true)
                        {
                            Console.WriteLine(ShowAllRules());
                            Console.Write("Title of the login: ");
                            string title = Console.ReadLine();
                            Console.Write("Username: ");
                            string username = Console.ReadLine();
                            Console.Write("Email: ");
                            string email = Console.ReadLine();
                            Console.Write("Password: ");
                            string password = Console.ReadLine();
                            Console.Write("Other: ");
                            string other = Console.ReadLine();

                            login newLogin = new login(title, username, email, password, other);
                            AddNewLogin(newLogin);

                            Console.WriteLine("\nLogin created successfully! The login has been uploaded to the logins.csv file!");
                            Console.Write("Would you like to create another login? (y/n): ");
                            string another = Console.ReadLine().ToLower();
                            if (another != "y") { break; }
                        }
                    }
                    else if (choice == "s")
                    {
                        Console.Write("Title of the login: ");
                        string title = Console.ReadLine();
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine("Other: ");
                        string other = Console.ReadLine();

                        login newLogin = new login(title, username, email, password, other);
                        AddNewLogin(newLogin);

                        Console.WriteLine("\nLogin created successfully! The login has been uploaded to the logins.csv file!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong command!");
                    }
                }
                else if (command == "s")
                {
                    ShowAllLoginsText();
                }
                else
                {
                    Console.WriteLine("Wrong command!");
                }
            }
<<<<<<< HEAD
            else if (command == "cc")
=======
            catch (Exception exeption)
>>>>>>> 84cf48ff905565def4c745036e4ecc041aee8019
            {
                Console.WriteLine(exeption.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
