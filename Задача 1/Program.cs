// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2

Console.Write("Введите размерность массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine( ));
int [] getRandomArray (int length, int startPoint, int endPoint)
{
    int [] resultArray = new int [length];
    for (int i=0; i<length; i++)
    {
        resultArray[i]= new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}
//  ЗАДАЕМ ФУНКЦИЮ КОТОРАЯ ПОКАЖЕТ МАССИВ
void printArray (int [] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i<incomingArray.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
//  ЗАДАЕМ ФУНКЦИЮ КОТОРАЯ НАЙДЕТ КОЛИЧЕСТВО ЧЕТНЫХ ЧИСЕЛ
int getEvenNumbersInArray (int[] incomingArray)
{
    int result =0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] % 2 == 0)
        {
            result ++;
        }
    }
    return result;
}

int [] currentArray = getRandomArray(arraySize,100,999);
printArray(currentArray);

int EvenNumbersInArray = getEvenNumbersInArray (currentArray);
Console.WriteLine($"Количество четных чисел в массиве {EvenNumbersInArray}");

