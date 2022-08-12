Console.Write("Ведите число: а = ");
int NumberA = int.Parse(Console.ReadLine());
for (int i = 1; i <= NumberA; i++)
    if (i % 2 == 0)
     Console.WriteLine(i);