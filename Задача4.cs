int[,] array = new int[,]{
    { 0, 1, -2, -3, 4 },
    { 0, 1, 2, 3, 4 },
    { 0, 1, -2, 3, -4 },
    { 0, 1, 2, 3, 4 },
    { 0, -1, 2, 3, 4 }
};

int Count = 0;
int Number = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ( array[i, j] < 0 )
        {
            Number = array[i, j];
            Console.WriteLine(Number);
            Count++;
        }
    }
}

Console.Write(Count);
