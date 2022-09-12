// Найти произведение двух матриц

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
int[,] MultiplicationMatrix(int[,] matrA, int[,] matrB)
{
    int[,] multMatrix = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for(int i = 0;i < matrA.GetLength(0); i++)
    {
        for(int j = 0;j < matrB.GetLength(1); j++)
        {
            int mult = 0;
            for(int col = 0;col < matrA.GetLength(1); col++)
            {
                mult += matrA[i,col] * matrB[col,j];
                //Console.Write($"{matrA[i,col]} * {matrB[col,j]} ");
            }
            multMatrix[i,j] = mult;
            //Console.WriteLine($"{mult} = {i}{j}");
        }
    }   
    return multMatrix;
}

int[,] matrixA = new int [4,2];
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
int[,] matrixB = new int[2,3];
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();
int[,] multMatrix = MultiplicationMatrix(matrixA, matrixB);
PrintArray(multMatrix);