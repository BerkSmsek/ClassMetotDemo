using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri musteri1 = new Musteri();
            musteri1.İsim = "Berk";
            musteri1.Soyad = "Şimşek";
            musteri1.MusteriSirasi = 020;

            Musteri musteri2 = new Musteri();
            musteri2.İsim = "Ali";
            musteri2.Soyad = "Koç";
            musteri2.MusteriSirasi = 021;

            Musteri musteri3 = new Musteri();
            musteri3.İsim = "Fatih";
            musteri3.Soyad = "Terim";
            musteri3.MusteriSirasi = 023;
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


        }
    }
}