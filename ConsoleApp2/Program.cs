List<string> adlar = new List<string>()
{
    "ahmet",
    "ali",
    "ayşe",
    "oya",
    "orhan",
    "mehmet",
    "selin",
};

// Tüm LINQ metotları IEnumerable türü üzerinde tanımlıdır.

IEnumerable<string> sonuc = adlar.Where(x => x.EndsWith("n"));

Console.WriteLine(string.Join(" <-> ", sonuc));

Console.WriteLine();

foreach (string oge in sonuc)
{
    Console.WriteLine(oge);
}

Console.ReadKey();

