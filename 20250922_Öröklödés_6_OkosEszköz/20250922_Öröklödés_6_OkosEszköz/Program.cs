using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250922_Öröklödés_6_OkosEszköz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Okoseszkoz eszkoz1 = new Okoseszkoz("kerti öntözőrendszer", "bekapcsolva", 50, new DateTime(2023, 09, 17));
                eszkoz1.AllapotJelentes();
                Okoseszkoz eszkoz2 = new Okoseszkoz("konyhai páraelszívó", "kikapcsolva");
                eszkoz2.AllapotJelentes();
                Okoseszkoz eszkoz3 = new Okoseszkoz("fürdőszobai ventillátor", "bekapcsolva");
                eszkoz3.AllapotJelentes();


                Lampa lampa1 = new Lampa("nappali lámpa", "bekapcsolva", 50, new DateTime(2025, 09, 23), "hideg", 100);            
                lampa1.AllapotJelentes();
                Lampa lampa2 = new Lampa("éjjeli lámpa", "kikapcsolva", 50, new DateTime(2024, 11, 01), "meleg");             
                lampa2.AllapotJelentes();
                Lampa lampa3 = new Lampa("olvasólámpa", "bekapcsolva", 25);           
                lampa3.AllapotJelentes();


                Futes futes1 = new Futes("hálószobai fűtés", "bekapcsolva", 100, new DateTime(2025, 09, 09), 22, 19);             
                futes1.AllapotJelentes();
                Futes futes2 = new Futes("nappali fűtés", "bekapcsolva", 20);       
                futes2.AllapotJelentes();
                Futes futes3 = new Futes("fürdőszobai fűtés", "kikapcsolva", 0, new DateTime(2025, 12, 01), 25, 23);
                futes3.AllapotJelentes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
