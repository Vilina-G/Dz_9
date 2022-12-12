Console.WriteLine("Задача 64: Задайте значение N. Напишите программу," +
                          " которая выведет все натуральные числа в промежутке от N до 1." +
                          " Выполнить с помощью рекурсии.");

int[] valueN = GetEnteredNumbers("Задайте значение N: ", true);
if (valueN.Length >= 1 && valueN[0] > 0)
    RecursionN(valueN[0]);
else
    Console.WriteLine("Введено не корректное значение(Пример: 5)");

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

void RecursionN(int num, int count = 1)
{
    if (count == 1)
        Console.Write($"N = {num} -> ");
    if (num != 0)
    {
        RecursionN(num - 1, count + 1);
        Console.Write($"{count} ");
    }
    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
}
