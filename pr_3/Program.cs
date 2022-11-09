Console.Clear();

int[,] array_1 = GetArray(GetNumberFromUser("Введите m для первого массива: "),GetNumberFromUser("Введите n для первого массива: "));
PrintArray(array_1);
Console.WriteLine();

int[,] array_2 = GetArray(GetNumberFromUser("Введите m для второго массива: "),GetNumberFromUser("Введите n для второго массива: "));
PrintArray(array_2);

if (array_1.GetLength(1)==array_2.GetLength(0))
{
int[,] array_3 = FillArray(array_1,array_2);
PrintArray(array_3);
}
else Console.WriteLine($"m ({array_1.GetLength(0)}) первого массива не равен n ({array_2.GetLength(1)}) второго - перемножение массивов невозможно!");


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

int [,] GetArray (int m, int n) 
{
    int[,] array = new int[m,n];
    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
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

int[,] FillArray (int [,] array_1, int [,] array_2) 
{
    int m1 = array_1.GetLength(0);

    int n2 = array_2.GetLength(1);

    int [,] array_3 = new int [m1,n2];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++) 
        {
            array_3[i,j] = MultiplieOfArray(array_1,i,array_2,j);
        }
    }
    return array_3;
}

int MultiplieOfArray(int[,] array_1,int i, int [,] array_2, int j) 
{
    int multiplie = 0;
    for (int g = 0; g < array_1.GetLength(1); g++)
    {
        multiplie = multiplie + (array_1[i,g]*array_2[g,j]);
    }
    return multiplie;
}