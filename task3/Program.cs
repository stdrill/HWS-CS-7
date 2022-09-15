// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void PrintArray (int[,,] matr)
{
    for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0;j < matr.GetLength(1); j++)
        {
            for(int z = 0;z < matr.GetLength(2);z++)
            {
                Console.WriteLine($"{matr[i,j,z]} = {i},{j},{z}");
            }
        }
        Console.WriteLine(); // Разделение строк массива
    }
}
void FillArray(int[,,] matr)
{
 for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0;j < matr.GetLength(1); j++)
        {
            for(int z = 0;z < matr.GetLength(2);z++)
            {
                matr[i, j, z] = new Random().Next(10,100);
            }
        }
    }   
}

int[,,] matrix = new int [2,2,2];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();