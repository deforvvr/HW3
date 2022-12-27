int num;
Console.Write("Введите любое число: ");
num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");
return;