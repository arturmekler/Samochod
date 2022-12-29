using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test na zakonczenie Zad 1 (można zwinąć)
            if (false)
            {
                Samochod s1 = new Samochod();
                s1.WypiszInfo();
                s1.Marka = "Fiat";
                s1.Model = "126p";
                s1.IloscDrzwi = 2;
                s1.PojemnoscSilnika = 650;
                s1.SrednieSpalanie = 6.0;
                s1.WypiszInfo();
                Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
                s2.WypiszInfo();
                double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
                Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
                Samochod.WypiszIloscSamochodow();
                Console.ReadKey();
            }


            Samochod s3 = new Samochod();
            {
                s3.Marka = "Toyota";
                s3.Model = "Supra";
                s3.IloscDrzwi = 2;
                s3.PojemnoscSilnika = 3000;
                s3.SrednieSpalanie = 14.0;
            }
            Garaz g1 = new Garaz();
            g1.Adres = "Polna 13";
            g1.Pojemnosc = 1;
            g1.WprowadzSamochod(s3);
            g1.WypiszInfo();
            Console.WriteLine("------------\n wyjechanie auta z garażu \n------------");
            g1.WyprowadzSamochod();
            g1.WypiszInfo();

            Console.ReadKey();
        }
    }

}
