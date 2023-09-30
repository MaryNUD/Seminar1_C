Console.Clear();
Console.WriteLine("Write the number a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the number b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("max = ");
    Console.Write(a);
}
else
{
    Console.Write("max = ");
    Console.Write(b);
}