using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Ornek_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "yeni bir baslangıc";
            string Deneme = "denendi";
            Console.WriteLine(kelime);
            Console.Write(Deneme);
            int sayi = 5;
            Console.WriteLine(sayi);
            Console.Write(sayi);
            Mesaj msj = new Mesaj();
            msj.metin();
            kisiler ks = new kisiler();
            ks.kisiListesi();
            ks.kisi("Zehra Aydın");
            Console.WriteLine("İSİM GİRİN ");
            string abs;
            abs = Console.ReadLine();
            ks.kisi(abs);
            islem isl= new islem();
            isl.topla(7, 9);
            Console.WriteLine("\n\n\n");//boşluk bırakmakkk
            Console.Write("son");
            Console.Read();
        }
    }
}

