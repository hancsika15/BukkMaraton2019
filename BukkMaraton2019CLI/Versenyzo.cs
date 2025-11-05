internal class Versenyzo
{
    public string Rajtszam { get; set; }
    public string Kategoria { get; set; }
    public string Nev { get; set; }
    public string? Egyesulet { get; set; }
    public TimeSpan Ido { get; set; }
    public string Tav => new Versenytav(Rajtszam).Tav;

    public Versenyzo(string rajtszam, string kategoria, string nev, string egyesulet, TimeSpan ido)
    {
        Rajtszam = rajtszam;
        Kategoria = kategoria;
        Nev = nev;
        Egyesulet = egyesulet;
        Ido = ido;
    }

    public override string ToString() =>
        $"\tRajtszam: {Rajtszam}\n" +
        $"\tNév: {Nev}\n" +
       $"{(Egyesulet is null ? null : $"\tEgyesület: {Egyesulet}\n")}" +
        $"\tIdő: {Ido}";
}

