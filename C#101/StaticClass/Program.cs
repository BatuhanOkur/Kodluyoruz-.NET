
Console.WriteLine("Şirketin Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
Calisan calisan1 = new Calisan("Anıl","Elmastaşı","IT");
Console.WriteLine("Şirketin Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
Calisan calisan2 = new Calisan("Batuhan","Okur","Ik");
Calisan calisan3 = new Calisan("Serkan","Okur","xx");
Console.WriteLine("Şirketin Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

Console.WriteLine(Islemler.Cikar(3,2));
Console.WriteLine(Islemler.Topla(5,3));
class Calisan
{
    private static int _calisanSayisi;
    private string _isim;
    private string _soyisim;
    private string _departman;
    public static int CalisanSayisi { get => _calisanSayisi;}

    static Calisan()
    {
        _calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this._isim = isim;
        this._soyisim = soyisim;
        this._departman = soyisim;
        _calisanSayisi++;
    }
}

static class Islemler
{
    public static long Topla(int x, int y)
    {
        return x+y;
    }

    public static long Cikar(int x, int y)
    {
        return x-y;
    }
}