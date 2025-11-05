internal class Program
{
    private static void Main(string[] args)
    {
        List<Versenyzo> resztvevok = [];
        using StreamReader sr = new("C:\\Users\\72581493312\\source\\repos\\BukkMaraton2019\\BukkMaraton2019CLI\\Source\\bukkm2019.txt");

        _ = sr.ReadLine();
        while (!sr.EndOfStream) {

            var line = sr.ReadLine().Split(';');
            resztvevok.Add(new(
                rajtszam: line[0],
                kategoria: line[1],
                nev: line[2],
                egyesulet: line[3],
                ido: TimeSpan.ParseExact(line[4],"h:mm:ss", null)
            ));
            Console.WriteLine(resztvevok[^1]);
        }
    }
}