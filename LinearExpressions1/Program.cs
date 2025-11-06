Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
double a, b, c, d;
double x, y, z, r;
Console.WriteLine("Введіть 4 числа a, b, c, d");
Console.WriteLine("Введіть значення для a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення для b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення для c: ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення для d: ");
d = double.Parse(Console.ReadLine());
x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - (Math.Pow(a, 2) / Math.Pow(b, 2));
y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
z = (((Math.Pow(x, 2) - 2 * x) * (Math.Pow(x, 2) - 2 * x) * (Math.Pow(x, 2) - 2 * x)) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
r = ((0.5 * a + 0.75 * b - 7.0 / 5.0) / (3 * c + 1)) + (1 / (a - c));
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");
Console.WriteLine($"z = {z}");
Console.WriteLine($"r = {r}");

0



