using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmaLuokka
{
    class Alytelevisio : Televisio //Televisio-luokka periytyy tähän luokkaan
    {
        private bool tallennus; //kapseloidaan koskemaan vain tätä luokkaa
        private bool verkkoselain;
        public string kayttoliittyma;
        
        

        public Alytelevisio() { } //oletusmuodostin

        public Alytelevisio(string merkki, string malli, int koko, string resoluutio, string Kayttoliittyma) : base (merkki, malli, koko, resoluutio) //basen avulla saadaan ominaisuudet periytymään Televisio-luokasta
        {
            

        }

        public string Kayttoliittyma

        {
            set //luodaan attribuutin setteri ja getteri 
            {
                kayttoliittyma = value;
            }
            get
            {
                return kayttoliittyma;
            }
                    
        }

        public void TallennusPaalla()
        {
            tallennus = true;
            Console.WriteLine("Tallennus käynnistetty");
        }

        public void TallennusPaattynyt()
        {
            tallennus = false;
            Console.WriteLine("Tallennus keskeytetty");
        }

        public void AvaaVerkkoselain()
        {
            verkkoselain = true;
            Console.WriteLine("Selain auki");
        }

        public void SuljeVerkkoselain()
        {
            verkkoselain = false;
            Console.WriteLine("Selain suljettu");
        }

        public void NaytaTiedot() //Tulostetaan Televisio-luokan TulostaTiedot-aliohjelman lisäksi alytelevision Kayttöliittymän tiedot

        {
            TulostaTiedot();
            Console.WriteLine("Käyttöliittymä: " + Kayttoliittyma);
            Console.WriteLine(); //Tyhjä rivi loppuun ohjelman suorituksen selkeyden takia.

        }        
    }
} //Alytelevisio-luokan lopetus
