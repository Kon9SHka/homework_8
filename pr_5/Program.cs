Console.Clear();

int [,] array = new int[GetNumberFromUser("Введите m для первого массива: "),GetNumberFromUser("Введите n для первого массива: ")];
array = GetArray(array.GetLength(0),array.GetLength(1));



PrintArray(array);
Console.WriteLine();

int GetNumberFromUser (string message) 
{
    while(true) 
    {

        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        while(isCorrect)
            return number;
        Console.WriteLine("Ошибка ввода!");
    }
}

int[,] GetArray (int row, int col) 
{   
    int [,] a = new int[row,col];
    int i = 0;
    int j = 0;

    int value = 1;

            while (row > 0 && col >0)
            {
                int k = 0;
                do { a[i, j++] = value++; } while (++k < col - 1);
                for (k = 0; k < row - 1; k++) a[i++, j] = value++;
                for (k = 0; k < col - 1; k++) a[i, j--] = value++;
                for (k = 0; k < row - 1; k++) a[i--, j] = value++;

                ++i; ++j;
                if (col-2==-1)
                {
                    col=col-1;
                }
                else col = col - 2;

                if (row-2==-1)
                {
                    row=row-1;
                }
                else row = row - 2;
            }
    return a;
}

void PrintArray (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}
