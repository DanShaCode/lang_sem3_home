// Принимаем на вход пятизначное число 
// Проверяем является ли число полиндромом

// Пример числа полиндрома - 121; 676; 1331; 4884; 94949;

int number5 = Convert.ToInt32(Console.ReadLine());

if (number5 < -99999 | number5 > -10000 && number5 < 10000 | number5 > 99999)
{
    Console.WriteLine("Input error. Enter a five-digit number.");
}



// int num1 = number5 / 10000;

// int num2 = (number5 / 1000) % 10;

// int num3 = (number5 / 100) % 10;

// int num4 = (number5 / 10) % 10;

// int num5 = number5 % 10;

// Console.WriteLine(num5);