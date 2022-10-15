// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
Console.Write("Номер строки элемента? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца элемента? ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [10,10];

RandomArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Ooops! Такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца: {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}