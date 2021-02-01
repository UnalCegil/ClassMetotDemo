using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Adi ="Ünal";
            musteri.Soyadi = "Mutlu";
            musteri.MusteriYasi = 30;
            musteri.Meslek = "Öğretmen";

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ru";
            musteri1.Soyadi = "Mutlu";
            musteri1.MusteriYasi = 26;
            musteri1.Meslek = "Ev hanımı";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Alperen";
            musteri2.Soyadi = "Mutlu";
            musteri2.MusteriYasi = 1;
            musteri2.Meslek = "Çalışmıyor";


            Musteri[] musteriler = new Musteri[] { musteri, musteri1, musteri2};
            MusteriManager manager = new MusteriManager();
            
            foreach (var item in musteriler)
            {
                manager.Listele(item);
            }
            manager.Ekle("Emrah ", "Mutlu", 34, "Teknisyen");
            manager.Sil(musteri1);
        }
    }
}
