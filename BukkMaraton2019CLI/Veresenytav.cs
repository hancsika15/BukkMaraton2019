internal class Versenytav
{
    private string rajtszam;
    public string Tav => rajtszam[0] switch
    {
        'M' => "Mini",
        'R' => "Rövid",
        'K' => "Közép",
        'H' => "Hosszú",
        'E' => "Pedelec",
        _ => "Hibás rajtszám",
    };
    public Versenytav(string rajtszam)
    {
        this.rajtszam = rajtszam;
    }
}