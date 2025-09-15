using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mátrix - ismétlés
            Random rnd = new Random();
            int[,] matrix = new int[10, 10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                }
            }

            //kiírás 1
            Console.WriteLine("kiírás 1");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //kiírás 2 - foreach
            Console.WriteLine("kiírás 2 - foreach");

            foreach (var item in matrix)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //kiírás 3 - tömbök tömbje
            Console.WriteLine();
            Console.WriteLine("kiírás 3 - tömbök tömbje");

            int[][] tömböktömbje =
            {
                new int[] {1,2},
                new int[] {3,4},
                new int[] {5,6}
            };
            Console.WriteLine($"Tömbök tömbjének egy elemének elérése: {tömböktömbje[0][0]}");
            Console.WriteLine($"Az összes elem: ");
            for (int i = 0; i < tömböktömbje.Length; i++)
            {
                for (int j = 0; j < tömböktömbje[i].Length; j++)
                {
                    Console.Write($"{tömböktömbje[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //deklarálás
            Console.WriteLine("deklarálás");
            //[első] = sor [második] = oszlop
            int[][] tt = new int[3][];
            //oszlopok feltöltése
            tt[0] = new int[] { 1, 2, 3, 4 };
            tt[1] = new int[] { 5, 6, 7 };
            tt[2] = new int[] { 8, 9, 10, 11, 12 };

            //tt elemei
            foreach (var item in tt) //sorokon megyünk végig - item: 1 2 3 4
            {
                foreach (var i in item) //oszlop - 1
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < tt.Length; i++)
            {
                Console.Write($"{i + 1}.sor elemei: ");
                for (int j = 0; j < tt[i].Length; j++)
                {
                    Console.Write($"{tt[i][j]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sztringek / karakterláncok kezelése\n");
            string s1 = "alma";
            string s2 = "fa";
            Console.WriteLine($"{s1 + s2} "); //konkatenálás - összefűzés

            string szoveg = "Egyszer volt, holnem volt, volt egyszer egy almafa.";
            Console.WriteLine($"A szöveg hossza: {szoveg.Length}");
            Console.WriteLine("A szöveg hossza: {0}", szoveg.Length);
            Console.WriteLine("A szöveg hossza: " + szoveg.Length);
            Console.WriteLine($"A szöveg első betűje:{szoveg[0]}");
            Console.WriteLine($"A szöveg első betűje:{szoveg.First()}");
            Console.WriteLine($"A szöveg utolsó betűje:{szoveg[szoveg.Length - 1]}");
            Console.WriteLine($"A szöveg utolsó betűje:{szoveg.Last()}");
            Console.WriteLine($"A szöveg nagybetűsen: {szoveg.ToUpper()}");
            Console.WriteLine($"A szöveg kisbetűsen: {szoveg.ToLower()}");
            Console.WriteLine("A szöveg kiíratása betűnként: ");
            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.Write($"{szoveg[i]} ");
            }
            //Tartalmazásvizsgálat - Contains
            Console.WriteLine();
            Console.WriteLine(szoveg.Contains("volt") ? "A 'volt' szó szerepel benne." : "A 'volt szó nem szerepel benne'");
            Console.WriteLine("Mit keressek a szövegben? ");
            Console.WriteLine(szoveg.Contains(Console.ReadLine()) ? "Benne van" : "Nincs benne");

            //EndsWith - igaz értékkel tér vissza, ha a megadott szövegrészlettel végződik a szöveg
            Console.WriteLine(szoveg.EndsWith(".") ? "Van pont a mondat végén" : "Nincs pont a mondat végén");

            //StartsWith - igaz értékkel tér vissza, ha a megadott szövegrészlettel kezdődik a szöveg
            Console.WriteLine(szoveg.StartsWith("a") ? "Ezzel kezdődik" : "Nem ezzel kezdődik");

            Console.WriteLine("Mit vizsgáljak meg? ");
            Console.WriteLine(szoveg.StartsWith(Console.ReadLine().ToUpper()) ? "Ezzel kezdődik" : "Nem ezzel kezdődik");

            //IndexOf - a paraméterenként megadott kar. vagy szövegrészlet első előfordulásának indexét adja meg
            Console.WriteLine(szoveg.IndexOf("volt") != -1 ? $"A 'volt' szó {szoveg.IndexOf("volt") + 1}. betűtől kezdődik" : "Nincs benne");
            Console.WriteLine("Melyik betű indexét keressem? ");
            string s = Console.ReadLine();
            Console.WriteLine(szoveg.IndexOf(s) != -1 ? $"{s} betű indexe: {szoveg.IndexOf(s) + 1}" : $"Nincs benne {s}");

            //LastIndexOf - a paraméterenként megadott kar. vagy szövegrészlet utolsó előfordulásának indexét adja meg
            Console.WriteLine(szoveg.LastIndexOf("egyszer") != -1 ? $"{szoveg.LastIndexOf("egyszer")}.betűtől kezdődik utoljára" : "Nincs benne");

            //Replace - csere(régi,új)
            Console.WriteLine(szoveg.Replace("Egyszer", "Eccer"));

            //Substring - a megadott indextől kezdve adott karakterszámig a szöveg karaktereit átmásolja
            Console.WriteLine($"A szöveg 5.betűtől 10 karakterhossza: {szoveg.Substring(6, 10)}");

            //Split - a szöveg feldarabolása adott karakter mentén
            string[] darab = szoveg.Split(' ');
            foreach (var item in darab)
            {
                Console.Write($"{item} ");
            }

            //Remove - Remove(int startIndex,int charNum)
            Console.WriteLine(szoveg.Remove(0, 5));
            //Remove(int startIndex)
            Console.WriteLine(szoveg.Remove(3));

            //Trim - a szöveg elejéről és végéről eltávolítja az összes szóküzt és tabulátort
            s = "\tez egy mondat    ";
            Console.WriteLine(s);
            Console.WriteLine($"A szóközök,tabulátorok nélküli mondat nagybetűsen: {s.Trim().ToUpper()}");

            //TrimEnd,TrimStart
            s = "           Cica            ";
            Console.WriteLine(s);
            Console.WriteLine(s.TrimStart());

            Console.WriteLine("Formázott kiírás");
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            //Pénz formátum c/C
            Console.WriteLine($"{szam} pénz formátumban: {szam:C}");
            Console.WriteLine($"{szam} pénz formátumban: {szam:C0}");
            Console.WriteLine($"{szam} pénz formátumban: {szam:c0}");

            //Decimális - d/D
            Console.WriteLine($"{szam:0000000} helykitöltéssel");
            Console.WriteLine("{0:d8}", szam);

            //Exponenciális,tudományos,lebegőpontos kiírás - e/E
            Console.WriteLine($"Lebegőpontos alak: {szam:e}");

            //Fixpontos alak f5
            Console.WriteLine($"Fixpontos alak: {szam:f5}");

            //ezres csopi
            Console.WriteLine("{0:+## ### ### ###}", 36345678912);

            //százalék - p/P
            Console.WriteLine($"{szam:P3}");

            //síp
            Console.WriteLine("\avége");


























            Console.ReadKey();
        }
    }
}
