// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

int [] CreateArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random(). Next (1,1000);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write ("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write (array[i] + "; ");
    }
    Console.Write (array[array.Length-1] + "]");
}

int ReadInt(string argument) 
{
    System.Console.WriteLine($"Input {argument}: ");
    return int.Parse(Console.ReadLine()); 
} 

void EvenNumbers (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = result +1;
        }
    }
    Console.WriteLine("Number of even numbers is " + result);
}

int Length = ReadInt ("array length");
int [] Array = CreateArray (Length);
PrintArray(Array);
Console.WriteLine();
EvenNumbers(Array);