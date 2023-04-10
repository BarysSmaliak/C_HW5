// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateArray (int Length, int min, int max)
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(min,max);
    }
    return array;
}

void PrintArray (int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1] + "]");
}

int ReadInt (string arg)
{
    int num;
    Console.WriteLine($"Input {arg}: ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("it,s not a number. Input the correct number");
    }
    return num;
}

void SumElements(int [] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        Sum = Sum + array[i];
        
    }
    Console.WriteLine($"Sum of even elements is " + Sum);
}

int Length = ReadInt("array length");
int min = ReadInt("the minimum size of element");
int max = ReadInt("the maximum size of element");
int [] Array = CreateArray(Length, min, max);
PrintArray(Array);
Console.WriteLine();
SumElements(Array);
