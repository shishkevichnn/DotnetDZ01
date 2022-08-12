Console.Write("Ведите число: а = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Ведите число: b = ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Ведите число: а = ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine($"max = {max}");

