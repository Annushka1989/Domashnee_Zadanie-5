//Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0
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
//  ЗАДАЕМ ФУНКЦИЮ КОТОРАЯ НАЙДЕТ сумму элементов, стоящих на нечетных позициях
int getSumOfOddPositionsInArray (int[] incomingArray)
{
    int sum =0;
    for (int i = 0; i < incomingArray.Length; i+=2)
    {
        sum = sum + incomingArray[i];
    }
    return sum;
}

int [] currentArray = getRandomArray(arraySize,1,10);
printArray(currentArray);

int SumOfOddPositionsInArray = getSumOfOddPositionsInArray (currentArray);
Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях {SumOfOddPositionsInArray}");
