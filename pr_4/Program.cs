
int[,,] array_1 = GetArray(GetNumberFromUser("Введите m для первого массива: "),GetNumberFromUser("Введите n для первого массива: "),GetNumberFromUser("Введите q для первого массива: "));
PrintArray(array_1);


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

int [,,] GetArray (int m, int n, int o) 
{
    int[,,] array = new int[m,n,o];
    PrintArray(array);
    int [] check_array = new int[m * n * o];
    int h = 0;

    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            for (int q = 0; q <array.GetLength(2); q ++) 
            {
                array[i,j,q] = fillArray(check_array,h);
                check_array[h] = array[i,j,q];
                h=h+1;
            }
        }
    }
    return array;
}

int fillArray (int[] array, int h) 
{
    while(true)
    {
        int number = new Random().Next(-1,8);
        int i = 0;
        bool check = true;
        while(i <= h) 
        {   
            if (number == array[i]) 
            {
                    check = false;
                    break;
            }
            else i = i + 1;
        }
        Console.WriteLine(number);
        Console.WriteLine(check);
        while(check)
            return number;
    }
}

void PrintArray (int [,,] array) 
{
    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            for (int q = 0; q <array.GetLength(2); q ++) 
            {
                Console.WriteLine($" {array[i,j,q]} -> [{i},{j},{q}]");
            }
        }
    }
}