public class Canlilar
{
    protected void SolunumYap()
    {
        Console.WriteLine("Canlılar solunum yapar.");
    }

    protected void Ure()
    {
        Console.WriteLine("Canlılar ürer.");
    }

    protected void BosaltimYap()
    {
        Console.WriteLine("Canlılar boşaltım yapar.");
    }

    public virtual void TepkiVer()
    {
        Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
}

// "public sealed class Canlilar" olarak tanımlasaydım Canlılar sınıfından hiçbir sınıf kalıtılamazdı.