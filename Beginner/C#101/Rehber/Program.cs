using System.Collections;

Hashtable rehber = new Hashtable();
rehber.Add("Batuhan Okur", 12345);
rehber.Add("Süleyman Okur", 313131);
rehber.Add("Serkan Okur", 131313);
rehber.Add("Yasemin Arslan", 1414141);

while(true)
{
    Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçiniz : 
(1) Yeni Numara Kaydetmek
(2) Varolan Numarayı Silmek
(3) Varolan Numarayı Güncelleme
(4) Rehberi Listelemek
(5) Rehberde Arama Yapmak
(6) Çıkış");
    int secim = Convert.ToInt32(Console.ReadLine());
    if (secim == 1)
        rehber = Islemler.NumaraKaydet(rehber);
    else if (secim == 2)
        Islemler.KisiSil(rehber);
    else if (secim == 3)
        Islemler.NumaraGuncelle(rehber);
    else if (secim == 4)
        Islemler.RehberiListele(rehber);
    else if (secim == 5)
        Islemler.AramaYap(rehber);
    else if (secim == 6)
        break;
    
}

