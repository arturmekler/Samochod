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
        private string[] tablicaNazw;

        private string

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
                
                // tu jest bardzo wazna kwestia.. 'samochody' teraz maja TABLICE mającą już określoną ilość miejsca.
                // czyli jeżeli pojemnosc = 3 to mozesz umiescic tylko trzy samochody do tablicy.
                samochody = new Samochod[pojemnosc];
            }
        }

        //Metody
        public void WprowadzSamochod(Samochod samochod)
        {
            // i tu wlasnie jest ta metoda ktora ma dodawać do tablicy 'samochody' wlasnie ten samochod ktory masz w argumencie tej metody.
            // na ten moment ta metoda przypisuje tylko jeden samochod i koniec.

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
            // ta metoda zawsze bedzie zwracać null
            // a powinnoa zwracać obiekt 'Samochod'
            // dodatkowo powinna wywalać ostatni element tablicy 'samochody'

            // jak to zrobic masz w ostatniej metodzie opisane

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
            // to do wywalenia
            Samochod w1 = new Samochod();
            // użycie danych 
            // oczywiscie to tez do wywalenia
            w1 = samochody[0];


            // ewidentnie coś nie wychodzi mi z ostatnim krokiem w zadaniu 2 z WypiszInfo()
            // będzie błąd przy usuwaniu pojazdu nullreference jak nie obejde ifem null'a
            // dodatkowo pentla powinna wypisywać wszystkie garażowane samochody, ale nie widze jak i po co, jak może być tylko 1 w garazu

            // ta petla jest ladna ale trzeba to zrobic nieco inaczej

            // musisz dostac sie do kazdego pojedynczego samochodu z tablicy i wypisac o nim info.
            // sa na to dwa sposoby

            foreach (var samochod in samochody)
            {
                samochod.WypiszInfo();
            }
            // albo troche po stareoswiecku

            for (int i = 0; i < samochody.Count(); i++)
            {
                samochody[i].WypiszInfo();
            }


            // to nizej tez do wywalenia

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

        public void Przyklaaaad()
        {
            int pojemnoscTablicy = 3;
            
            // inicjalizacja tablicyNazw
            tablicaNazw = new string[pojemnoscTablicy];

            // dodawanie elementu do tablicy

            tablicaNazw[0] = "dupa";
            tablicaNazw[1] = "blada";
            tablicaNazw[2] = "komputer";

            // pamietaj ze tylko 3 elementy mozesz dodac bo tak zainicjalizowalismy tablice
            // 
            tablicaNazw[3] = "jak to dodasz to wywali blad";


            // jezeli chcesz zwrocic ostatni element tablicy to po prostu
            // jest tu -1 bo tablicaNazw ma dlugosc '3' a ostatni indeks tablicy to '2'.
            
            var ostatniElementTablicy = tablicaNazw[tablicaNazw.Length - 1];
            // lub
            var ostatniElementTablicy2 = tablicaNazw.Last();

            // jezeli chcemy usunąć element tablicy to po prostu mozna zrobic to tak
            tablicaNazw[3] = null;
            // lub
            tablicaNazw[tablicaNazw.Length - 1] = null;
        }
    }
}
