using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("              LaCalc                    ");
        Console.WriteLine("========================================");
        Console.WriteLine("     Laren Scientific Calculator        ");
        Console.WriteLine("     Hos Geldiniz!                      ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            for (int j = 0; j < 400000000; j++)
            {
            }
        }

        int secim = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("              LaCalc                    ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Temel Islemler");
            Console.WriteLine("2. Us ve Kok Hesaplama");
            Console.WriteLine("3. Uzunluk Donusturucu km - mil");
            Console.WriteLine("4. Agirlik Donusturucu kg - pound");
            Console.WriteLine("5. Alan Hesaplama");
            Console.WriteLine("6. Yuzde Hesaplama");
            Console.WriteLine("0. Cikis");
            Console.WriteLine("========================================");
            Console.Write("Lutfen bir secenek giriniz: ");
            secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                TemelIslemler();
            }
            else if (secim == 2)
            {
                UsVeKok();
            }
            else if (secim == 3)
            {
                UzunlukDonusturucu();
            }
            else if (secim == 4)
            {
                AgirlikDonusturucu();
            }
            else if (secim == 5)
            {
                AlanHesaplama();
            }
            else if (secim == 6)
            {
                YuzdeHesaplama();
            }
            else if (secim == 0)
            {
                Console.WriteLine("Program kapatiliyor, gorusmek uzere!");
            }
            else
            {
                Console.WriteLine("Boyle bir secenek yok, tekrar deneyin!");
            }

            if (secim != 0)
            {
                Console.Write("\nAna menuye donmek icin enter'a basin: ");
                Console.ReadLine();
            }
        } while (secim != 0);
    }

    static void TemelIslemler()
    {
        Console.Clear();
        Console.WriteLine("--- Temel Islemler ---");
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Cikarma");
        Console.WriteLine("3. Carpma");
        Console.WriteLine("4. Bolme");
        Console.Write("Islem seciniz: ");
        int islem = int.Parse(Console.ReadLine());
        Console.Write("Birinci sayiyi girin: ");
        double s1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikinci sayiyi girin: ");
        double s2 = Convert.ToDouble(Console.ReadLine());

        if (islem == 1)
        {
            double toplam = s1 + s2;
            Console.WriteLine("Toplam sonucu: " + toplam);
        }
        else if (islem == 2)
        {
            double cikarma = s1 - s2;
            Console.WriteLine("Cikarma sonucu: " + cikarma);
        }
        else if (islem == 3)
        {
            double carpma = s1 * s2;
            Console.WriteLine("Carpma sonucu: " + carpma);
        }
        else if (islem == 4)
        {
            if (s2 != 0)
            {
                double bolme = s1 / s2;
                Console.WriteLine("Bolme sonucu: " + bolme);
            }
            else
            {
                Console.WriteLine("Hata! Bir sayi sifira bolunemez.");
            }
        }
        else
        {
            Console.WriteLine("Yanlis secim yaptiniz!");
        }
    }

    static void UsVeKok()
    {
        Console.Clear();
        Console.WriteLine("--- Us ve Kok Hesaplama ---");
        Console.Write("Sayi giriniz: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        Console.Write("Kacinci us alinacak: ");
        double us = Convert.ToDouble(Console.ReadLine());
        double ussonuc = Math.Pow(sayi, us);
        Console.WriteLine(sayi + " nin " + us + " ustu = " + ussonuc);

        if (sayi >= 0)
        {
            double kok = Math.Sqrt(sayi);
            Console.WriteLine(sayi + " nin karekoku = " + kok);
        }
        else
        {
            Console.WriteLine("Hata! Negatif sayinin karekoku alinamaz.");
        }
    }

    static void UzunlukDonusturucu()
    {
        Console.Clear();
        Console.WriteLine("--- Uzunluk Donusturucu ---");
        Console.Write("Kilometre giriniz: ");
        double km = Convert.ToDouble(Console.ReadLine());
        double mil = km * 0.621;
        Console.WriteLine(km + " kilometre = " + mil + " mil");
    }

    static void AgirlikDonusturucu()
    {
        Console.Clear();
        Console.WriteLine("--- Agirlik Donusturucu ---");
        Console.Write("Kilogram giriniz: ");
        double kg = Convert.ToDouble(Console.ReadLine());
        double pound = kg * 2.205;
        Console.WriteLine(kg + " kilogram = " + pound + " pound");
    }

    static void AlanHesaplama()
    {
        Console.Clear();
        Console.WriteLine("--- Alan Hesaplama ---");
        Console.WriteLine("1. Kare");
        Console.WriteLine("2. Dikdortgen");
        Console.WriteLine("3. Daire");
        Console.Write("Sekil secin: ");
        int islem = int.Parse(Console.ReadLine());

        if (islem == 1)
        {
            Console.Write("Kenar uzunlugu: ");
            double kenar = Convert.ToDouble(Console.ReadLine());
            double alan = kenar * kenar;
            Console.WriteLine("Kare alani = " + alan + " birimkare");
        }
        else if (islem == 2)
        {
            Console.Write("En: ");
            double en = Convert.ToDouble(Console.ReadLine());
            Console.Write("Boy: ");
            double boy = Convert.ToDouble(Console.ReadLine());
            double alan = en * boy;
            Console.WriteLine("Dikdortgen alani = " + alan + " birimkare");
        }
        else if (islem == 3)
        {
            Console.Write("Yaricap (r): ");
            double r = Convert.ToDouble(Console.ReadLine());
            double alan = 3.14 * r * r;
            Console.WriteLine("Daire alani = " + alan + " birimkare");
        }
        else
        {
            Console.WriteLine("Boyle bir secenek yok!");
        }
    }

    static void YuzdeHesaplama()
    {
        Console.Clear();
        Console.WriteLine("--- Yuzde Hesaplama ---");
        Console.Write("Sayi giriniz: ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        Console.Write("Yuzde kac hesaplansin: ");
        double yuzde = Convert.ToDouble(Console.ReadLine());
        double sonuc = (sayi * yuzde) / 100;
        Console.WriteLine(sayi + " nin yuzde " + yuzde + " si = " + sonuc);
    }
}
