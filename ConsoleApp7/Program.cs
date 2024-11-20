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

// adının uzunluğu 5 olanları yeni bir listeye aktar
List<string> liste2 = adlar.Where(UzunluguBesMi).ToList();

bool UzunluguBesMi(string metin)
{
    return metin.Length == 3;
}

//List<string> liste2 = new List<string>();

//foreach (string a in adlar)
//{
//    if (a.Length == 5)
//    {
//        liste2.Add(a);
//    }
//}

Console.WriteLine(string.Join("-", liste2));

Console.ReadKey();