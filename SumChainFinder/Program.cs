#nullable disable

while (true)
{
    Console.WriteLine("Bu algoritma verilen sayı dizisinin birbiri ile toplamı sonucunu gösterir");
    Console.WriteLine();

    Console.WriteLine("Lütfen gireceğiniz sayı değerlerini virgül ile ayırınız.");
    Console.WriteLine();

    string[] values = Console.ReadLine().Split(',');

    int total = 0;
    foreach (var item in values)
    {
        if (int.TryParse(item, out int number))
        {
            total += number;
        }
        else
        {

        }
    }

    Console.WriteLine($"Girilen sayıların toplamı: {total}");
    Console.WriteLine();
}
