#nullable disable

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Lütfen bir kelime giriniz (Örnek: leblebi)");
    Console.WriteLine();

    string text = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(text))
    {
        ShowDuplicateCharacters(text);
    }
    else
    {
        Console.Clear();

        Console.WriteLine("Lütfen geçerli bir değer giriniz");
        Console.WriteLine();
    }
}

//----- Methods -----\\

char[] FindDuplicateChars(string text)
{
    Dictionary<int, char> sameChars = new Dictionary<int, char>();

    for (int i = 0; i < text.Length; i++)
    {
        for (int j = 0; j < text.Length; j++)
        {
            if (i != j && text[i] == text[j] && !sameChars.ContainsKey(i))
            {
                sameChars.Add(i, text[j]);
            }
            else continue;
        }
    }
    char[] duplicateChars = sameChars.Select(x => x.Value).ToArray();

    return duplicateChars;
}

Dictionary<char, int> CountCharOccurrences(char[] chars)
{
    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
    foreach (var item in chars)
    {
        if (keyValuePairs.ContainsKey(item))
        {
            keyValuePairs[item]++;
        }
        else
        {
            keyValuePairs[item] = 1;
        }
    }
    return keyValuePairs;
}

void ShowDuplicateCharacters(string text)
{
    Dictionary<char, int> duplicateChars = CountCharOccurrences(FindDuplicateChars(text));

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