List<Rehber> kisiler = new List<Rehber>();
Rehber kisi1 = new Rehber("Kaan","Bakan",31);
kisiler.Add(kisi1);
Rehber kisi2 = new Rehber("Anıl","Elmastaşı",5241);
kisiler.Add(kisi2);
Rehber kisi3 = new Rehber("Cem","Güzer",5671);
kisiler.Add(kisi3);
Rehber kisi4 = new Rehber("Alikemal","Atay",5471);
kisiler.Add(kisi4);
Rehber kisi5 = new Rehber("Batuhan","Okur",4816);
kisiler.Add(kisi5);

// (1) Yeni Numara Kaydetmek
// (2) Varolan Numarayı Silmek
// (3) Varolan Numarayı Güncelleme
// (4) Rehberi Listelemek
// (5) Rehberde Arama Yapmak
// (6) Çıkış

while(true)
{
    Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçiniz : 
(1) Yeni Numara Kaydetmek
(2) Varolan Numarayı Silmek
(3) Varolan Numarayı Güncelleme
(4) Rehberi Listelemek
(5) Rehberde Arama Yapmak
(6) Çıkış");
    int islem = Convert.ToInt32(Console.ReadLine());
    if (islem == 1)
        kisiler = NumaraKaydet(kisiler);
    else if (islem == 2)
        KisiSil(kisiler);
    else if (islem == 3)
        NumaraGuncelle(kisiler);
    else if (islem == 4)
        RehberiListele(kisiler);
    else if (islem == 5)
        AramaYap(kisiler);
    else if (islem == 6)
        break;
    
}

static List<Rehber> NumaraKaydet(List<Rehber> liste)
{
    Console.WriteLine("Ad Girin:");
    string isim = Console.ReadLine();

    Console.WriteLine("Soyad Girin:");
    string soyisim = Console.ReadLine();

    Console.WriteLine("Numara Girin:");
    int numara = Convert.ToInt32(Console.ReadLine());

    liste.Add(new Rehber(isim,soyisim,numara));
    return liste;
}

static List<Rehber> KisiSil(List<Rehber> liste)
{
    Console.WriteLine("Silinecek kişinin adını ya da soyadını giriniz: ");
    string aranacak = Console.ReadLine();

    int count = liste.Count;

    for (int i = 0; i < count; i++)
    {
        if(liste[i].Ad.Contains(aranacak,StringComparison.OrdinalIgnoreCase) || liste[i].Soyad.Contains(aranacak,StringComparison.OrdinalIgnoreCase) )
        {
            Console.WriteLine(liste[i].No + " numaralı " + liste[i].Ad + " " + liste[i].Soyad + " isimli kişiyi rehberden silmeyi onaylıyor musunuz ?(y/n)");
            string confirm = Console.ReadLine().ToLower();
            if (confirm == "y")
            {
                liste.RemoveAt(i);
                return liste;
            }
        } 
    }

    Console.WriteLine(@"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
* Silmeyi sonlandırmak için : (1)
* Yeniden denemek için      : (2)");
    int islem = Convert.ToInt32(Console.ReadLine());
    if (islem == 2)
        KisiSil(liste);
    return liste;
}

static List<Rehber> NumaraGuncelle(List<Rehber> liste)
{
    Console.WriteLine("Güncellenecek kişinin adını ya da soyadını giriniz: ");
    string aranacak = Console.ReadLine();

    int count = liste.Count;

    for (int i = 0; i < count; i++)
    {
        if(liste[i].Ad.Contains(aranacak,StringComparison.OrdinalIgnoreCase) || liste[i].Soyad.Contains(aranacak,StringComparison.OrdinalIgnoreCase) )
        {
            Console.WriteLine(liste[i].Ad + " " + liste[i].Soyad + " isimli kişinin yeni numarasını giriniz: ");
            int yeniNumara = Convert.ToInt32(Console.ReadLine());
            liste[i].No = yeniNumara;
            Console.WriteLine("Numara başarıyla güncellendi!");
            return liste; 
        } 
    }

        Console.WriteLine(@"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
* Silmeyi sonlandırmak için : (1)
* Yeniden denemek için      : (2)");
        int islem = Convert.ToInt32(Console.ReadLine());
        if (islem == 2)
            NumaraGuncelle(liste);
        return liste;
}

static void RehberiListele(List<Rehber> liste)
{
    Console.WriteLine("Telefon Rehberi");
    Console.WriteLine("**********************************************");

    foreach (var kisi in liste)
    {
    Console.WriteLine("isim: " + kisi.Ad);
    Console.WriteLine("Soyisim: " + kisi.Soyad);
    Console.WriteLine("Telefon Numarası: " + kisi.No);
    Console.WriteLine("********************************************************************");
    }
}

static void AramaYap(List<Rehber> liste)
{
    Console.WriteLine(@"İsim veya soyisme göre arama yap (1)
    * Numaraya göre arama yap(2) ");
    Console.WriteLine("Arama yapmak istediğiniz türü seçin: (1/2)");
    int secim = Convert.ToInt32(Console.ReadLine());
    if(secim == 1)
    {
        Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz:");
        string aranan = Console.ReadLine();

        for (int i = 0; i < liste.Count; i++)
        {
            if (liste[i].Ad.Contains(aranan, StringComparison.OrdinalIgnoreCase) || liste[i].Soyad.Contains(aranan, StringComparison.OrdinalIgnoreCase))
            {
            Console.WriteLine("isim: " + liste[i].Ad);
            Console.WriteLine("Soyisim: " + liste[i].Soyad);
            Console.WriteLine("Telefon Numarası: " + liste[i].No);
            Console.WriteLine("-------");
            }
        }
    }
    else if(secim == 2)
    {
        Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin numarasını giriniz:");
        string arananNo = Console.ReadLine();
        for (int i = 0; i < liste.Count; i++)
        {
            if (liste[i].No.ToString().Contains(arananNo))
            {
                Console.WriteLine("isim: " + liste[i].Ad);
                Console.WriteLine("Soyisim: " + liste[i].Soyad);
                Console.WriteLine("Telefon Numarası: " + liste[i].No);
                Console.WriteLine("-------");
            }
        }
    }
    else
    {
        Console.WriteLine("Yanlış seçim yaptınız, 1 veya 2'yi seçmelisiniz!");
        AramaYap(liste);
    }
}



class Rehber
{
    private string ad;
    private string soyad;
    private int no;

    public string Ad { get => ad; set => ad = value; }
    public string Soyad { get => soyad; set => soyad = value; }
    public int No { get => no; set => no = value; }

    public Rehber(string ad, string soyad, int no = 0)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.no = no;
    }


    
}