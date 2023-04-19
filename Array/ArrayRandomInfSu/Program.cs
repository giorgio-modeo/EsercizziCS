/*
 * genera un array di numeri random appartenenti
 * all'intervallo [inf,sup]
 */

Random random = new Random();
int dimensione=random.Next(0, 100)+1;

int[] numeri = new int[dimensione];

Console.WriteLine("inf: ");
int inf = int.Parse(Console.ReadLine());

Console.WriteLine("sup: ");
int sup = int.Parse(Console.ReadLine());

for (int i = 0; i < numeri.Length; i++)
    numeri[i] = random.Next(inf,sup+1);

Console.WriteLine(string.Join(",\n", numeri));