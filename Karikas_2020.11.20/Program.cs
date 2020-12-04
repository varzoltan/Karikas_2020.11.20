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
            Console.Write("Karakter=" + Karakter);
            Console.WriteLine("\nkarakter=" + Karakter);
            Console.WriteLine("Név: " + Nev);

            //1.feladat: Olvass be két egész számot, majd írd ki összegüket, különbségüket, 
            //szorzatukat és az első és második hányadosát egész osztással!

            //Szám beolvasása:
            Console.Write("Kérem adja meg az első számot: ");//Beolvasás
            string elso_egesz = Console.ReadLine();//A beolvasott szám tárolása változóban
            int szam1 = int.Parse(elso_egesz);//A szám átalakítása egészé
            Console.Write("Kérem adja meg a második egész számot: ");
            string masodik_egesz = Console.ReadLine();
            int szam2 = int.Parse(masodik_egesz);
            //int osszeg = szam1 + szam2;
            Console.WriteLine($"A két egész szám összege: {szam1+szam2}");//1 kiírás
            Console.WriteLine("A két szám különbsége:  {0} {1}", (szam1 - szam2),Nev);//2.kiírás
            Console.WriteLine("A két szám szorzata: " + szam1 * szam2);//3.kiírás
            Console.WriteLine("A két szám hányadosa: " + (szam1 / szam2));
            //Console.WriteLine(elso_egesz);//A szám kiírása

            //2.feladat: Olvasd be egy derékszögű háromszög befogóit, 
            //és írd ki átfogóját, kerületét, területét.
            Console.Write("Kérem adja meg a derékszögű háromszög egyik befogóját: ");
            string egyik =  Console.ReadLine();
            int a = int.Parse(egyik);
            Console.Write("Kérem adja meg a derékszögű háromszög egyik befogóját: ");
            string masodik = Console.ReadLine();
            int b = int.Parse(masodik);
            //a2+b2=c2
            //c=Négyzetgyök alatt(a2+b2)
            //Math.Sqrt((a  *  a)  +  (b  *  b)
            double valtozo  = Math.Sqrt((a  *  a)  +  (b  *  b));
            //Console.WriteLine($"Aderékszögű háromszög átfogója: { valtozo.ToString("0.00") }");
            Console.WriteLine($"Aderékszögű háromszög átfogója: { Math.Round(valtozo,2) }");
            double kerulet  =  (a  +  b  +  valtozo);
            double terulet = (a  *  b)  /  2;
            Console.WriteLine($"a derégszödű háromszög kerülete: {kerulet}, területe: {terulet}");

            //3.feladat: Egy BKV jegy 270 Ft, egy automatából vett kávé 70 Ft, egy liter tej 210 Ft és egy üveg bor 700 Ft. 
            //Olvasd be a forint - euro árfolyamot (1 euro hány forint), majd írd ki a fenti termékek árát euroban!
            Console.ReadKey();//Megállítja a program futását: egy billentyű leütésére vár
        }
    }
}
