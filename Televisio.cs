using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmaLuokka
{
    class Televisio
    {
        private bool paalla; //ominaisuudet ja metodit
        private bool tekstiTv;
        protected int koko; //kapseloidaan ominaisuus siten, että se ei näy muissa luokissa, mutta on käytettävissä kaikkialla
        protected string resoluutio;
        protected int kanava;
        protected int aanenvoimakkuus;
        protected string merkki;
        protected string malli;

        public Televisio() { } //ensimmäinen muodostin, oletusmuodostin, jolle ei anneta parametreja

        public Televisio(string merkki, string malli, int koko, string resoluutio) //toinen muodostin, jossa televisio saa osan arvoista parametreina
        {
            this.merkki = merkki;
            this.malli = malli;
            this.koko = koko;
            this.resoluutio = resoluutio;
            paalla = false; //Oletuksena televisio on aina kiinni ennen kuin se avataan.
        }



        public void Kaynnista()// Palautetaan true-arvo, kun televisio on päällä.
        {
            paalla = true;
            kanava = 1; //Televisiolla on oletusasetuksena auetessaan kanava ja äänenvoimakkuus
            aanenvoimakkuus = 10;
        }

        public void Sammuta() // Palautetaan false-arvo, kun televisio ei ole päällä.
        {
            tekstiTv = false; //Sammutetaan samalla myös teksti-tv
            paalla = false;
            Console.WriteLine("Televisio sammutetaan");
            Console.WriteLine();
        }

        public void AvaaTekstiTv() // Samat kuin Kaynnistä- ja Sammuta-metodit, mutta koskien teksti-tv:tä.
        {
            tekstiTv = true;
        }

        public void SuljeTekstiTv()
        {
            tekstiTv = false;
        }

        public void VaihdaKanavaa()
        {
            Console.WriteLine("Vaihda kanavaa (+, - tai kanavan numero): ");
            string uusiKanava = Console.ReadLine(); //Pyydetään käyttäjää antamaan komento kanavanvaihdolle

            try
            {
                kanava = Int32.Parse(uusiKanava); //yritetään parsia annettu komento luvuksi
            }

            catch (Exception) //Mikäli kyseessä ei ole luku, tutkitaan onko kyseessä + tai - komento ja muutetaan kanavaa sen mukaan
            {
                if (uusiKanava == "+")
                {
                    kanava++; //Lisätään nykyiseen kanavavalintaan +1    
                }

                else if (uusiKanava == "-") //Vähennetään nykyisestä kanavavalinnasta -1
                {
                    if (kanava > 1) //siirtyminen kanavalle tehdään vain, jos kanavan arvo on yli 1, koska 0 tai miinusmerkkisiä kanavia ei ole
                    {
                        kanava--;
                    }
                }
                else //Jos annetaan jotain muuta kuin luku, + tai -, ohjelma ilmoittaa vääränlaisesta kanavavalinnasta
                {
                    Console.WriteLine("Virheellinen kanavavalinta");
                    Console.WriteLine();
                }
            }
            if (kanava < 1) //Mikäli kanavanvalinnan arvo on 0 tai alempi niin siirrytään kanavalle 1
            {
                kanava = 1;
            }
        }

        public void VaihdaAanenvoimakkuutta() //Sama kuin kanavavalinnassa, mutta pelkillä + tai - valinnoilla
        {
            Console.WriteLine("Vaihda äänenvoimakkuutta (+ tai -): ");
            string uusiAanenvoimakkuus = Console.ReadLine();

            if (uusiAanenvoimakkuus == "+")
            {
                aanenvoimakkuus++;
            }
            else if (uusiAanenvoimakkuus == "-")
            {
                if (aanenvoimakkuus > 1)
                {
                    aanenvoimakkuus--;
                }
            }
            else
            {
                Console.WriteLine("Virheellinen valinta");
                Console.WriteLine();
            }

        }



        public void TulostaTiedot() //Tulostetaan television tiedot 
        {
            Console.WriteLine("Television merkki: " + merkki); //Tulostetaan television merkki, joka on määritetty merkki-metodissa
            Console.WriteLine("Television malli: " + malli); // -||- malli, joka on määritetty malli-metodissa
            Console.WriteLine("Television koko: " + koko + " tuumaa"); // -||- koko, joka on määritetty koko-metodissa
            Console.WriteLine("Television resoluutio: " + resoluutio + " pikseliä"); // -||- resoluutio, joka on määritetty resoluutio-metodissa

            if (paalla == true) //Tarkistetaan onko televisio päällä.
            {
                if (tekstiTv == true) //Tarkistetaan onko myös teksti-tv päällä.
                {
                    Console.WriteLine("Televisio on päällä. Teksti-tv on auki. Kanava: " + kanava + " Äänenvoimakkuus: " + aanenvoimakkuus); //Tulostetaan myös annetut/vaihdetut äänenvoimakkuus ja kanava.

                }
                else //Mikäli teksti-tv ei ole päällä eli false, ei siitä kirjata mainintaa tietoihin.
                {
                    Console.WriteLine("Televisio on päällä. Kanava: " + kanava + " Äänenvoimakkuus: " + aanenvoimakkuus);
                }
            }
            else //Mikäli televisio ei ole päällä (false).
            {
                Console.WriteLine("Televisio on kiinni");
            }
            
        }

        public void MuutaTiedot() //Pyytää käyttäjää antamaan uudet television tiedot, jotka annetaan vanhojen tilalle

        {
            Console.WriteLine("Anna television merkki: ");
            string uusiMerkki = Console.ReadLine(); //Pyydetään käyttäjältä uusi merkki vanhan tilalle
            merkki = uusiMerkki; //Muutetaan aiemmin televion merkin tilalle uusi merkki
            Console.WriteLine("Anna television koko: ");
            string uusiKoko = Console.ReadLine();
            try
            {
                koko = Int32.Parse(uusiKoko); //Yritetään parsia annettu komento luvuksi
            }
            catch (Exception)
            {
                Console.WriteLine("Anna koko lukuina"); //Huomautetaan mikäli kokoa ei ole annettu numeroina
            }
            Console.WriteLine("Anna television malli: ");
            string uusiMalli = Console.ReadLine();
            malli = uusiMalli;
            Console.WriteLine("Anna television resoluutio: ");
            string uusiResoluutio = Console.ReadLine();
            resoluutio = uusiResoluutio;

        }

    } //Televisio-luokan lopetus
}

