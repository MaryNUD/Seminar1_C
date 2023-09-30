Console.Clear();
Console.WriteLine("Write the number a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the number b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the number c:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
else if (c > max)
{
    max = c; 
}
Console.Write("max number = ");
Console.Write(max);