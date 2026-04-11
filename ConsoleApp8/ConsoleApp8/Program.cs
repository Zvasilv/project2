using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


while (true)
{
    Console.WriteLine("Напишите выражение");
    string input = Console.ReadLine().Replace(" ", null); 
    char[] simvol = { '+', '-', '*', '/', '^' }; 
    input.IndexOfAny(simvol); // Ищидит есть ли символы. Он же индекс. 
    int index = input.IndexOfAny(simvol);
    if (index == -1) continue;
    char znak = input[index];
    string[] parts = input.Split(simvol); // с помощью этой штуки, программа понимает, когда нужно отделить циферки от знака. Сам знак не читает.
    if (float.TryParse(parts[0], out float c) && float.TryParse(parts[1], out float d)) // Проверяет на буквы, есть - перезапуск. Нет - продолжает программу.
    {
        float res = 0;
        int f = 0;
        switch (znak)
        {
            case '+':
                res = c + d;
                break;
            case '-':
                res = c - d;
                break;
            case '*':
                res = c * d;
                break;
            case '/':
                if (d != 0) 
                { 
                    res = c / d;                   
                    Console.WriteLine("Сколько знаков после запятой вы хотите увидеть?");
                    f = int.Parse(Console.ReadLine());
                }
                if (d == 0) 
                { 
                    Console.WriteLine("Деление на 0 невозможно");
                    continue;
                }
                break;
            case '^':
                res = (float)Math.Pow(c, d);
                break;

        }      
        res = float.Round(res, f);
        Console.WriteLine($"Результат: {res}");
    }
    else 
    {
           Console.WriteLine("Без букв");
           continue;
    }      
}