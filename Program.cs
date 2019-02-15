using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmaLuokka
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Alytelevisio alytelkkari1 = new Alytelevisio("Samsung","OLED8601", 65, "3200x2560", "");

            alytelkkari1.Kayttoliittyma = "WebOS 5.6";
            alytelkkari1.NaytaTiedot();
            alytelkkari1.Kaynnista();
            alytelkkari1.NaytaTiedot();
            alytelkkari1.TallennusPaalla();
            alytelkkari1.AvaaVerkkoselain();
            alytelkkari1.Sammuta();

            Console.ReadKey();
            
        }
    }
}
