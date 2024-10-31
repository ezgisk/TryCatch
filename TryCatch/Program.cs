try
{
    Console.WriteLine("Lutfen bir sayi giriniz:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Girdiginiz sayinin karesi:{ Math.Pow(number,2)}");
    Console.WriteLine($"Girdiginiz sayinin karekoku:{Math.Sqrt(number)}");
}
catch
{
    Console.WriteLine("Hata: Sayı formatı geçersiz. Lütfen doğru formatta bir sayı giriniz.");//Hata yapilirsa gosterilir
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");//Her zaman calisir
}
Console.ReadKey();