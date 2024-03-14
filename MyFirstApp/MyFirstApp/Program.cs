// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("modyfikacja");
Console.WriteLine("modyfikacja2");
Console.WriteLine("modyfikacja3");
Console.WriteLine("max wartosc");

static double GetAverage(int[] numbers)
{

    int sum1 = 0;
    foreach (var number in numbers)
    {
        sum1 += number;
        
    }

    return (double)sum1 / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };

double average=GetAverage(numbers);

static double GetMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}
