Console.Clear();
Console.WriteLine("Write the number:");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 1)
{
    for (int i = 1; i <= n; i++)
    if ((i % 2) == 0)
        Console.Write(i + " ");
}
else
Console.WriteLine("The inserted number is <= 1, error");