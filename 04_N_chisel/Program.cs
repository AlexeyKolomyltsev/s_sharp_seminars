Console.Write("Put number a ");
int a = int.Parse(Console.ReadLine());
int count = - a;
while (count <= a)
{
    Console.Write(" " + count);
    count += 1;
}