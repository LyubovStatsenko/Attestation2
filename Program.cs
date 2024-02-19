// Задача 1. 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void ShowNaturalsNumbers(int M, int N)
{
    if(M == N)
    {
        Console.Write(M); 
        return; 
    }
Console.Write(M + " ");
ShowNaturalsNumbers(M + 1, N);  
}
Console.WriteLine("Введите начальное значение"); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите конечное значение");
int N = Convert.ToInt32(Console.ReadLine());
ShowNaturalsNumbers(M, N); 

// Задача 2. 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunktionAkkerman(int n, int m)
{
     if(n == 0)
	{
	   return m + 1;
	}
      if(n > 0 && m == 0)
	{
	   return FunktionAkkerman(n - 1, 1);
	}
           return FunktionAkkerman(n - 1, FunktionAkkerman(n, m - 1));
}
Console.WriteLine(FunktionAkkerman(0,2));

// Задача 3. 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ShowReverseArray (int[] array, int j)
{
    if (j == 0)
    {
        Console.Write(array[j]); 
        return; 
    }
    Console.Write(array[j] + " ");
    ShowReverseArray(array, j - 1);
}
int[] array = new int[] {5, 2, 3, 4, 6, };
ShowReverseArray(array, array.Length - 1);
