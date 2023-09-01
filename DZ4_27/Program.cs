// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int numbers (string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
    
}

 int a = numbers("Введите число: ");

int All (int ournamber) 
{
   int z = 0; 
   while (ournamber > 0)
   {
     ournamber /= 10;
    z++;
   }
   
   return z;
}

 int b = All(a);

 void SumNum(int a, int b)

{
   int box = 0;
   for (int i = 0; i < b; i++)
   {
    box += a % 10;
    a/= 10;
   } System.Console.WriteLine(box);
}

SumNum( a, b);

