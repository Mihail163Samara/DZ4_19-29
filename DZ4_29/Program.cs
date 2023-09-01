// Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.


int Mass(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int array = Mass("Введите длину массива : ");
int [] ArrayAny = new int [array];
for (int i = 0; i < ArrayAny.Length; i++)
{
    ArrayAny[i] = new Random().Next (1,50);
    Console.WriteLine(ArrayAny[i] + " ");
}


