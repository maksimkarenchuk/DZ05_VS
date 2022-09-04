// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArray(int size)
{
   int[] array = new int[size];

   for (int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(-50, 50);
      if (i != array.Length - 1) Console.Write($"{array[i]}, ");
      else Console.WriteLine(array[i]);
   }
   return array;
}

int Sumnegpoz(int[] array)
{
   int sum = 0;
   for (int i = 1; i < array.Length; i = i + 2) sum = sum + array[i];
   return sum;
}


try
{
   Console.WriteLine("Введите число элементов массива");
   int size = Convert.ToInt32(Console.ReadLine());
   int sum = Sumnegpoz(FillArray(size));
   Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
}
catch
{
   Console.WriteLine("Ошибка. Введите число!!");
}