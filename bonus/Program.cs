// Напишите программу, которая принимает на вход координаты точек и 
// находит расстояние между ними в N-мерном пространстве. N - задается пользователем.

string rast3d()
{
   Console.Write("Введите координату X первой точки ");
   int x1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату Y первой точки ");
   int y1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату Z первой точки ");
   int z1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату X второй точки ");
   int x2 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату Y второй точки ");
   int y2 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату Z второй точки ");
   int z2 = Convert.ToInt32(Console.ReadLine());

   double rast3d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
   return ($"Длина между точками в 3D:  {rast3d}");
}

string rast2d()
{
   Console.Write("Введите координату X первой точки ");
   int x1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату Y первой точки ");
   int y1 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату X второй точки ");
   int x2 = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите координату Y второй точки ");
   int y2 = Convert.ToInt32(Console.ReadLine());

   double rast2d = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
   return ($"Длина между точками в 2D:  {rast2d}");
}

try
{
   Console.Write("В каком пространстве ищем расстояние между точками 2D или 3D (два или три):  ");
   int a = Convert.ToInt32(Console.ReadLine());
            if (a == 2)
                  {
                     Console.WriteLine(rast2d());
                  }
            else if (a == 3)
                  {
                     Console.WriteLine(rast3d());
                  }
   else Console.WriteLine("Координаты вводятся цифрами");

}
catch
{
   Console.WriteLine("Координаты вводятся цифрами");
}
