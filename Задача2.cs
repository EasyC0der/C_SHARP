int[,] array = new int[,]{
    { 0, 1, -2, -3, 4 },
    { 0, 1, 2, 3, 4 },
    { 0, 1, -2, 3, -4 },
    { 0, 1, 2, 3, 4 },
    { 0, -1, 2, 3, 4 }
};
int Result = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ( array[i, j] % 2 == 0 && array[i, j] > 0)
        {
            Result = Result + array[i, j];
            
        }
    }
}

Console.WriteLine(Result);
