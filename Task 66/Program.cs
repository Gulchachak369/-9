// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int PrintNaturalNumbSum(int m, int n) { 
    if (n - m == 1) { 
        return m + n; 
    } 
 
    return m + PrintNaturalNumbSum(m + 1, n); 
} 
 
System.Console.Write("Введите число M: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
 
System.Console.Write("Введите число N: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
int sum = PrintNaturalNumbSum(m, n); 
System.Console.WriteLine("Сумма: {0}", sum);