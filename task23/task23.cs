// Принимаем на вход число N
// Выдаем таблицу кубов числа от 1 до N

Console.WriteLine("Hello!");
Console.WriteLine("This program is needed in order to output a table of cubes.");
Console.Write("Please enter a number: ");
double num = Convert.ToInt32(Console.ReadLine());
Console.Write("Table of cubes of the number : ");

string space = ", ";

for (int i = 1; i < num + 1; i++)
{
    double result = Math.Pow(i, 3);
    Console.Write(result + space);
    if (i < num)
    {

    }
}