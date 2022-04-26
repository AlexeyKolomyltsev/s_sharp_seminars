Console.Write("Put number a ");
int a = int.Parse(Console.ReadLine());
Console.Write("Put number b ");
int b = int.Parse(Console.ReadLine());
Console.Write("Put number c ");
int c = int.Parse(Console.ReadLine());
int max;
if (a > b)
{
    max = a;
    if (c > max) max = c;
}
else
{
    max = b;
    if (c > max) max = c;
}
Console.Write("Max = ");
Console.Write(max);