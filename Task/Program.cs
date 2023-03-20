using System;
using static System.Console;

Clear();

Write("введите элементы массива строк через пробел - ");
string[] FirstArray = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] EndArray = ArraySymbolLength(FirstArray, 3);
WriteLine($"[{string.Join(", ", FirstArray)}] -> [{string.Join(", ", EndArray)}]");


int LengthResultArray(string[] StartArray, int n)
{
    int count = 0;
    for (int i = 0; i < StartArray.Length; i++)
    {
        if (StartArray[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] ArraySymbolLength(string[] StartArray, int n)
{
    string[] result = new string[LengthResultArray(StartArray, n)];

    for (int i = 0, j = 0; i < StartArray.Length; i++)
    {
        if (StartArray[i].Length <= n)
        {
            result[j] = StartArray[i];
            j++;
        }
    }

    return result;
}
