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

List<string> sonuc = adlar.Where(ad => ad.Length == 5).ToList();

Console.WriteLine(string.Join("<>", sonuc));

Console.ReadKey();