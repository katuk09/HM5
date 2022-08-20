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



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76