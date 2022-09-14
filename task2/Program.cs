// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void PrintArray (int[,] matr)
{
    for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0;j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
 for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0;j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }   
}
(int, int) FindMin (int[,] matr)
{
    int min = matr[0,0];
    int coorI = 0;
    int coorJ = 0;
    for(int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0;j < matr.GetLength(1); j++)
        {
            if(matr[i,j] < min && coorI < matr.GetLength(1)) 
            {
                min = matr[i,j];
                coorI = i;
                coorJ = j;
            }
        }
    }   
    return (coorI, coorJ);
}
int[,] DeleteRowCol (int[,] matr, int coorI, int coorJ) 
{
    int[,] newMatr = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    for(int i = 0;i < newMatr.GetLength(0); i++)  
    {
        for(int j = 0;j < newMatr.GetLength(1); j++)
        {
            if(i != coorI && j != coorJ) newMatr[i,j] = matr[i,j];
            if(j >= coorJ && i != coorI) newMatr[i,j] = matr[i,j+1];
            if(i >= coorI && j != coorJ) newMatr[i,j] = matr[i+1,j];
            if(i >= coorI && j >= coorJ) newMatr[i,j] = matr[i+1,j+1]; 
        }
    }   
    return newMatr;
}

int[,] matrix = new int [5,6];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
(int coordinateI, int coordinateJ) = FindMin(matrix);
Console.WriteLine($"{coordinateI}, {coordinateJ}");
Console.WriteLine();
int[,] newMatrix = DeleteRowCol(matrix, coordinateI, coordinateJ);
PrintArray(newMatrix);