using System.Collections;
public class Islemler
{
public static Hashtable NumaraKaydet(Hashtable kisiler)
{
    Console.WriteLine("Ad Soyad Girin:");
    string isim = Console.ReadLine();

    Console.WriteLine("Numara Girin:");
    int numara = Convert.ToInt32(Console.ReadLine());
    Rehber kisi = new Rehber(isim, numara);

    kisiler.Add(kisi.FullName, kisi.No);
    return kisiler;
}

public static Hashtable KisiSil(Hashtable kisiler)
{
    Console.WriteLine("Silinecek kişinin adını soyadını giriniz: ");
    string aranacak = Console.ReadLine();
    if(kisiler.ContainsKey(aranacak))
    {
        kisiler.Remove(aranacak);
        return kisiler;
    }
    else
    {
        Console.WriteLine(@"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
* Silmeyi sonlandırmak için : (1)
* Yeniden denemek için      : (2)");
        int islem = Convert.ToInt32(Console.ReadLine());
        if (islem == 2)
            KisiSil(kisiler);
        return kisiler;
    }
    
}


public static Hashtable NumaraGuncelle(Hashtable kisiler)
{
    Console.WriteLine("Guncellenecek kişinin adını soyadını giriniz: ");
    string aranacak = Console.ReadLine();
    if(kisiler.ContainsKey(aranacak))
    {
        Console.WriteLine(aranacak + " isimli kişinin yeni numarasını giriniz: ");
        int yeniNumara = Convert.ToInt32(Console.ReadLine());
        kisiler[aranacak] = yeniNumara;
        return kisiler;
    }
    else
    {
        Console.WriteLine(@"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
* Güncellemeyi sonlandırmak için : (1)
* Yeniden denemek için      : (2)");
        int islem = Convert.ToInt32(Console.ReadLine());
        if (islem == 2)
            NumaraGuncelle(kisiler);
        return kisiler;
    }
  
}

public static void RehberiListele(Hashtable kisiler)
{
    Console.WriteLine("Telefon Rehberi");
    Console.WriteLine("**********************************************");
    foreach (var key in kisiler.Keys) 
    {
        Console.WriteLine("Kişi: {0} No: {1}",key , kisiler[key]);
    }
}

public static void AramaYap(Hashtable kisiler)
{
    Console.WriteLine(@"İsim veya soyisme göre arama yap (1)
    * Numaraya göre arama yap(2) ");
    Console.WriteLine("Arama yapmak istediğiniz türü seçin: (1/2)");
    int secim = Convert.ToInt32(Console.ReadLine());
    if(secim == 1)
    {
        Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin ad soyadını giriniz:");
        string aranan = Console.ReadLine();

        if(kisiler.ContainsKey(aranan))
        {
            Console.WriteLine("{0} kişisinin numarası: {1}", aranan, kisiler[aranan]);
        }
        else
        {
            Console.WriteLine(@"Aradığınız krtiterlere uygun isim rehberde bulunamadı. Lütfen bir seçim yapınız.
* Çıkış yapmak için   : (1)
* Yeniden denemek için      : (2)");
            int cikis = Convert.ToInt32(Console.ReadLine());
            if(cikis == 2)
                AramaYap(kisiler);
            
        }
    }
    else if(secim == 2)
    {
        Console.WriteLine("Lütfen ismini aramak istediğiniz kişinin numarasını giriniz:");
        object arananNo = Convert.ToInt32(Console.ReadLine());
        object key = null;
        foreach (DictionaryEntry entry in kisiler)
        {
            if (entry.Value == arananNo)
            {
                key = entry.Key;
                break;
            }
        }

        if(key is null)
        {
            Console.WriteLine("Aradığınız numaraya ait isim bulunamadı!");
        }
        else
        {
            Console.WriteLine("Aradığınız numara: {0} Numaranın Sahibi: {1}",arananNo, key);
        }

        
    }
    else
    {
        Console.WriteLine("Yanlış seçim yaptınız, 1 veya 2'yi seçmelisiniz!");
        AramaYap(kisiler);
    }
}

}