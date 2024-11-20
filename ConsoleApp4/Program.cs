int[] dizi = { 5, 8, 2, 3, 4, 7, 10 };

double ort = dizi.Average();

Console.WriteLine("ORTALAMA= " + ort);
Console.WriteLine("TOPLAM  = " + dizi.Sum());


int toplam = dizi.Where(x => x % 2 == 0).Sum();
Console.WriteLine("ÇİFTLER TOPLAMI = " + toplam);

// 5'den küçük sayıların kareleri toplamı
Console.Write("5'DEN KÜÇÜK SAYILARIN TOPLAMI: ");
// Console.WriteLine(dizi.Where(x => x < 5).Sum(x => x * x));
Console.WriteLine(dizi.Where(x => x < 5).Sum(Karesi));

int Karesi(int sayi)
{
    return sayi * sayi;
}

Console.Write("KÜPLERİ: ");
// sayıların küplerini içeren yeni dizi
double[] kupleri = dizi.Select(x => Math.Pow(x, 3)).ToArray();

// Console.WriteLine(string.Join(" - ", kupleri));
foreach (int i in kupleri)
    Console.Write(i + " ");

Console.WriteLine();


Console.WriteLine("EN KÜÇÜĞÜ: " + dizi.Min());
Console.WriteLine("EN BÜYÜĞÜ: " + dizi.Max());




Console.ReadKey();