using zene;
using System.IO;
using System.Text;

List<Zeneiadok> radiok;

void FajlBeolvasas(string fajlNev)
{
    radiok = new List<Zeneiadok>();
    radiok.Add(new Zeneiadok(1));
    radiok.Add(new Zeneiadok(2));
    radiok.Add(new Zeneiadok(3));
    foreach (var sor in File.ReadAllLines(fajlNev).Skip(1))
    {
        var data = sor.Split();
        byte radioAdo = byte.Parse(data[0]);
        byte perc = byte.Parse(data[1]);
        byte masodperc = byte.Parse(data[2]);
        StringBuilder szam = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            szam.Append(data[i]);
        }
        string eloado = szam.ToString().Split(":")[0];
        string zene = szam.ToString().Split(":")[1];

        radiok[radioAdo - 1].ZeneLista.Add(new Zenek(eloado, zene, perc, masodperc));
    }
}

FajlBeolvasas("musor.txt");
Console.WriteLine("2. feladat");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}. adó: {radiok[i].ZeneLista.Count} db szám");
}


Console.WriteLine();