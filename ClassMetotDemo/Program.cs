using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Id = 114683;
            Musteri1.Adi = "Şeyma";
            Musteri1.Soyadi = "Cellek";
            Musteri1.Sifre = 12345678;

            Musteri Musteri2 = new Musteri();
            Musteri2.Id = 124678;
            Musteri2.Adi = "Dara";
            Musteri2.Soyadi = "Özdemir";
            Musteri2.Sifre = 123458902;

            Musteri Musteri4 = new Musteri();
            Musteri4.Id = 2645575;
            Musteri4.Adi = "Kübra";
            Musteri4.Soyadi = "Çeçen";
            Musteri4.Sifre = 1348767899;

            Musteri Musteri3 = new Musteri();
            Musteri3.Id = 13478;
            Musteri3.Adi = "Şifa";
            Musteri3.Soyadi = "Akbaba";
            Musteri3.Sifre = 132789354;

            Musteri Musteri5 = new Musteri();
            Musteri5.Id = 1478636;
            Musteri5.Adi = "Sümeyye";
            Musteri5.Soyadi = "Ak";
            Musteri5.Sifre = 167889834;

            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3, Musteri4, Musteri5 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(Musteri1);
            musteriManager.Ekle(Musteri2);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(Musteri5);
            musteriManager.Sil(Musteri3);



        }
    }
}
