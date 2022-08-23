// Задача №64:Задайте значение N.Напишите программу,которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача №64");
Console.Write("Введи значение N = ");
int number =Convert.ToInt32(Console.ReadLine());
Console.Write("Натуральные числа в промежутке от N до 1 : ");
PrintNToNumbers(number);

void PrintNToNumbers(int N){
    if (N < 1) return;       // если N < 1,то метод выходит из программы
    Console.Write(N + " ");
    PrintNToNumbers(N-1);}  // метод вызвал сам себя (Рекурсия)
Console.WriteLine();