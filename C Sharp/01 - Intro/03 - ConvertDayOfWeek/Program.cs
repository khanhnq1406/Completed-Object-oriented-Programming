// See https://aka.ms/new-console-template for more information

// Write a program that accepts a number between 1 and 7 from the user and returns the
// corresponding day of a week. (1 - Monday, 2 -Tuesday and so on)
int int_day_of_week = 0;
do
{
    Console.WriteLine("Input a number between 1 and 7: ");
    int_day_of_week = Convert.ToInt32(Console.ReadLine());
} while (int_day_of_week > 7 || int_day_of_week < 1);
switch (int_day_of_week)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        break;
}
