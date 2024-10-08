while (true)
{
    // Lokasyon ve fiyat bilgileri
    int locationPrice = 0;
    string locationName = "";

    // Lokasyon seçimi
    Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris veya Çeşme");
    string location = Console.ReadLine().ToLower();

    // Lokasyon kontrolü ve fiyat ataması
    switch (location)
    {
        case "bodrum":
            locationPrice = 4000;
            locationName = "Bodrum";
            break;
        case "marmaris":
            locationPrice = 3000;
            locationName = "Marmaris";
            break;
        case "cesme":
            locationPrice = 5000;
            locationName = "Çeşme";
            break;
        default:
            Console.WriteLine("Hatalı lokasyon girdiniz. Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme");
            continue;
    }

    // Kişi sayısı
    Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
    if (!int.TryParse(Console.ReadLine(), out int personCount) || personCount <= 0)
    {
        Console.WriteLine("Geçerli bir sayı giriniz.");
        continue;
    }

    // Ulaşım seçimi
    Console.WriteLine("Nasıl bir ulaşım aracı seçmek istersiniz? \n1 - Kara yolu (1500 TL kişi başı) \n2 - Hava yolu (4000 TL kişi başı)");
    int transportPrice = 0;
    string transportType = "";
    switch (Console.ReadLine())
    {
        case "1":
            transportPrice = 1500;
            transportType = "Kara yolu";
            break;
        case "2":
            transportPrice = 4000;
            transportType = "Hava yolu";
            break;
        default:
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 veya 2 olarak bir seçim yapınız.");
            continue;
    }

    // Toplam fiyat hesaplama
    int totalPrice = (locationPrice + transportPrice) * personCount;
    Console.WriteLine($"\n{locationName} lokasyonuna {transportType} ile {personCount} kişi için toplam tatil maliyetiniz: {totalPrice} TL");

    // Tekrar planlama isteği
    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet için 'e', Hayır için 'h')");
    if (Console.ReadLine().ToLower() == "h")
    {
        Console.WriteLine("İyi günler!");
        break;
    }
}
