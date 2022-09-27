// See https://aka.ms/new-console-template for more information
Console.Write("Input a number: ");
int number;
number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("{0} is Even", number);
}
else
{
    Console.WriteLine("{0} is Odd", number);
}
