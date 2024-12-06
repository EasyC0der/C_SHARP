int[,] array = new int[,]{
    { 0, 1, 2, 3, 5 },
    { 0, 2, 2, 4, 4 },
    { 0, 1, 2, 3, 4 },
    { 0, 2, 2, 2, 4 },
    { 1, 1, 2, 3, 2 }
};

int Sum = 0;
int Mult = 1;
int t = -1;

for (int i = 0; i < 5; i++)
{
    int j = 5 - 1 - i; 
    Sum += array[i, j];
    Console.WriteLine(array[i, j]);
    
}
for (int i = 0; i < 5; i++)
{
    
    t++;
    if (array[i, t] != 0)
    {
        Mult *= array[i, t];
    }
}
Console.WriteLine($"Summa elementov: {Sum}");
Console.WriteLine($"Proivedenie: {Mult}");
