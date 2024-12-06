int[,] array = new int[3, 3];


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array[i, j] = i + j; 
    }
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

// Я не знаю как это работает, но это работает !!! Fedor
