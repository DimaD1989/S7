
// int  Prompt(string message) 
// {
//     System.Console.WriteLine(message); //Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine());//Считывание значения
//     return result;// возврат результата
// }

// void Main( double k1, double b1, double k2, double b2) //функция проверки условия
// {
//     if (b1==b2 && k1==k2)
//     {
//         System.Console.WriteLine("Прямые совпадают: ");
//     }
//     else if (k1==k2)
//     {
//          System.Console.WriteLine("Прямые параллельны: ");
//     }
//     else
//     {
//         var tuple = SystemSolution(k1,b1,k2,b2);
//         Console.Write($"Координаты точки пересечения ({(tuple.Item1):f2}; {(tuple.Item1):f2})");
//     }
// }
// (double, double) SystemSolution(double k1,double b1,double k2, double b2) /// функция находит точки пересечения
// {
// double x= (b2-b1)/(k1/k2);
// double y= k1*x+b1;
// var result=(x,y);
// return result;
// }

// int k1 = Prompt("Определите коэффициент k1 "); //Вводим  коэффициент
// int b1 = Prompt("Определите коэффициент b1 ");
// int k2 = Prompt("Определите коэффициент k2 ");
// int b2 = Prompt("Определите коэффициент b2 ");
// Main(k1, b1, k2, b2); //начинаем проверку
  
  //Сгенерировать двухмерный массив со случайными числами. вывести на экран. оформить в виде функции

// int  Prompt(string message) 
// {
//     System.Console.WriteLine(message); //Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine());//Считывание значения
//     return result;// возврат результата
// }

// int[,]FillArray(int numLine,int numColumns, int maxRand =20, int minRand=0) // Функция 
// {
//     int[,] matrix = new int[numLine,numColumns];
//     for (int i = 0; i <matrix.GetLength(0); i++) //cтрока
//     {
//         for (int j = 0; j <matrix.GetLength(1); j++)  //cтолбец
//         {
//           matrix[i,j]= new Random().Next(minRand,maxRand);
//         }
//     }
//     return matrix;
// }
//  void PrintArray(int[,] matrix)        //функция печати массива
// {
//     for (int i= 0; i < matrix.GetLength(0); i++) //строка
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++) //столбец
         
//           Console.Write($"{matrix[i,j]}  ");
         
//          Console.WriteLine();
//     }
// }

// int numLine = Prompt("Введите количество строк массива");
// int numColumns = Prompt ("Введите количество столбцов массива");
// int minRand = Prompt ("Введите верхную границу диапазона");
// int maxRand = Prompt ("Введите нижнюю границу диапазона");
// int[,] matrix = FillArray(numLine,numColumns,minRand,maxRand); // диапазон значений
// PrintArray(matrix);


