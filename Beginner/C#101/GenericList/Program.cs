//List<T> class
//System.Collections.Generic
// T -> object türü

List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);

List<string> renkListesi = new List<string>();

renkListesi.Add("Yesil");
renkListesi.Add("Mor");
renkListesi.Add("Mavi");
renkListesi.Add("Kırmızı");
renkListesi.Add("Turuncu");
renkListesi.Add("Turkuaz");

//Count
Console.WriteLine(sayiListesi.Count);
Console.WriteLine(renkListesi.Count);

//foreach
foreach (var sayi in sayiListesi)
    Console.WriteLine(sayi);
foreach (var renk in renkListesi)
    Console.WriteLine(renk);

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));

renkListesi.ForEach(renk=>Console.WriteLine(renk));

//listeden eleman çıkarma

sayiListesi.Remove(4);
renkListesi.Remove("Yesil");

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));

renkListesi.ForEach(renk=>Console.WriteLine(renk));

//liste içerisinde arama
if(sayiListesi.Contains(10))
    Console.WriteLine("10 liste içerisinde bulundu");

//eleman ile indexe erişme
Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

//diziyi liste çevirme
string[] hayvanlar = {"Kedi","Köpek","Kuş"};
List<string> hayvanListesi = new List<string>(hayvanlar);

//listeyi temizleme
hayvanListesi.Clear();


// liste içerisinde nesne tutma
List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
Kullanıcılar kullanici1 = new Kullanıcılar();
kullanici1.Isim="Ayse";
kullanici1.Soyisim="Korkmaz";
kullanici1.Yas=21;

Kullanıcılar kullanici2 = new Kullanıcılar();
kullanici2.Isim="Berat";
kullanici2.Soyisim="Safran";
kullanici2.Yas=21;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar(){
    Isim="Deniz",
    Soyisim="Arda",
    Yas=23
});

foreach (var kullanici in kullaniciListesi)
{
    Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
    Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
    Console.WriteLine("Yas: " + kullanici.Yas);
}

yeniListe.Clear();



public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim{get=>isim; set=> isim = value;}
    public string Soyisim{get=>soyisim; set=> soyisim = value;}
    public int Yas{get=>yas; set=> yas = value;}
}