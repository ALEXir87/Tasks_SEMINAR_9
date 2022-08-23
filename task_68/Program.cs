// Задача №68:Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.WriteLine("Задача №68");
Console.Write("Введи значение M = ");
int numberM =Convert.ToInt32(Console.ReadLine());
Console.Write("Введи значение N = ");
int numberN =Convert.ToInt32(Console.ReadLine());
int AkkermannFun(int numberM, int numberN){
    if (numberM == 0) return numberN + 1;
    if (numberM > 0 && numberN == 0) return AkkermannFun(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermannFun(numberM - 1, AkkermannFun(numberM, numberN - 1));
return AkkermannFun(numberM, numberN);}
Console.WriteLine($"Функция Аккермана --> A({numberM},{numberN}) = {AkkermannFun(numberM, numberN)}");