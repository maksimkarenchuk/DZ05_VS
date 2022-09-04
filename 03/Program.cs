// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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


int GetMaxValue(int[] array)
{
   int max = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > max) max = array[i];
   }
   return max;
}


int GetMinValue(int[] array)
{
   int min = array[0];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] < min) min = array[i];
   }
   return min;
}

int res(int max, int min)
{
   return max - min;
}


try
{

   Console.WriteLine("Введите число элементов массива");
   int size = Convert.ToInt32(Console.ReadLine());
   int[] array = FillArray(size);
   int result = res(GetMaxValue(array), GetMinValue(array));      // как правильно записать результат работы методов??
   Console.WriteLine($"Разница между Max и Min: {result}");
}
catch
{
   Console.WriteLine("Ошибка. Введите число!!");
}