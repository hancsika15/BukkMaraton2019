using System.Text;

const int IndulokSzama = 691;

List<Versenyzo> versenyzok = [];
using StreamReader sr = new("..\\..\\..\\Source\\bukkm2019.txt", Encoding.UTF8);

_ = sr.ReadLine();
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));


Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: " +
    $"{ 100- versenyzok.Count / (float)IndulokSzama * 100:0.00}%");


var f5 = versenyzok.Count(v => v.Tav == "Rövid" && v.Kategoria[^1] == 'n');
Console.WriteLine($"5. feladat: Női versenyzők száma a rövid távú versenyen: {f5}fő");

bool f6 = versenyzok.Any(v => v.Ido.TotalHours > 6);
Console.WriteLine(
    $"6. feladat: {(f6 ? "Volt ilyen versenyző" : "Nem volt ilyen versenyző")}");


Versenyzo f7 = versenyzok
    .Where(v => v.Tav == "Rövid" && v.Kategoria == "ff")
    .MinBy(v => v.Ido);

Console.WriteLine($"7.feladat: A felnőtt férfi (ff) kaegoria győzteste rövid távon\n {f7}");