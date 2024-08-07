using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPratik
{
    public class Bebek
    {
        // Property tanımlamaları
        public DateTime DogumTarihi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        // Default Constructor
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine($"Ingaaaaaaaaaaaaaaaaaaaa");

        }
        // Alternatif Constructor
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;

            Console.WriteLine($"Ingaaaaaaaaaaaaaaaaaaaa");
        }
        // Bebek bilgilerini yazdırmak için bir metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"AD: {Ad} SOYAD: {Soyad} DOĞUM TARİHİ: {DogumTarihi}");
        }

    }
}