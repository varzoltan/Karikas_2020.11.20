using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;

namespace Karikas_2020._11._20
{
    class Program
    {
        static void Main(string[] args)
        {
           //Változók
           //1 kötelező típus, osztály, vagy objektum
           //2 kötelező név megadása: nem lehet foglalt szó, kulcs szó!
           //Példa
           string Nev; //deklaráció
            Nev = "Varga Zoltán";
            string Nev2 = "Karikás Eszter";

            //számok létrehozása
            int Szam = 525;

            //Törtszám létrehozása
            double Tort = 3.14;

            //Logikai típus létrehozása
            bool Igaz = true;

            //Karaktertípus létrehozása
            char Karakter = '1';
            Console.Write("Karakter="+Karakter);
            Console.WriteLine("\nkarakter="+Karakter);
            Console.Write("Név: "+Nev);

            //1.feladat: Olvass be két egész számot, majd írd ki összegüket, különbségüket, 
            //szorzatukat és az első és második hányadosát egész osztással!

            //Szám beolvasása:
            Console.Write("Kérem adja meg az első számot: ");
            string elso_egesz = Console.ReadLine();
            int szam1 = int.Parse(elso_egesz);
            Console.WriteLine(elso_egesz);
            Console.ReadKey();
        }
    }
}
