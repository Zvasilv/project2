Console.WriteLine("Введите число:");
string d = Console.ReadLine();
double[] res = new double[d.Length];
for (int i = 0; i < d.Length; i++)
{
    if (!char.IsDigit(d[i])) { Console.WriteLine($"Ошибка '{d[i]}' - не цифра"); continue; }
    int a = (int)char.GetNumericValue(d[i]);
    res[i] = Math.Pow(a, i);
    Console.WriteLine(res[i]);
}
