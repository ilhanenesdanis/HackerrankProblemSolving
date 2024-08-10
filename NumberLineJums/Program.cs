

Console.WriteLine(kangaroo(0,2,5,3));



static string kangaroo(int x1, int v1, int x2, int v2)
{
    if (x1 < x1 || v1 < v2)
    {
        return "NO";
    }

    if (v1 != v2 && (x2 - x1) % (v2 - v1) == 0)
    {
        return "YES";

    }

    return "NO";

}