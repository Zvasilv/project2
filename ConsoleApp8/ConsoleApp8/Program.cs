Console.WriteLine("Пиши оно само решит");
string input = Console.ReadLine().Replace(" ", "");
char[] simvol = { '+', '-', '*', '/', '^' };
string[] parts = input.Split(simvol); // с помощью этой штуки, программа понимает, когда нужно отделить циферки от знака. Сам знак не читает. 
float a = float.Parse(parts[0]); // первое число
float b = float.Parse(parts[1]); // второе число
string znak = "";
foreach (char simvol2 in simvol) // находит знак и трансформирует его в символ.
{
    if (input.Contains(simvol2))
    {
        znak = simvol2.ToString();
        break;
    }
}
if (znak == "+") { Console.WriteLine(a + b); }
if (znak == "-") { Console.WriteLine(a - b); }
if (znak == "*") { Console.WriteLine(a * b); }
if (znak == "/" && b != 0) { Console.WriteLine(a / b); }
if (znak == "/" && b == 0) { Console.WriteLine("Деление на 0 невозможно"); }
if (znak == "^") Console.WriteLine(Math.Pow(a, b));