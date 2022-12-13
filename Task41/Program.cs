// Пользователь вводит с клавиатуры М чисел.Посчитать, сколько чисел больше 0 ввел пользователь.


Console.Write("Введите количество чисел массива :");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];
int count = 0;
for (int i=0; i< array.Length; i++)
{
  Console.Write($"Введите число{i+1}: ");
  array[i]=int.Parse(Console.ReadLine());
  if (array[i] >0) count++;
}
Console.Write($"Количество чисел больше 0 ={count}");