/* 
 * dati in input 2 numeri interi,
 * cacolare la somma e visualizzare il risultato 
 */

int a,b;
Console.Write("Inserisci un numero intero: ");
string tmp = Console.ReadLine();
a = int.Parse(tmp);

Console.Write("Inserisci un altro numero intero: ");
tmp = Console.ReadLine();
b = int.Parse(tmp);

int c = a + b;
Console.WriteLine("il risultato: " + c);


