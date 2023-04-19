//
int[] numeri = new int[3];
numeri[0] = 10;
numeri[1] = -11;
numeri[2] = 12;

for (int i = 0; i < numeri.Length; i++)
    Console.WriteLine(numeri[i]);

Console.WriteLine("");

foreach (var n in numeri)
    Console.WriteLine(n); 

