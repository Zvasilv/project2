using System.Reflection.Metadata;


while (true)
{
    Console.WriteLine("Напишите выражение");
    string input = Console.ReadLine().Replace(" ", "");
    char[] simvol = { '+', '-', '*', '/', '^' };
    string[] parts = input.Split(simvol); // с помощью этой штуки, программа понимает, когда нужно отделить циферки от знака. Сам знак не читает. 
    bool a = float.TryParse(parts[0], out float c); // первое число
    bool b = float.TryParse(parts[1], out float d); // второе число
    if (!a || !b) // Проверяет на буквы, есть - перезапуск. Нет - продолжает программу
    {
        Console.WriteLine("Без букв"); 
        continue;
    }    
    string znak = "";
    foreach (char simvol2 in simvol) // находит знак и трансформирует его в символ.
    {
        if (input.Contains(simvol2))
        {
            znak = simvol2.ToString();
            break;
        }
    }
    
    if (znak == "+") { Console.WriteLine(c + d); }
    if (znak == "-") { Console.WriteLine(c - d); }
    if (znak == "*") { Console.WriteLine(c * d); }
    if (znak == "/" && d != 0) { Console.WriteLine(c / d); }
    if (znak == "/" && d == 0) { Console.WriteLine("Деление на 0 невозможно"); }
    if (znak == "^") Console.WriteLine(Math.Pow(c, d));
    break;
    
}

