public class Bitkiler:Canlilar
{
    protected void FotosentezYap()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }

    public override void TepkiVer()
    {
        // base.TepkiVer();
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }
}

public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler()
    {
        base.FotosentezYap();
        base.BosaltimYap();
        base.SolunumYap();
        base.Ure();
        base.TepkiVer();
    }
    public void TohumlaCogal()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
}

public class TohumsuzBitkiler:Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.FotosentezYap();
        base.BosaltimYap();
        base.SolunumYap();
        base.Ure();
    }
    public void SporlaCogal()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}