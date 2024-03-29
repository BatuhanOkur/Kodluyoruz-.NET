﻿//Sıralı olan verilerde veya birden fazla sabit değişkene sahipsek enum kullanılabilir.
// Console.WriteLine(Gunler.Carsamba);
// Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik = 35;
if(sicaklik <= (int)HavaDurumu.Normal)
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle");
else if(sicaklik >= (int)HavaDurumu.Sicak)
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
    Console.WriteLine("Dışarıya çıkabilirsin");

enum Gunler
{
    Pazartesi=1,
    Sali,
    Carsamba,
    Persembe,
    Cuma=23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sicak = 25,
    CokSicak = 30
}
