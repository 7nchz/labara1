Console.WriteLine("Введите первое число для вычисления частного двух целых чисел:");
string s = Console.ReadLine();
float a = float.Parse(s);

Console.WriteLine("Введите второе число для вычисления частного двух целых чисел:");
string s2 = Console.ReadLine();
float b = float.Parse(s2);

float c = a / b;
Console.WriteLine("Частное данных чисел:");
Console.WriteLine(c);
Console.ReadLine();