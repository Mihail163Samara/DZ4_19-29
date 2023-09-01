// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();

int n = num.Length;

if (n == 5)
{
    if (num[0] == num[4] && num[1] == num[3]) Console.Write($"Число({num}) - является палиндромом");
    else if (num[0] != num[4] && num[1] != num[3]) Console.Write($"Число({num}) - не является палиндромом");

    else Console.Write($"Число({num}) - не является пятизначным");



}


// int Mass(string message)
// {
// Console.WriteLine(message);
// return Convert.ToInt32(Console.ReadLine());
// }

// Mass("Введите число : ");

//  int zevs(int num1)
// {
//     int i = 0;
//     while (0 > num1)
//     {
//         num1 /= 2;
//         i++;
//     } 
//     return i ;
// }

// zevs();