Random random = new Random();
int r = random.Next(0, 100) + 1;
int righe = 10;
int colonne = 7;

int[,] matrice = new int[righe,colonne];

for (int i = 0; i < righe; i++)
    for (int j = 0; j < colonne; j++)
        matrice[i,j] = random.Next(1,100+1);

for (int i = 0; i < righe; i++)
{

    for (int j = 0; j < colonne; j++)
        Console.Write(matrice[i,j]+" ");
Console.WriteLine();
}