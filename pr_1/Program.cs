Console.Clear();

int m = GetNumberFromUser("Введите m: ");
int n = GetNumberFromUser("Введите n: ");

int[,] array = GetArray(m,n);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);

int MaxFind (int[,] array, int m, int n) 
{   
    int max_index = n;
    int number = array[m,n];
    {
    for (int i = n; i < array.GetLength(1); i++)
        {
        if (number<array[m,i]) 
            {
            max_index = i;
            number = array[m,i];
            }
        }
    return max_index;
    }
}

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

void ChangeArray (int [,] array) 
{
    for (int i=0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {   
            int tmp = array[i,j];
            int max_j = MaxFind(array, i, j);
            array[i,j]=array[i,max_j];
            array[i,max_j] = tmp;
        }
    }
}