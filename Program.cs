using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DersKullaniciGirisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaan Academy");

            //STRING ALMA
            string kurulusIsmi;
            Console.WriteLine("Lutfen bir kurulus ismi giriniz...");
            kurulusIsmi = Console.ReadLine();
            Console.WriteLine("Girdiginiz kurulus ismi: " + kurulusIsmi);

            //CHAR ALMA
            char karakter;
            Console.WriteLine("Lutfen bir karakter giriniz...");
            karakter = Console.ReadKey().KeyChar;
            Console.WriteLine("Girdiginiz karakter: " + karakter);


            //INTEGER ALMA (int.parse   -   Convert.ToInt32     -   Int.TryParse)
            Console.WriteLine("Lutfen karesini almak istediginiz bir sayi giriniz...");
            int sayi;
            //sayi = Convert.ToInt32(Console.ReadLine());
            sayi = int.Parse(Console.ReadLine());  //EN SIK KULANILAN YONTEM!
            //int.TryParse(Console.ReadLine(), out sayi);
            Console.WriteLine("Girmis oldugunuz sayinin karesi: " + (sayi * sayi));

            //DOUBLE ALMA
            Console.WriteLine("Lutfen karesini almak istediginiz double sayi giriniz...");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayinin karesi: " + (sayi2 * sayi2));
            

            //FLOAT ALMA
            Console.WriteLine("Lutfen boyunuzu giriniz...");
            float boy;
            boy = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuz: " + boy + " metre");
            Console.ReadLine();


            //EK BILGILER

            var isim = "Ahmet"; //var, degiskenin deger atamasini yapmadan olusturmamizi sagliyor.
            const PI = 3,14; //const, degiskenin degerini sabitliyor. Degistirilmesini onluyor.
        }
    }
}
