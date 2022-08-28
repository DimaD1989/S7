
int  Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Main( double k1, double b1, double k2, double b2) //функция проверки условия
{
    if (b1==b2 && k1==k2)
    {
        System.Console.WriteLine("Прямые совпадают: ");
    }
    else if (k1==k2)
    {
         System.Console.WriteLine("Прямые параллельны: ");
    }
    else
    {
        var tuple = SystemSolution(k1,b1,k2,b2);
        Console.Write($"Координаты точки пересечения ({(tuple.Item1):f2}; {(tuple.Item1):f2})");
    }
}
(double, double) SystemSolution(double k1,double b1,double k2, double b2) /// функция находит точки пересечения
{
double x= (b2-b1)/(k1/k2);
double y= k1*x+b1;
var result=(x,y);
return result;
}

int k1 = Prompt("Определите коэффициент k1 "); //Вводим  коэффициент
int b1 = Prompt("Определите коэффициент b1 ");
int k2 = Prompt("Определите коэффициент k2 ");
int b2 = Prompt("Определите коэффициент b2 ");
Main(k1, b1, k2, b2);

