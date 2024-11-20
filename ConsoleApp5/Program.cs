using ConsoleApp5;

List<Kisi> kisiler = Veri.Kisiler();
List<Sehir> sehirler = Veri.Sehirler();


// kişileri, doğduğu şehrin adıyla eşleştirerek yeni bir yapıya dönüştür
var sonuc = kisiler.Join(
    sehirler,
    k => k.SehirId,
    s => s.Id,
    (k, s) => new { KisiAd = k.Ad, SehirAd = s.SehirAd }
    );

foreach (var satir in sonuc)
{
    Console.WriteLine(satir.KisiAd + " -> " + satir.SehirAd);
}

Console.WriteLine();

// ANONİM OLMAYAN TÜR İLE SONUÇ
List<KisiSehir> sonuc2 = kisiler.Join(
    sehirler,
    k => k.SehirId,
    s => s.Id,
    (k, s) => new KisiSehir { KisiAd = k.Ad, SehirAd = s.SehirAd }
    )
    .ToList();

foreach (KisiSehir ks in sonuc2)
{
    Console.WriteLine(ks.KisiAd + " -> " + ks.SehirAd);
}

Console.ReadKey();