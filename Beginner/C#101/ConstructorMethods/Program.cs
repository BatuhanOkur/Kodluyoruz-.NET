// Söz dizimi
// class SinifAdi
// {
//     {Erişim Belirleyici} {Veri Tipi} OzellikAdi;
//     {Erişim Belirleyici} {Geri Dönüş Tipi} MetotAdi(Parametre Listesi)
//     {
//         Metot Komutları
//     }
    
// }

// Erişim belirleyiciler: Public, private, internal, protected
Calisan calisan1 = new Calisan("Batuhan","Okur",1231231, "IT");
calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan("Serkan","Okur",123176,"IK");
calisan2.CalisanBilgileri();

Calisan calisan3 = new Calisan("Anil","Elmastasi");
calisan3.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }


    public Calisan(){}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi: {0}", Ad);
        Console.WriteLine("Calisan Soyadi: {0}", Soyad);
        Console.WriteLine("Calisan No: {0}", No);
        Console.WriteLine("Calisan Departman: {0}", Departman);
    }

    
}

