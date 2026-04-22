Console.WriteLine("Введите число:");
string d = Console.ReadLine();
for (int i = 0; i < d.Length; i++)
{
    if (!int.TryParse(d[i].ToString(), out int a)) 
        { Console.WriteLine($"Ошибка '{d[i]}' - не цифра"); continue; }
    Console.WriteLine(Math.Pow(a, i));
}