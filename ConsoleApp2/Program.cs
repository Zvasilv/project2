while (true)
{
    decimal a, b, c, d;

    Console.WriteLine("Ваше действие?");
    Console.WriteLine("1 - сложить \n2 - вычесть \n3 - умножить \n4 - разделить");
    c = int.Parse(Console.ReadLine());
    if (c == 1 || c == 2 || c == 3 || c == 4)
    {   
        Console.WriteLine("ведите 1 число");
        if (decimal.TryParse(Console.ReadLine(), out a));
        else break;
        Console.WriteLine("ведите 2 число");
        if (decimal.TryParse(Console.ReadLine(), out b));
        else break;

        if (c == 4 && b != 0)
        {
            Console.WriteLine("Хотите раздилить с остатком?");
            Console.WriteLine("1 - Да \n2 - нет");

            if (decimal.TryParse(Console.ReadLine(), out d));
            

            if (d == 1)
            {

                Console.WriteLine("Результат");
                Console.WriteLine((decimal)a / (decimal)b);

            }
            else
            {

                Console.WriteLine("Результат");
                Console.WriteLine(a / b);
            }
        }
        if (c == 4 && b == 0)
        {
            Console.WriteLine("Деление на 0 невозможно");
        }
        if (c == 1)
        {
            Console.WriteLine("Результат");
            Console.WriteLine(a + b);
        }
        if (c == 2)
        {
            Console.WriteLine("Результат");
            Console.WriteLine(a - b);
        }
        if (c == 3)
        {
            Console.WriteLine("Результат");
            Console.WriteLine(a * b);
        }
        int res;
        {
            Console.WriteLine("желаете ли продолжить? \n 1 - да \n 2 - нет");
            res = int.Parse(Console.ReadLine());

            if (res == 1)
                Console.WriteLine(true);
            else break;
        }

    }
    else if (c != 1 || c != 2 || c != 3 || c != 4)
    {
        Console.WriteLine("Введен неверный номер, попробуйте ещё раз.");
    }

}
