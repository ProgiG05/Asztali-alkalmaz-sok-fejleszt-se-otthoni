using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyar
{
    class Program
    {
        static List<LogisztikaiEszkoz> adatok = new List<LogisztikaiEszkoz>();

        static void Main(string[] args)
        {
            try
            {
                var lines = File.ReadAllLines("eszkozok.csv");
                foreach (var line in lines.Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    var egysor = line.Split(';');
                    if (egysor.Length == 0)
                    {
                        continue;
                    }
                    if (egysor[1] == "SzállítóRobot")
                    {
                        // Expecting at least 7 fields: type + 6 fields used below
                        if (egysor.Length < 7) throw new Exception("Hiányzó mezők SzallitoRobot sorban: " + line);
                        adatok.Add(new SzallitoRobot(egysor[0],egysor[1],int.Parse(egysor[2]),double.Parse(egysor[3], CultureInfo.InvariantCulture),egysor[4],DateTime.Parse(egysor[5], CultureInfo.InvariantCulture)));
                    }
                    else if (egysor[1] == "KéziTargonca")
                    {
                        // Expecting at least 8 fields: type + 7 fields used below
                        if (egysor.Length < 8) throw new Exception("Hiányzó mezők KeziTargonca sorban: " + line);
                        adatok.Add(new KeziTargonca(egysor[0],egysor[1],int.Parse(egysor[2]),double.Parse(egysor[3], CultureInfo.InvariantCulture),egysor[4],egysor[5],DateTime.Parse(egysor[6], CultureInfo.InvariantCulture)));
                    }
                    else
                    {
                        throw new Exception("Ismeretlen eszkoz tipus: " + egysor[0]);
                    }
                }
                foreach (var eszkoz in adatok)
                {
                    Console.WriteLine(eszkoz.Megjelenites());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
