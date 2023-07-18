/* Задача 1. Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) //i-первый работй элемент(не минимальнео значение).если из начала в конец i--
        array[i]=new Random().Next(minValue, maxValue+1);
        //перевое знаечение включается, а второе -нет, поэтому +1 ставим, чтобы включалось)
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int GetNegativeSum(int[] array)
{
    int sum =0;
    for(int i = 0;i<array.Length; i++)
        if(array[i]<0) sum+=array[i];
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
int negativeSum=GetNegativeSum(myArray);
ShowArray(myArray);
Console.WriteLine("Sum of negative elements: "+negativeSum);
*/

/*Задача2. Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int[] CreateNegativeArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=-1*array[i];
    }
    return array;
}


Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);
int[] negarray = CreateNegativeArray(array);
ShowArray(negarray);
*/

/*
Задача3. Задайте массив. Напишите программу, которая определяет, присутствует ли 
заданное число в массиве.
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

bool CheckNum(int[] array, int check)
{

    for (int i=0; i<array.Length; i++)
    {
        if (array[i]==check) return true;
        

    }
    return false;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

Console.Write("Input checking number: ");
int check = Convert.ToInt32(Console.ReadLine());

bool result = CheckNum(array, check);
Console.WriteLine(result);
*/

/*
Задача 4. Задайте одномерный массив из m случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [a,b].
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int CheckQty(int a, int b, int[]array)
{
    int result =0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>=a && array[i]<=b) result++;
    }
    return result;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array=CreateRandomArray(length, min, max);
ShowArray(array);

Console.Write("Input first num: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second num: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = CheckQty(a, b, array);
Console.WriteLine(result);