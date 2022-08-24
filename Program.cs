//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] StartArr(int dlinArr)
{
    Random rnd = new Random();
    int[] array = new int[dlinArr];
    for (int i = 0; i < dlinArr; i++)
    {
        array[i] = rnd.Next(99, 999);
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
    return array;
}

int EvenNum(int[] filledArr)
{
    int amount = 0;

    for (int j = 0; j < filledArr.Length; j++)
    {
        if (filledArr[j] % 2 == 0)
            amount = amount + 1;
    }
    return amount;
}


Console.Write("Please input array's length: ");
int dlina = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The amount of even numbers is {EvenNum(StartArr(dlina))}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] RandMass(int razmer)
{
    int[] arrayRand = new int[razmer];
    Random rnd = new Random();
    for (int i = 0; i < razmer; i++)
    {
        arrayRand[i] = rnd.Next(-101, 100);
        Console.Write($"{arrayRand[i]} ");
    }
    return arrayRand;
}

void Summa(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 != 0) sum = sum + arr[i];
    Console.WriteLine();
    Console.WriteLine($"The sum of numbers under odd indexes is: {sum}");
}


Console.WriteLine("Please input the value of array's length: ");
int dlina = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Here's our array: ");
Summa(RandMass(dlina));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double[] DoubArray(int razmer)
{
double[] arrayRand = new double[razmer];
    Random rnd = new Random();
    for (int i = 0; i < razmer; i++)
    {
        arrayRand[i] = rnd.NextDouble() * 100;
        Console.Write($"{arrayRand[i]:N2}  ");
    }
    Console.WriteLine();
    return arrayRand;
}

void Differ(double[] varray)
{
    double min = varray[0]; 
    double max = varray[0];
    for (int i = 0; i < varray.Length; i++)
    {
        if (varray[i] < min) min = varray[i];
        if (varray[i] > max) max = varray[i];
    }
    double diff = max - min;
    Console.WriteLine($"The difference between Max {max:N2} and Min {min:N2} elements is: {diff:N2}");
}

Console.WriteLine("Please input the value of array's length: ");
int dlina = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Here's our array: ");
Differ(DoubArray(dlina));
Console.WriteLine("Bye-bye!");

*/
