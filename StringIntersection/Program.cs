Console.WriteLine("İşlem yapılacak sayılar: [1, 3, 4, 7, 13] - [1, 2, 4, 13, 15]");
Console.WriteLine("");

string[] strArr = { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };

string result = string.Join(",", strArr[0].Split(',').Select(x => x.Trim()).Intersect(strArr[1].Split(',').Select(x => x.Trim())));

if (!string.IsNullOrEmpty(result))
{
    Console.WriteLine($"Eşleşen değerler: {result}");
}
else { Console.WriteLine("Eşleşen değer yoktur."); }