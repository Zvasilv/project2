Console.WriteLine("Пиши оно само решит");
string input = Console.ReadLine();
string[] parts = input.Split(' '); // нужно да бы  разбить пример на первое число, знак и второе число
float a = float.Parse(parts[0]); // первое число
string znak = parts[1]; // знак
float b = float.Parse(parts[2]); // втрое число
if (znak == "+") {Console.WriteLine(a + b); }
if (znak == "-") { Console.WriteLine(a - b); }
if (znak == "*") { Console.WriteLine(a * b); }
if (znak == "/" && b != 0) { Console.WriteLine(a / b); }
if (znak == "/" && b == 0) { Console.WriteLine("Деление на 0 невозможно"); }
if (znak == "^") Console.WriteLine(Math.Pow(a, b));