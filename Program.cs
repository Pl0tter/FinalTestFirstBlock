void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}
// string[] textArray = { "Hello", "2", "world", ":-)" };
// string[] textArray = { "1234", "1567", "-2", "computer science" };
// string[] textArray = { "Russia", "Denmark", "Kazan" };

Console.WriteLine("Введите строки через ',':");
string[] textArray = Console.ReadLine().Split(',');
int count = 0;
for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length <= 3) count++;
}
string[] textArrayResult = new string[count];
count = 0;
for (int i = 0; i < textArray.Length; i++)
{
    if (textArray[i].Length <= 3)
    {
        textArrayResult[count] = textArray[i];
        count++;
    }
}

PrintArray(textArray);
PrintArray(textArrayResult);