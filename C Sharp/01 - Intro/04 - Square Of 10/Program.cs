// See https://aka.ms/new-console-template for more information
// Write a program that calls a method to find the square of a number.
int number;
Console.Write("Input a number: ");
number = Convert.ToInt32(Console.ReadLine());
CalcSqr(number);
Console.ReadKey();

static void CalcSqr(int number)
{
    int result;
    result = number*number;
    Console.WriteLine("Square of the number {0} is {1}",number,result);
}
