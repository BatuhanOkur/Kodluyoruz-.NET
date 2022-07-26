//System.Collections namespace

using System.Collections;

ArrayList liste = new ArrayList();
// liste.Add("Ayse");
// liste.Add(2);
// liste.Add(true);
// liste.Add("a");

//verilere erişim
// Console.WriteLine(liste[1]);
// foreach (var item in liste)
// {
//     Console.WriteLine(item);
// }

//Addrange

Console.WriteLine("***** Add Range ************");
// string[] renkler = {"kırmızı","sarı","yesil"};
List<int> sayilar = new List<int>(){1,8,3,5,7,6};

// liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

//Sort

Console.WriteLine("**** Sort ******");

liste.Sort();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

// binary search

Console.WriteLine("**** Binary Search ******");
Console.WriteLine(liste.BinarySearch(8));

//reverse
Console.WriteLine("**** reverse ******");
liste.Reverse();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//clear
Console.WriteLine("**** clear ******");
liste.Clear();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

