string [] SetArrayStr(int strNum)
{
    string [] result = new string [strNum];
    for (int i = 0; i < strNum; i++)
    {
        Console.WriteLine($"Введите {i+1} строку");
        result[i] = Convert.ToString(Console.ReadLine());
    }
    return result;
}

