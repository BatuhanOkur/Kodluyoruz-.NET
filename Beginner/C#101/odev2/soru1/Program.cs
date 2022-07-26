
using System.Collections;

ArrayList sayilar = new ArrayList();
int length = 0;

while(length < 20)
{
    Console.WriteLine("{0}. pozitif sayiyi girin: ", length+1);
    try
    {
        int sayi = Convert.ToInt32(Console.ReadLine());
        if(sayi<0)
        {
            Console.WriteLine("Negatif sayi girisi yapilamaz!!!");
            continue;
        }
        sayilar.Add(sayi);
        length++;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Bir sayi girmelisiniz.");
    }
}

ArrayList asalSayilar = new ArrayList();
ArrayList asalOlmayanSayilar = new ArrayList();


foreach (int item in sayilar)
{
    if(isPrime(item))
        asalSayilar.Add(item);
    else
        asalOlmayanSayilar.Add(item);
}


Console.WriteLine("*** Asal Sayıların Büyükten Küçüğe Sıralanışı ***");
asalSayilar.Sort();
asalSayilar.Reverse();
foreach (var sayi in asalSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("*** Asal Olmayan Sayıların Büyükten Küçüğe Sıralanışı ****");
asalOlmayanSayilar.Sort();
asalOlmayanSayilar.Reverse();
foreach (var sayi in asalOlmayanSayilar)
{
    Console.WriteLine(sayi);
}

 Console.WriteLine("***** Asal Sayıların Ortalaması *******");
mean(asalSayilar);

 Console.WriteLine("***** Asal Olmayan Sayıların Ortalaması *******");
mean(asalOlmayanSayilar);

static bool isPrime(int sayi)
{
    if (sayi == 2)
        return true;
    else if (sayi == 1)
        return false;

    int sqrt = (int)Math.Ceiling(Math.Sqrt(sayi));

    for (int i = 2; i <= sqrt; i++)
    {
        if (sayi % i == 0)
        return false;
    }
    return true;
}

static void mean(ArrayList liste)
{
    int sum = 0;
    foreach (var item in liste)
    {
        sum += (int)item;
    }
    Console.WriteLine("Ortalama: {0}", sum/liste.Count);
}