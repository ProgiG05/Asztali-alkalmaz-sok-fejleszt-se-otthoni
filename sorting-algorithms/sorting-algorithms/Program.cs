using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms
{
    internal class Program
    {
        static Hashtable hashdata = new Hashtable();
        static int hashCounter = 0;

        public static void Hashing(string password)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            var result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++) { result.Append(bytes[i].ToString("x2")); }
            hashdata.Add($"{hashCounter + 1}", result.ToString());
            hashCounter += 1;
        }
        public static void Reading()
        {
            File.ReadAllLines("testing.txt", Encoding.UTF8).ToList().ForEach(x => Console.WriteLine(x));
        }
        public static void Writing()
        {
            StreamWriter sw = new StreamWriter("testing.txt");
            foreach (DictionaryEntry item in hashdata)
            {
                sw.WriteLine($"{item.Key};{item.Value};{DateTime.Today.Year}.{DateTime.Today.Month}.{DateTime.Today.Day}");
            }
            sw.Close();
        }

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
       
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Give me a password: ");
                string pass = Console.ReadLine();
                Hashing(pass);
            }
            Writing();
            Reading();
            Console.ReadKey();
        }
    }
}
