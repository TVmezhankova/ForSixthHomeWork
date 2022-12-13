// Программа находит точку пересечения двух прямых,
//заданных уравнениями Y=K1*X +B1   b Y=K2*X +B2.
// Значения К1,В1,К,В2 задаются пользователем.

Console.WriteLine(" Введите коэффициент К1 :");
double K1 = double.Parse(Console.ReadLine());
Console.WriteLine(" Введите коэффициент К2 :");
double K2 = double.Parse(Console.ReadLine());
Console.WriteLine(" Введите коэффициент B1 :");
double B1 = double.Parse(Console.ReadLine());
Console.WriteLine(" Введите коэффициент B2 :");
double B2 = double.Parse(Console.ReadLine());

double X= (B2-B1)/(K1-K2);
double Y= K1*X + B1;

Console.WriteLine($" Координаты точки пересечения ({X} , {Y})");