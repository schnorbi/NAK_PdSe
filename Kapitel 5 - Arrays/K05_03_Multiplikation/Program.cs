int[] a = {11, 12, 13, 14, 15, 16};
int[] b = {21, 22, 23, 24, 25, 26};

int a_len = a.Length;
int b_len = b.Length;

int[] c = new int[b_len];

if (a_len == b_len)
{
    for (int i = 0; i < b_len; i++)
    {
        int j = b_len - 1 - i;
        c[i] = a[i] * b[j];
        Console.WriteLine($"c[{i}] = a[{i}] * b[{j}] = {a[i]} * {b[j]} = {c[i]}");
    }    
}
