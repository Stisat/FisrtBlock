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

string [] SmallArray(string [] newArr)
{
    string [] result = new string [newArr.Length];
    int j = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if (newArr[i].Length <= 3)
        {
            result[j] = newArr[i];
            j++;
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
string [] ArrStr = SetArrayStr(size);
Console.WriteLine();
Console.WriteLine("Ваш массив строк:");
PrintArray(ArrStr);
Console.WriteLine();
Console.WriteLine("Итог:");
string [] newArrStr = SmallArray(ArrStr);
PrintArray(newArrStr);
