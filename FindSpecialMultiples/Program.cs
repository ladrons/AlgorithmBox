#nullable disable

bool success = false;

while (!success)
{
    Console.WriteLine("Bu algoritmada girilen sayının, 3 ve 5 katları tespit ediliyor ve ilgili sayıların yerlerine 'Fizz', 'Buzz' ve 'FizzBuzz' ifadesi yazılıyor.");
    Console.WriteLine();

    Console.WriteLine("Lüten bir sayı giriniz. (Örnek: 15)");
    Console.WriteLine();

    if (int.TryParse(Console.ReadLine(), out int number))
    {
        fizzBuzz(number);
        Console.WriteLine();
    }
    else
    {
        Console.Clear();

        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        Console.WriteLine();
    }
}

//----- Methods -----\\

void fizzBuzz(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
            continue;
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
            continue;
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
            continue;
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}