/* Задача 7: Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber = number;

    Console.WriteLine($"Проверка введенного числа {number} на трёхзначность");
    int count = 1;
    int i = 10;
    while (number / i > 0)
    {
        i*=10;
        count++; 
    }
    Console.WriteLine($"Введённое число имеет {count} порядок");

if (count < 3 || count > 3)
    Console.WriteLine($"Введено не верное число!");

if (count == 3)
    Console.WriteLine($"Последняя цифра числа: {lastNumber % 10}");