// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int rows = 4; 
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= rows - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = rows - 1; i >= 1; i--)
{
    for (int j = 1; j <= rows - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
