// Принимаем на вход пятизначное число 
// Проверяем является ли число полиндромом

// Пример числа полиндрома - 121; 676; 1331; 4884; 94949;

Console.WriteLine("Is a number a palindrome?");
Console.Write("Enter a fife-digit number: ");
int number5 = Convert.ToInt32(Console.ReadLine());

if (number5 < -99999 | number5 > -10000 && number5 < 10000 | number5 > 99999)
{
    Console.WriteLine("Input error. Enter a five-digit number.");
}
else
{
    int num1 = number5 / 10000;
    int num2 = (number5 / 1000) % 10;
    int num3 = (number5 / 100) % 10;
    int num4 = (number5 / 10) % 10;
    int num5 = number5 % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Yes! The entered number is a palindrome");
    }
    else
    {
        Console.WriteLine("No! The entered number is not a palindrome");
    }
}

// Done