/*
 
 */
Random random = new Random();

int e1, e2,e3,e4,e5;
e1 = random.Next(1,90);

do
{
    e2 = random.Next(1,90);
}while(e1 == e2);
do
{
    e3 = random.Next(1, 90);
}while (e1 == e3 || e2 == e3);
do
{
    e4 = random.Next(1, 90);
} while (e1 == e4 || e2 == e4 || e3 == e4);
do
{
    e5 = random.Next(1, 90);
} while (e1 == e5 || e2 == e5 || e3 == e5 || e4 == e5);
Console.WriteLine($"{e1},{e2},{e3},{e4},{e5}");
