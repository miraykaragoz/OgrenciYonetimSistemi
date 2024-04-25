namespace OgrenciYonetimSistemi
{
    internal class Program
    {
        static string Sor(string soru)
        {
            Console.Write(soru);
            return Console.ReadLine();
        }

        class Ogrenci
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
            public int OgrenciNumarasi { get; set; }
            public int DogumTarihi { get; set; }
            public string Cinsiyet { get; set; }
        }

        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        static Ogrenci? OgrenciBul(string arananAd)
        {
            Ogrenci? bulunanOgrenci = null;

            foreach (var ogrenci in ogrenciler)
            {
                if (arananAd == ogrenci.Ad)
                {
                    bulunanOgrenci = ogrenci;
                    break;
                }
            }

            return bulunanOgrenci;
        }

        static Ogrenci? OgrenciDuzenle(string duzenlenecekOgrenciAdi)
        {
            Ogrenci? duzenlenecekOgrenci = null;

            foreach (var ogrenci in ogrenciler)
            {
                if (duzenlenecekOgrenciAdi == ogrenci.Ad)
                {
                    duzenlenecekOgrenci = ogrenci;
                    break;
                }
            }

            return duzenlenecekOgrenci;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hoş geldiniz");
                Console.WriteLine("1 - Öğrencileri Listele");
                Console.WriteLine("2 - Öğrenci Ekle");
                Console.WriteLine("3 - Öğrenci Ara");
                Console.WriteLine("4 - Öğrenci Düzenle");
                Console.WriteLine("5 - Öğrenci Sil");
                Console.WriteLine("6 - Çıkış");

                int inputSecim = int.Parse(Sor("Seçiminiz: "));

                if (inputSecim == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Listesi");
                    foreach (Ogrenci ogrenci in ogrenciler)
                    {
                        Console.WriteLine($"{ogrenci.Ad} {ogrenci.Soyad} \nYaş: {ogrenci.Yas} \nÖğrenci Numarası: {ogrenci.OgrenciNumarasi} \nDoğum Tarihi: {ogrenci.DogumTarihi} \nCinsiyet: {ogrenci.Cinsiyet}");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Ekle");
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Ad = Sor("Ad: ");
                    ogrenci.Soyad = Sor("Soyad: ");
                    ogrenci.Yas = int.Parse(Sor("Yaş: "));
                    ogrenci.OgrenciNumarasi = int.Parse(Sor("Öğrenci Numarası: "));
                    ogrenci.DogumTarihi = int.Parse(Sor("Doğum Tarihi: "));
                    ogrenci.Cinsiyet = Sor("Cinsiyet: ");

                    ogrenciler.Add(ogrenci);
                }
                else if (inputSecim == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci ara");
                    string inputArananOgrenci = Sor("Adı: ");

                    Ogrenci? arananOgrenci = OgrenciBul(inputArananOgrenci);

                    if (arananOgrenci != null)
                    {
                        Console.WriteLine("Öğrenciyi buldum!");
                        Console.WriteLine($"{arananOgrenci.Ad} {arananOgrenci.Soyad} \nYaş: {arananOgrenci.Yas} \nÖğrenci Numarası: {arananOgrenci.OgrenciNumarasi} \nDoğum Tarihi: {arananOgrenci.DogumTarihi} \nCinsiyet: {arananOgrenci.Cinsiyet}");
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir öğrenci bulunamadı!");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Düzenle");
                    string düzenlenecekOgrenci = Sor("Düzenlemek istediğiniz öğrencinin adı: ");

                    Ogrenci? duzenlenecekOgrenci = OgrenciDuzenle(düzenlenecekOgrenci);

                    if (duzenlenecekOgrenci != null)
                    {
                        Console.WriteLine("Öğrenci bulundu!");
                        Console.WriteLine($"{duzenlenecekOgrenci.Ad} {duzenlenecekOgrenci.Soyad} \nYaş:{duzenlenecekOgrenci.Yas} \nÖğrenci Numarası: {duzenlenecekOgrenci.OgrenciNumarasi} \nDoğum Tarihi: {duzenlenecekOgrenci.DogumTarihi} \nCissiyet: {duzenlenecekOgrenci.Cinsiyet}");

                        duzenlenecekOgrenci.Ad = Sor("Yeni ad: ");
                        duzenlenecekOgrenci.Soyad = Sor("Yeni soyad: ");
                        duzenlenecekOgrenci.Yas = int.Parse(Sor("Yeni yaş: "));
                        duzenlenecekOgrenci.OgrenciNumarasi = int.Parse(Sor("Yeni Öğrenci Numarası: "));
                        duzenlenecekOgrenci.DogumTarihi = int.Parse(Sor("Yeni Doğum Tarihi: "));
                        duzenlenecekOgrenci.Cinsiyet = Sor("Yeni Cinsiyet: ");

                    }
                    else
                    {
                        Console.WriteLine("Böyle bir öğrenci bulunamadı!");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else if (inputSecim == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Öğrenci Sil");
                    string inputArananOgrenci = Sor("Silmek istediğiniz öğrencinin adı: ");

                    Ogrenci? arananOgrenci = OgrenciBul(inputArananOgrenci);

                    if (arananOgrenci != null)
                    {
                        ogrenciler.Remove(arananOgrenci);
                        Console.WriteLine("Öğrenci Silindi!");
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir öğrenci bulunamadı!");
                    }

                    Console.WriteLine("\nDevam etmek için bir tuşa basın");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
            }
        }
    }
}
