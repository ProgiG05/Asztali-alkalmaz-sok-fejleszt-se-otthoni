using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt5_Vektor_hossz_kiszámítás
{
    class Program
    {
        struct csucsok
        {
            public int ax,ay;
            public int bx,by;
            public int cx,cy;
        }
        static void csúcsok()
        {
            csucsok a = new csucsok();
            csucsok b = new csucsok();
            csucsok c = new csucsok();
            Console.WriteLine("Háromszög csúcsai");
            Console.Write("Add meg az A pont x koordinátáját:");
            int ax = Convert.ToInt32(Console.ReadLine());
            ax = a.ax;
            Console.Write("Add meg az A pont y koordinátáját:");
            int ay = Convert.ToInt32(Console.ReadLine());
            ay = a.ay;
            Console.Write("Add meg az B pont x koordinátáját:");
            int bx = Convert.ToInt32(Console.ReadLine());
            bx = b.bx;
            Console.Write("Add meg az B pont y koordinátáját:");
            int by = Convert.ToInt32(Console.ReadLine());
            by = b.by;
            Console.Write("Add meg az C pont x koordinátáját:");
            int cx = Convert.ToInt32(Console.ReadLine());
            cx = c.cx;
            Console.Write("Add meg az C pont y koordinátáját:");
            int cy = Convert.ToInt32(Console.ReadLine());
            cy = c.cy;
        }
        static void kiír()
        {
            csucsok a = new csucsok();
            csucsok b = new csucsok();
            csucsok c = new csucsok();
            Console.WriteLine($"A csúcs koordinátái: ({a.ax};{a.ay})");
            Console.WriteLine($"B csúcs koordinátái: ({b.bx};{b.by})");
            Console.WriteLine($"C csúcs koordinátái: ({c.cx};{c.cy})");
        }
        static void vektor()
        {
            csucsok a = new csucsok();
            csucsok b = new csucsok();
            csucsok c = new csucsok();
            Console.WriteLine("Adott oldal vektorának kiszámítása");
            Console.Write("Melyik oldal vektorját akarod kiszámolni:(a/b/c): ");
            string oldal = Convert.ToString(Console.ReadLine());
            oldal.ToLower();
            switch (oldal)
            {
                case "a":
                    Console.Write("Add meg az B pont x koordinátáját:");
                    int bx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az B pont y koordinátáját:");
                    int by = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az C pont x koordinátáját:");
                    int cx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az C pont y koordinátáját:");
                    int cy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"a vektor: ({bx - cx};{by - cy})");
                    break;
                case "b":
                    Console.Write("Add meg az A pont x koordinátáját:");
                    int ax = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az A pont y koordinátáját:");
                    int ay = Convert.ToInt32(Console.ReadLine());
                    cx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az C pont y koordinátáját:");
                    cy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"b vektor: ({ax - cx};{ay - cy})");
                    break;
                case "c":
                    Console.Write("Add meg az A pont x koordinátáját:");
                    ax = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az A pont y koordinátáját:");
                    ay = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az B pont x koordinátáját:");
                    bx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az B pont y koordinátáját:");
                    by = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"c vektor: ({ax - bx};{ay - by})");
                    break;
                default:
                    Console.WriteLine("(a/b/c)!");
                    break;
            }
        }
        static void távolság()
        {
            csucsok a = new csucsok();
            csucsok b = new csucsok();
            csucsok c = new csucsok();
            Console.WriteLine("Kettő pont távolsága");
            Console.Write("Melyik oldalnak a távolságát akarod kistzámolni(a/b/c): ");
            string oldal = Convert.ToString(Console.ReadLine());
            oldal.ToLower();
            switch (oldal)
            {
                case "a":
                    Console.Write("Add meg az B pont x koordinátáját:");
                    int bx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az B pont y koordinátáját:");
                    int by = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az C pont x koordinátáját:");
                    int cx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az C pont y koordinátáját:");
                    int cy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Eredmény: {Math.Round(Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2)), 2)}");
                    break;
                case "b":
                    Console.Write("Add meg az A pont x koordinátáját:");
                    int ax = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az A pont y koordinátáját:");
                    int ay = Convert.ToInt32(Console.ReadLine());
                    cx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az C pont y koordinátáját:");
                    cy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Eredmény: {Math.Round(Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2)), 2)}");
                    break;
                case "c":
                    Console.Write("Add meg az A pont x koordinátáját:");
                    ax = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az A pont y koordinátáját:");
                    ay = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az B pont x koordinátáját:");
                    bx = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add meg az B pont y koordinátáját:");
                    by = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Eredmény: {Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)), 2)}");
                    break;
                default:
                    Console.WriteLine("(a/b/c)!");
                    break;
            }
        }
        
        static void Main(string[] args)
        {
            csúcsok();
            while (true)
            {
                //Console.WriteLine("Koordináták kiírása(kk)");
                Console.WriteLine("Vektor koordinátái(v)");
                Console.WriteLine("Kettő pont távolsága(kpt)");
                Console.Write("Mit akarsz kiszámolni? ");
                string válasz = Convert.ToString(Console.ReadLine());
                switch (válasz)
                {
                    //case "kk":
                        //kiír();
                        //break;
                    case "v":
                        vektor();
                        break;
                    case "kpt":
                        távolság();
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
