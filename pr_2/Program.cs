Console.Clear();

int m = GetNumberFromUser("Введите m: ");
int n = GetNumberFromUser("Введите n: ");

int[,] array = GetArray(m,n);
PrintArray(array);
Console.WriteLine();
MinSumOfArray(array);

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
            array[i,j] = new Random().Next(0,101);
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

void MinSumOfArray (int [,] array) 
{
    int min_sum = SumOfRow(array, 0);
    int min_index = 0;
    for (int i=1; i < m; i++) 
    {
        int SumCurrent_row = SumOfRow(array,i);
        if (SumCurrent_row<min_sum) 
        {
            min_sum = SumCurrent_row;
            min_index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой: {min_index+1}, Сумма: {min_sum}");
}

int SumOfRow (int[,] array, int m) 
{   
    int sum = 0;
    {
    for (int i = 0; i < array.GetLength(1); i++)
        {
            sum=sum+array[m,i];
        }
    }
    return sum;
}