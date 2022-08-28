
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

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns)         // Функция создания и заполнения двумерного массива по формуле
// {
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)     // Столбец
//         {
//             matrix[i, j] = i + j;      // 
//         }
//     }
//     return matrix;
// }
// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }


// int [,] array = FillArray(Prompt("Введите число строк > "),Prompt("Введите число столбцов > "));
// PrintArray(array);


// Задайте двумерный массив. 
// Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.

// int Prompt(string message)
// {
//     System.Console.Write(message);                    // Вывести сообщение
//     int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
//     return result;                                    // Возвращает результат
// }

// int[,] FillArray(int numLine, int numColumns)           // Функция создания и заполнения двумерного массива по формуле
// {
//     int[,] matrix = new int[numLine, numColumns];       // Создание нового массива
//     for (int i = 0; i < matrix.GetLength(0); i++)       // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             matrix[i, j] = i + j;      // Формула для заполнения массива
//         }
//     }
//     return matrix;      // Возвращаем результат
// void PrintArray(int[,] matrix)              // Функция печати массива 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)   // Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)   // Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");     // Вывод значений очередной строки 
//         }
//         Console.WriteLine();    // Переход на следующую строку
//     }
// }


// int[,] ConvertToSQR(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
//     return array;
// }


// int[,] massiv = FillArray(5, 5);
// PrintArray(massiv);
// System.Console.WriteLine();
// int [,] newmassiv = ConvertToSQR(massiv);
// PrintArray(newmassiv);}


// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

Random rand = new Random();
void Fillmatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] matrix = new int[3, 3];

Fillmatrix(matrix);
PrintArray(matrix);
System.Console.WriteLine(GetSum(matrix));
int GetSum (int[,] matrix);
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


// Random rand = new Random();
// void Fillmatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 15);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 3];

// Fillmatrix(matrix);
// PrintArray(matrix);
// System.Console.WriteLine("Input a number");
// int element = int.Parse(Console.ReadLine()??"0");
// FindElem(matrix,element);
// void FindElem (int[,] matrix ,int element)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (element==matrix[i,j])
//             {
//             System.Console.WriteLine($"Entered number is on[{i}{j}] position");
//             return;
//             }
//         }
//     }
//     System.Console.WriteLine($"There is no such element in this matrix" );
    
// }