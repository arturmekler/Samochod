using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        // Konstruktor domyslny
        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        // Konstruktor
        public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
        }

        //Właściwości
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        //Metody
        public void WprowadzSamochod(Samochod samochod)
        {
            if (liczbaSamochodow == 0)
            {
                samochody[0] = samochod;
                liczbaSamochodow = 1;
            }
            else
            {
                Console.WriteLine("Garaż jest zapełniony, by wprowadzić auto nareży zwolnić miejsce");
            }

        }
        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
            }

            if (liczbaSamochodow != 0)
            {
                samochody[0] = null;
                liczbaSamochodow = 0;
            }
            return null;
        }
        public void WypiszInfo()
        {
            // użycie metody z samochodu
            Samochod w1 = new Samochod();
            // użycie danych 
            w1 = samochody[0];
            

            // ewidentnie coś nie wychodzi mi z ostatnim krokiem w zadaniu 2 z WypiszInfo()
            // będzie błąd przy usuwaniu pojazdu nullreference jak nie obejde ifem null'a
            // dodatkowo pentla powinna wypisywać wszystkie garażowane samochody, ale nie widze jak i po co, jak może być tylko 1 w garazu

            for (int i = 0; i < samochody.Count(); i++)
            {
                if (samochody[0] == null)
                {
                    Console.WriteLine("Garaż jest pusty");
                }
                else
                {
                    w1.WypiszInfo();
                    Console.WriteLine("Adres = {0}", adres);
                    Console.WriteLine("Pojemnosc = {0}", pojemnosc);
                }

            }
        }
    }
}
