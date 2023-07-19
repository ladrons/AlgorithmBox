﻿using AlgorithmBox.MathAlgorithms;
using AlgorithmBox.StringAlgorithms;

#nullable disable

bool success = false;

while (!success)
{
    Console.WriteLine("Algoritma Kutusuna Hoşgeldin. Lütfen listeden bir işlem seçiniz. (Seçim sayı ile yapılmaktadır)");
    Console.WriteLine();

    Console.WriteLine("1- Tekrar eden harfleri bulma");
    Console.WriteLine("2- Girilen sayının 3 ve 5 katlarını bulma ve işaretleme");
    Console.WriteLine("3- DÜZENLENİYOR");
    Console.WriteLine("4- DÜZENLENİYOR");

    Console.WriteLine();

    string menuSelectValue = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(menuSelectValue)) ShowWarnings("Lütfen listedeki işlemlerin sayıları ile seçim yapınız.");
    else
    {
        switch (menuSelectValue)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("İçerisinde aynı harflerden olan bir string değer giriniz. ÖRNEK: 'leblebi' ");
                Console.WriteLine();

                FirstAlgorithm(Console.ReadLine());

                AskForRestartOrExit();
                break;

            case "2":
                Console.WriteLine();
                Console.WriteLine("Lütfen bir sayı giriniz. Algoritmanın mantıklı çalışması için girilmesi gereken en küçük sayı: 15");
                Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    FindSpecialMultiples.fizzBuzz(number);
                }
                else
                {
                    ShowWarnings("Lütfen geçerli bir sayı değeri girin.");

                }
                AskForRestartOrExit();
                break;

            case "3":
                Console.Clear();
                break;

            case "4":
                Console.Clear();
                break;

            default:
                ShowWarnings("Geçerli bir değer girmelisiniz");
                break;
        }
    }
}

//İşlemler bittikten sonra başa dönmeyi sağlayan metod.
void AskForRestartOrExit()
{
    Console.WriteLine();
    Console.WriteLine("Başa dönmek için 'y' / Çıkmak için herhangi bir tuş");
    Console.WriteLine();

    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.Y)
    {
        success = false;

        Console.Clear();
    }
    else
    {
        success = true;
    }
}

//Hata mesajlarını gösteren metod.
void ShowWarnings(string warningValue)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();

    Console.WriteLine($"{warningValue}");
    Console.WriteLine();

    Console.ResetColor();
}


//------------Algoritmaları temsil eden metodlar-------------//

void FirstAlgorithm(string text)
{
    Dictionary<char, int> duplicateChars = DuplicateCharacterFinder.CountCharOccurrences(DuplicateCharacterFinder.FindDuplicateChars(text));

    Console.WriteLine();
    Console.Write("Tekrar eden harfler: ");

    foreach (var kvp in duplicateChars)
    {
        if (kvp.Value > 1)
        {
            Console.Write(kvp.Key + ", ");
        }
    }
    Console.WriteLine();
    Console.WriteLine();

    foreach (var kvp in duplicateChars)
    {
        Console.WriteLine($"{kvp.Key} harfi {kvp.Value} kere tekrar etmiştir.");
    }
}



