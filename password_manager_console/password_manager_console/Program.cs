using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Security.Policy;

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
        public string Title { get => title; set => title = value != "" ? value : throw new Exception("The title of the login can't be empty!"); }
        public string Username { get => username; set => username = value.Length < 25 ? value : throw new Exception("Username is too long! It should be less than 25 characters long!"); }
        public string Email {
            get => email;
            set
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    email = value;
                }
                else if (!value.Contains("@"))
                {
                    throw new Exception("The email must contain at least one '@' character!");
                }
                else if (!value.Contains("."))
                {
                    throw new Exception("The email must contain at least one '.' character!");
                }
                else
                {
                    throw new Exception("The email is not valid! Must contain at least one '@' and one '.' character");
                }
            }
        }
        public string Password 
        { 
            get => password;
            set
            {
                string specialCharacters = "!@#$%^&*()-_=+[]{}|;:,.<>?/`~";
                bool hasSpecialcharacter = value.Any(x => specialCharacters.Contains(x));
                bool hasNumber = value.Any(x => char.IsDigit(x));
                bool hasUppercase = value.Any(x => char.IsUpper(x));
                if (hasSpecialcharacter && hasNumber && hasUppercase && value.Length >= 8) 
                {
                    password = value;
                }
                else if (value.Length < 8)
                {
                    throw new Exception("Password is too short! It should be at least 8 characters long!");
                }
                else if (!hasSpecialcharacter)
                {
                    throw new Exception("The password should have at least one special character!");
                }
                else if (!hasNumber)
                {
                    throw new Exception("The password should have at least one number!");
                }
                else if (!hasUppercase)
                {
                    throw new Exception("The password should have at least one uppercase letter!");
                }
                else
                {
                    throw new Exception("Wrong password!");
                }
            }
        }
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
            string[] line = oneline.Split('\t');
            Title = line[0];
            Username = line[1];
            Email = line[2];
            Password = line[3];
            Other = line[4];
        }
    }
    internal class Program
    {
        public static string Encryption(string passwordIn)
        {
            // Create a new AES algorithm instance using the default implementation.
            // yields an Aes object configured with default settings (block size, key size, etc.)
            var aes = Aes.Create();

            // Specify the mode of operation for the cipher; CBC chains each block with the previous cipher block.
            // sets Cipher Block Chaining mode, which requires an IV
            aes.Mode = CipherMode.CBC;

            // Generate a random cryptographic key for AES.
            // fills aes.Key with cryptographically-strong random bytes
            aes.GenerateKey();

            // Generate a random initialization vector (IV) for AES/CBC.
            // fills aes.IV with cryptographically-strong random bytes
            aes.GenerateIV();

            // Create an ICryptoTransform that will perform the encryption using the generated Key and IV.
            // creates an encryptor object configured with the chosen key and IV
            var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            // transforms the string to a byte array suitable for encryption
            // Convert the input plaintext string into a sequence of bytes using UTF-8 encoding.
            byte[] inputBuffer = Encoding.UTF8.GetBytes(passwordIn);

            // Perform the encryption on the entire plaintext byte array and obtain the ciphertext bytes.
            // encrypts the bytes and handles padding as needed
            byte[] encrypted = encryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

            // returns the ciphertext as a Base64 string
            // Convert the encrypted byte array to a Base64-encoded string for safe textual representation/storage.
            return Convert.ToBase64String(encrypted);
        }
        public static void Hashing()
        {

        }
        public static string Decryption(string passwordOut)
        {
            // Create a new AES algorithm instance using the default implementation.
            // This returns an Aes object configured with default settings (block size, key size, etc.).
            var aes = Aes.Create();

            // Set the cipher mode to CBC (Cipher Block Chaining).
            // CBC requires an initialization vector (IV) to chain blocks together.
            aes.Mode = CipherMode.CBC;

            // NOTE: The following two calls generate a new random Key and IV.
            // In a correct encryption/decryption flow you must use the SAME Key and IV
            // that were used during encryption. Generating new ones here will NOT recover
            // the original plaintext unless the Key and IV are persisted and reused.
            aes.GenerateKey();
            aes.GenerateIV();

            // Create a decryptor ICryptoTransform using the aes.Key and aes.IV.
            // The decryptor performs the inverse transformation of the encryptor.
            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            // The stored ciphertext is Base64-encoded text. Convert it back to raw bytes.
            byte[] inputBuffer = Convert.FromBase64String(passwordOut);

            // Perform the actual decryption on the full ciphertext buffer.
            // TransformFinalBlock handles any padding and returns the plaintext bytes.
            byte[] decrypted = decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

            // Convert the plaintext bytes back to a UTF-8 string and return it.
            return Encoding.UTF8.GetString(decrypted);
        }
        public static string ShowAllRules()
        {
            return "Username must be less the 25 characters long.\nThe email must contain at least one '@' and '.' character.\nThe password: \n\tMust be at least 8 characters long.\n\tMust contain at least one special character.\n\tMust contain one number.\n\tMust contain one uppercase letter.\n";
        }
        //public static void ShowAllLoginsDB()
        //{
        //    string connectionString = "Data Source=localhost;Initial Catalog=password_manager_db;Integrated Security=True;";
        //    string queryString = "SELECT * FROM login";
        //    SqlConnection connection1 = new SqlConnection(connectionString);
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection1);
        //    DataSet dataSet = new DataSet();
        //    connection1.Open();
        //    dataAdapter.Fill(dataSet);
        //    connection1.Close();
        //    foreach (DataRow row in dataSet.Tables[0].Rows)
        //    {
        //        Console.WriteLine($"Title: {row["title"]}\nUsername: {row["username"]}\nEmail: {row["email"]}\nPassword: {Decryption(row["password"].ToString())}\nOther: {row["other"]}\n");
        //    }
        //}
        //public static void AddLoginDB(login newLogin)
        //{
        //    string connectionString = "Data Source=localhost;Initial Catalog=password_manager_db;Integrated Security=True;";
        //    string queryString = $"INSERT INTO login (title, username, email, password, other) VALUES ({newLogin.Title}, {newLogin.Username}, {newLogin.Email}, {newLogin.Password}, {newLogin.Other})";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString,connectionString);
        //    connection.Open();
        //    dataAdapter.InsertCommand = new SqlCommand(queryString, connection);
        //    dataAdapter.InsertCommand.ExecuteNonQuery();
        //    connection.Close();
        //}
        static List<login> data = new List<login>();
        public static void ShowAllLoginsText()
        {
            System.IO.File.ReadAllLines("logins.txt").ToList().ForEach(x => data.Add(new login(x)));
            foreach (var item in data)
            {
                Console.WriteLine($"Title: {item.Title}");
                Console.WriteLine($"Username: {item.Username}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Password: {item.Password}");
                Console.WriteLine($"Password: {Decryption(item.Password)}");
                Console.WriteLine($"Other: {item.Other}");
                Console.WriteLine();
            }
        }
        public static void AddNewLoginText(login newlog)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("logins.txt");
            sw.WriteLine($"{newlog.Title}\t{newlog.Username}\t{newlog.Email}\t{Encryption(newlog.Password)}\t{newlog.Other}\t");
            sw.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the password manager Console Application version!\n");
            Console.Write("Do you want to create new logins('c') or do you want to check out the logins('s') (c/s): ");
            string command = Console.ReadLine().ToLower();
            if (command == "c")
            {
                try
                {
                    Console.Write("Would you like to create multiple('m') or just one login('o')? (m/o): ");
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
                            //AddLoginDB(newLogin);
                            AddNewLoginText(newLogin);

                            Console.WriteLine("\nLogin created successfully! The login has been uploaded to the database!");
                            Console.Write("Would you like to create another login? (y/n): ");
                            string another = Console.ReadLine().ToLower();
                            if (another != "y"){ break;}
                        }
                    }
                    else if (choice == "o")
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
                        //AddLoginDB(newLogin);
                        AddNewLoginText(newLogin);

                        Console.WriteLine("\nLogin created successfully! The login has been uploaded to the database!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong command!");
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                    throw;
                }
            }
            else if (command == "s")
            {
                //ShowAllLoginsDB();
                ShowAllLoginsText();
            }
            else
            {
                Console.WriteLine("Wrong command!");
            }
            
            Console.ReadKey();
        }
    }
}
