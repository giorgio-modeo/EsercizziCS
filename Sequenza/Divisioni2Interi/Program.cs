Console.Write("inserisci il dividendo: ");
int a = int.Parse(Console.ReadLine());

Console.Write("inserisci il divisore: ");
int b = int.Parse(Console.ReadLine());

int qi = a / b;
int r = a % b;
double qr = (double)a / b;

Console.WriteLine($"Quozziente intero: {qi}");
Console.WriteLine($"Resto: {r}");
Console.WriteLine($"Quozziente reale: {qr}");

