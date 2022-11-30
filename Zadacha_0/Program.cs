Console.Clear();
Console.WriteLine ("Введите число");
int number = int.Parse(Console.ReadLine());
//Console.WriteLine (number);
int square = number * number;
//Console.Write ("квадрат числа = ");
//Console.WriteLine ("квадрат числа" + number +"=" + square);
Console.WriteLine ($"квадрат числа {number} = {square}");
