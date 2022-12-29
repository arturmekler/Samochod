using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int iloscSamochodow = 0;

        // Konstruktor domyslny
        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;
            iloscSamochodow ++;
        }

        // Konstruktor
        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
        }

        //Właściwości
        public string Marka
        {
           get { return marka; }
           set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        private double ObliczSpalanie(double dlugoscTrasy, double srednieSpalanie)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100.0;
            return spalanie;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            var spalanie = ObliczSpalanie(dlugoscTrasy, srednieSpalanie);
            double kosztPrzejazdu = spalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Marka samochodu = {0}", marka);
            Console.WriteLine("Model samochodu = {0}", model);
            Console.WriteLine("Ilość drzwi samochodu = {0}", iloscDrzwi);
            Console.WriteLine("Pojemność silnikasamochodu = {0}", pojemnoscSilnika);
            Console.WriteLine("średnie spalanie samochodu = {0}", srednieSpalanie);
        }
        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine(iloscSamochodow);
        }

    }
}

