Console.Write("Ведите число: а = ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Ведите число: b = ");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA > NumberB)
Console.WriteLine($"max = {NumberA}, min= {NumberB}");
else
Console.WriteLine($"max = {NumberB}, min= {NumberA}");