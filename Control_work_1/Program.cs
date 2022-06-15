Console.Clear();
string[] stringarr;
stringarr = new string[4] { "hello", "2", "world", ":-)" };
string a;
int size = 0;  // Размер массива stringarr2
int j = 0;

for (int i = 0; i < stringarr.Length; i++)
{
    a = stringarr[i];
    if (a.Length <= 3)
    {
        size = size + 1;
    }
}

string[] stringarr2;
stringarr2 = new string[size];

for (int i = 0; i < stringarr.Length; i++)
{
    a = stringarr[i];
    if (a.Length <= 3)
    {
        stringarr2[j] = a;
        j = j + 1;

    }
}
string Print(string[] array)
{
    string res = string.Empty;
    res = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) res = res + $"{array[i]}" + ", ";
        else res = res + $"{array[i]}" + ".";
    }
    res = res + "]";

    return res;
}

Console.WriteLine(Print(stringarr));
Console.WriteLine(Print(stringarr2));