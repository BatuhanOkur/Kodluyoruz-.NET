public class Hayvanlar:Canlilar
{
    protected void KonumDegistir()
    {
        Console.WriteLine("Hayvanlar konum değiştirebilir.");
    }

    public void IletisimKur()
    {
        Console.WriteLine("Hayvanlar kendi aralarında iletişim kurabilir.");
    }

}

public class Surungenler:Hayvanlar
{
    public Surungenler()
    {
        base.KonumDegistir();
        base.BosaltimYap();
        base.SolunumYap();
        base.Ure();
    }
    public void Surun()
    {
        Console.WriteLine("Sürüngenler sürünerek hareket eder.");
    }
}

public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.KonumDegistir();
        base.BosaltimYap();
        base.SolunumYap();
        base.Ure();
    }
    public void Uc()
    {
        Console.WriteLine("Kuşlar uçar.");
    }
}

