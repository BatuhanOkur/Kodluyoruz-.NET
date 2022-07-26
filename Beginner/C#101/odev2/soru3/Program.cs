using System.Text.RegularExpressions;

Console.WriteLine("Bir cümle giriniz!");
string cumle = Console.ReadLine();

Regex rgx = new Regex(@"[aeouiöüAEOUİÖÜ]");
MatchCollection sesliHarfler = rgx.Matches(cumle);

foreach (var harf in sesliHarfler)
{
    Console.WriteLine(harf);
}