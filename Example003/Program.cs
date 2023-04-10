// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива


double [] CreateArray (int Length, int min, int max)
{
    double [] array = new double [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().NextDouble() * (max-min)+min;
    }
    return array;
}

void PrintArray (double [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + "; ");
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

void MinMaxElements (double [] array)
{
    double Min = array[0];
    double Max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > Max) Max = array[i];
        if(array[i] < Min) Min = array[i];
    }
    Console.WriteLine("The value of the minimum element is " + Min);
    Console.WriteLine("The value of the maximum element is " + Max);
}

int Length = ReadInt("array length");
int min = ReadInt("the minimum size of element");
int max = ReadInt("the maximum size of element");
double [] Array = CreateArray(Length, min, max);
PrintArray(Array);
Console.WriteLine();
MinMaxElements(Array);