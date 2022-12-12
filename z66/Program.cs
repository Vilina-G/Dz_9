Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, " +
                          "которая найдёт сумму натуральных элементов в промежутке от M до N.");
int[] valueN = GetEnteredNumbers("Задайте значения M и N через пробел или запятую: ", true);
if (valueN.Length >= 2 && valueN[0] > 0 && valueN[1] > 0)
{
    int result = SumBetweenMn(valueN[0], valueN[1]);
    Console.WriteLine($"M = {valueN[0]}; N = {valueN[1]} -> {result}");
}
else
    Console.WriteLine("Введено не корректное значение(Пример: 4, 8)");

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

int SumBetweenMn(int m, int n)
{
    if (n > m)
        return n + SumBetweenMn(m, n - 1);
    return m;
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30
}