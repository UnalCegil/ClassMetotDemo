using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    { 
    
        public void Listele(Musteri a)
        {
            Console.WriteLine("-------------------Müşteri-------------------------");
            Console.WriteLine("Müşterinin adı soyadı :  " +a.Adi + " " + a.Soyadi);
            Console.WriteLine("Müşterinin Yaşı       :  " + a.MusteriYasi);
            Console.WriteLine("Mşterinin Mesleği     :  " + a.Meslek);
            
        }
        public void Ekle(string ad, string soyad, int yas, string meslek)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("*"+" "+ad+" "+soyad+" müşteri listesine başarıyla eklendi.");
            Console.WriteLine("Müşterinin adı soyadı :  " + ad + " " + soyad);
            Console.WriteLine("Müşterinin Yaşı       :  " + yas);
            Console.WriteLine("Mşterinin Mesleği     :  " + meslek);
            
        }
        public void Sil(Musteri b)
        {
            string onay;
            Console.WriteLine(b.Adi+" "+b.Soyadi+" kişisini müşteri listesinden silmek istiyor musunuz? (evet/hayır): ");
            onay = Console.ReadLine();
            if (onay == "evet" )
            {
                Console.WriteLine("*" + " " + b.Adi + " " + b.Soyadi + ", müşteri listesinden çıkarıldı.");
            }
            else
            {
                Console.WriteLine("Ana ekrana döndürülüyorsunuz. Lütfen bekleyin.");
            }
        }
    }
}
