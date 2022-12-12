Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. " +
                          "Даны два неотрицательных числа m и n.");
int[] valueN = GetEnteredNumbers("Задайте два неотрицательных числа M и N " +
                                         "через пробел или запятую: ", true);
if (valueN.Length >= 2 && valueN[0] > 0 && valueN[1] > 0)
{
    int result = Akkerman(valueN[0], valueN[1]);
    Console.WriteLine($"m = {valueN[0]}, n = {valueN[1]} -> A(m,n) = {result}");
}
else
    Console.WriteLine("Введено не корректное значение(Пример: 2, 3)");

int[] GetEnteredNumbers(string outputText = "", bool inline = false)
{
    var arrayInts = Array.Empty<int>();
    if (inline)
        Console.Write(outputText);
    else
        Console.WriteLine(outputText);
    try
    {
        char[] separators = { ' ', ',' };
        var arrayOfEnteredText = Console.ReadLine()
            ?.Split(separators,
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (arrayOfEnteredText != null)
            arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }

    return arrayInts;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    return Akkerman(m - 1, Akkerman(m, n - 1));
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29
}