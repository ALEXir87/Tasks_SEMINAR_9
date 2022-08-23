// Задача №66:Задайте значения M и N.Напишите программу,которая найдёт сумму натуральных элементов в промежутке
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Задача №66");
Console.Write("Введи значение M = ");
int numberM =Convert.ToInt32(Console.ReadLine());
Console.Write("Введи значение N = ");
int numberN =Convert.ToInt32(Console.ReadLine());
int sum = 0;

PrintSumMToN(numberM, numberN, sum);
void PrintSumMToN(int M, int N, int Sum){
    if (numberM > numberN) return;
    Sum = Sum + N;
    if (N <= M){
        Console.Write($"Cумма натуральных элементов в промежутке от M до N --> {Sum} ");
        return;}
    PrintSumMToN(M, N - 1, Sum);}
Console.WriteLine();