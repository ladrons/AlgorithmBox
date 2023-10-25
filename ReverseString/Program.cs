Console.WriteLine("Ters çevirilecek bir metin girin: ");
Console.WriteLine("");

string original = Console.ReadLine();
string reversed = ReverseString(original);

Console.WriteLine($"Metnin ters hali: {reversed}");


static string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);

    return new string(charArray);
}


////Farklı Yöntem (LINQ) ////

//string original = Console.ReadLine();
//string reversed = new string(original.Reverse().ToArray());

//Console.WriteLine($"Metnin ters hali: {reversed}");