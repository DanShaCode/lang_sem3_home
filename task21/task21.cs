// Формула по нахождению расстояния между точками в 3D пространстве. =============================================

// double formula = Math.Sqrt((Math.Pow(x1-x2, 2)) + (Math.Pow(y1-y2, 2)) + (Math.Pow(z1-z2, 2)));

// double res = Math.Round(formula,2);

// Console.WriteLine(res);

// Решение ========================================================================================================

Console.WriteLine("Hello! This program is designed to find the distance between points in 3D space.");
Console.WriteLine("Please enter the coordinates of point A one by one.");
Console.Write("X1 coordinates:");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 coordinates:");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 coordinates:");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the coordinates of point B one by one.");
Console.Write("X2 coordinates:");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 coordinates:");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 coordinates:");
double z2 = Convert.ToInt32(Console.ReadLine());

double formula = Math.Sqrt((Math.Pow(x1-x2, 2)) + (Math.Pow(y1-y2, 2)) + (Math.Pow(z1-z2, 2)));

double res = Math.Round(formula,2);

Console.WriteLine("The distance between points is: " + res);

//Done