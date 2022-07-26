void Zadacha57()
{
    // задайте двумерный массив.Напишите программу ,которая заменяет строки на столбцы.
    //В случае,если это невозможно,программа должна вывести сообщение для пользователя.
    Console.WriteLine("Введите количество строк ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("вывод массива ");
    PrintArray(array);
    Console.WriteLine("вывод массива 2");
    ChangeRowsColumns(array);

}
 void FillArray(int[,] array)
    {
     Random random = new Random() ;
     int rows = array.GetLength(0);
     int columns = array.GetLength(1);
     
     for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-100, 100);
        }
     }
    }

    void PrintArray(int[,] array)
    {
     Random random = new Random() ;
     int rows = array.GetLength(0);
     int columns = array.GetLength(1);
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
    void ChangeRowsColumns( int[,] array)
    {
     Random random = new Random() ;
     int rows = array.GetLength(0);
     int columns = array.GetLength(1);
     if(rows == columns)
     {
        for (int i = 0; i < columns; i++)
        {
           for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[j, i] + "\t");
                }
                Console.WriteLine();
        }
        Console.WriteLine();
     }
     else Console.WriteLine("Заменить строки на столбцы невозможно");

    }
    Zadacha57();