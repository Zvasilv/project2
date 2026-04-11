using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


while (true)
{
    Console.WriteLine("Напишите выражение");
    string input = Console.ReadLine().Replace(" ", ""); 
    char[] simvol = { '+', '-', '*', '/', '^' }; 
    input.IndexOfAny(simvol); // Ищидит есть ли символы
    int index = input.IndexOfAny(simvol);
    if (index == -1) continue;
    char znak = input[index];
    string[] parts = input.Split(simvol); // с помощью этой штуки, программа понимает, когда нужно отделить циферки от знака. Сам знак не читает.
    if (float.TryParse(parts[0], out float c) && float.TryParse(parts[1], out float d)) // Проверяет на буквы, есть - перезапуск. Нет - продолжает программу
    {
        float e = 0;
        switch (znak)
        {
            case '+':
                e = c + d;
                break;
            case '-':
                e = c - d;
                break;
            case '*':
                e = c * d;
                break;
            case '/':
                if (d != 0) { e = c / d; }
                if (d == 0) 
                { 
                    Console.WriteLine("Деление на 0 невозможно");
                    continue;
                }
                break;
            case '^':
                e = (float)Math.Pow(c, d);
                break;
        }
        Console.WriteLine($"Результат: {e}"); 
    }
    else 
    {
           Console.WriteLine("Без букв");
           continue;
    }      
}