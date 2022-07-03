//system.collection.generic

Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
kullanicilar.Add(10,"Ayşe Yılmaz");
kullanicilar.Add(100,"Berat Safran");
kullanicilar.Add(18,"Yusufi Çimenci");

//dictionary eleman erişimi
Console.WriteLine("*** eleman erişimi *****");
Console.WriteLine(kullanicilar[100]);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item);
}

// count
Console.WriteLine("*** count *****");
Console.WriteLine(kullanicilar.Count);

//contains
Console.WriteLine("*** contains *****");
Console.WriteLine(kullanicilar.ContainsKey(12));
Console.WriteLine(kullanicilar.ContainsValue("Berat Safran"));


//remove
Console.WriteLine("*** remove *****");
kullanicilar.Remove(18);
foreach (var item in kullanicilar)
{
    Console.WriteLine(item.Value);
}

//keys
Console.WriteLine("*** keys *****");
foreach (var item in kullanicilar.Keys)
{
    Console.WriteLine(item);
}

//values
Console.WriteLine("*** values *****");
foreach (var item in kullanicilar.Values)
{
    Console.WriteLine(item);
}