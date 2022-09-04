// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArray(int size)
{
   int[] array = new int[size];

   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(100, 1000);
      if (i != array.Length - 1) Console.Write($"{array[i]}, ");
      else Console.WriteLine(array[i]);
   }
   return array;
}


int Numberplus(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0) count += 1;
   }
   return count;
}

try
{
   Console.Write("Введите длину массива: \t");
   int number = Convert.ToInt32(Console.ReadLine());
   int count = Numberplus(FillArray(number));
   Console.WriteLine($"Количество четных чисел: {count}");
}
catch
{
   Console.WriteLine("Ошибка. Введите число!!");
}


