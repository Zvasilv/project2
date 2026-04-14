using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


while (true)
{
    Console.WriteLine("Напишите выражение");
    string input = Console.ReadLine().Replace(" ", null);
    char[] simvol = { '+', '-', '*', '/', '^' };
    input.IndexOfAny(simvol); // ищет есть ли символы. Он же индекс. 
    int index = input.IndexOfAny(simvol);

    if (index == -1) continue;

    char znak = input[index]; // Берем всё, что до знака и всё, что после.
    string part1 = input.Substring(0, index);
    string part2 = input.Substring(index + 1);
    if (float.TryParse(part1, out float c) && float.TryParse(part2, out float d))
    {
        float res = 0;
        int f = 6;
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