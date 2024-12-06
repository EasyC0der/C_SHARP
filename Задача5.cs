int[,] array = new int[,]{
    { 0, 1, 2, 3, 5 },
    { 0, 1, 2, 4, 4 },
    { 0, 1, 3, 3, 4 },
    { 0, 2, 2, 3, 4 },
    { 1, 1, 2, 3, 4 }
};



for (int i = 0; i < 5; i++)
{
    int j = 5 - 1 - i; 
    Console.WriteLine(array[i, j]);
}
