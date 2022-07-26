Ogrenci ogrenci1 = new Ogrenci("Serkan","Okur",45,1);
ogrenci1.OgrenciBilgileriniGetir();
ogrenci1.SinifDusur();
ogrenci1.OgrenciBilgileriniGetir();



class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir");
                sinif = 1;
            }
            else
                sinif = value;
        }
    }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***** Ogrenci Bilgileri ************");
        Console.WriteLine("Ogrenci Adı: {0}",this.isim);
        Console.WriteLine("Ogrenci Soyadı: {0}",this.soyisim);
        Console.WriteLine("Ogrenci No: {0}",this.ogrenciNo);
        Console.WriteLine("Ogrenci Sınıfı: {0}",this.sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif++;
    }

    public void SinifDusur()
    {
        this.Sinif--;
    }
}

