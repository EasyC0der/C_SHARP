int[,] array = new int[4, 8];


// Заполнение
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 8; j++)
    {
        array[i, j] = i + j;
    }
}

// Подсчеты
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            // Пример переменных, которые могли бы быть определены ранее
            int i_temp = array[i, j]; // Значение из массива для i
            int j_temp = array[i, j]; // Вы можете изменить это в соответствии с вашей логикой

            // Сумма значений
            int result = j_temp + i_temp;
            // Выводим результат
            Console.WriteLine($"Сумма элементов для индексов ({i}, {j}): {result}");
        }
        Console.WriteLine();
    }
}
// Я не знаю как это работает, но это работает !!! Fedor
