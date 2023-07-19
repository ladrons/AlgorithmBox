List<int> ints = new List<int> { 1, 2, 5, 6, 10, 12 };

simpleArraySum(ints);

void simpleArraySum(List<int> ar)
{
    int total = 0;

    for (int i = 0; i < ar.Count; i++)
    {
        total += ar[i];
    }
    Console.WriteLine(total);
}

//ToDo: Bunu ayrı bir proje olarak güncelleyeceğim.