internal class Versenyzo
{
    public string Rajtszam { get; set; }
    public string Kategoria { get; set; }
    public string Nev { get; set; }
    public string? Egyesulet { get; set; }
    public TimeSpan Ido { get; set; }
    public string Tav { get; }

    public Versenyzo(string sor)
    {
        var v = sor.Split(';');
        Rajtszam = v[0];
        Kategoria = v[1];
        Nev = v[2];
        Egyesulet = v[3] is null ? null : v[3];
        Ido = TimeSpan.Parse(v[4]);
        Tav = new Versenytav(Rajtszam).Tav;
    }

    public override string ToString() =>
        $"\tRajtszam: {Rajtszam}\n" +
        $"\tNév: {Nev}\n" +
       $"{(Egyesulet is null ? null : $"\tEgyesület: {Egyesulet}\n")}" +
        $"\tIdő: {Ido}";
}

