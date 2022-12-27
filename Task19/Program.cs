int a = int.Parse(Console.ReadLine());
int b = a;
var palin = new List<int>();

while (b > 0)
{
    palin.Add(b % 10);
    b = b / 10;
}

b = 0;

palin.Reverse();

for(int dlpalin = 0; dlpalin < palin.Count; dlpalin++)
    b = b + palin[dlpalin] * (int)Math.Pow(10, dlpalin);

if (a == b)
    Console.WriteLine("Число - палиндрои");

else
    Console.WriteLine("Число - не падиндром");
