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
Calisan calisan1 = new Calisan();
calisan1.Ad="Batuhan";
calisan1.Soyad="Okur";
calisan1.No=1231231;
calisan1.Departman="IT";
calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan();
calisan2.Ad="Serkan";
calisan2.Soyad="Okur";
calisan2.No=123176;
calisan2.Departman="IK";
calisan2.CalisanBilgileri();
class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi: {0}", Ad);
        Console.WriteLine("Calisan Soyadi: {0}", Soyad);
        Console.WriteLine("Calisan No: {0}", No);
        Console.WriteLine("Calisan Departman: {0}", Departman);
    }
}