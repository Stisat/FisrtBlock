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

void PrintArray(string [] inArray)
{
    for (int j = 0; j < inArray.Length; j++)
    {
        Console.Write(inArray[j]+ "\t");
    }
}

void PrintSmallArray(string [] newArr)
{
    int mark = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if (newArr[i].Length <= 3)
        {
            Console.Write(newArr[i]+ "\t");
            mark = 1;
        }
    }
    Console.WriteLine();
    if (mark == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Нет строк с длинной в 3 символа и менее");
    }
}
   