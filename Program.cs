void Zadacha57()
{
    //задайте двумерный массив.Напишите программу ,которая заменяет строки на столбцы.
    //в случае ,если это невозможно,программа должна вывести сообщение для пользоавтеля.

    Random random = new Random();
    int rows = random.Next(3, 8);
    int columns = random.Next(3, 8);
  

    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("вывод массива");
    PrintArray(array);
    Console.WriteLine("вывод массива 2");
    ChangeRows(array);
    PrintArray(array);
    void FillArray(int[,] array)
    {

     for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0 , 10);
        }
     }
    }

    void PrintArray(int[,] array)
    {
     Console.WriteLine();
 
     for (int i = 0; i < rows; i++)
        {
           for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
        }
        Console.WriteLine();

    }
    
    void ChangeRows(int[,] array)
    {
        int temp = 0;
        for (int j = 0; j < columns ; j++)
        { 
            temp = array[0 , j];
            array [0, j] =  array[array.GetLength(0) - 1, j];
            array[array.GetLength(0)-1, j]= temp;
        }
    }
}     
Zadacha57();

