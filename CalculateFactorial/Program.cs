
Console.WriteLine("Lütfen faktöriyelini hesaplamak istediğiniz pozitif bir tam sayı girin: ");
Console.WriteLine(" ");

int value = Convert.ToInt32(Console.ReadLine());

int factorial = 1;
for (int i = 1; i <= value; i++)
{
    factorial *= i;
}

Console.WriteLine($"{value} sayısının faktöriyeli: {factorial}");