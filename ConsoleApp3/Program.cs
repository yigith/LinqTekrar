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

// y harfi içerenlerin listesi
var sonuc1 = adlar.Where(ad => ad.Contains("y")).ToList();

// sonucu aralarına boşluk koyarak yazdır
Console.WriteLine("Y HARFİNİ İÇERENLER:");
Console.WriteLine(string.Join(" ", sonuc1));

Console.ReadKey();