// See https://aka.ms/new-console-template for more information
int count = 0;
bool isPrime = true;
for (int i = 2; ; i++)
{
    if (i == 2)
    {
        Console.WriteLine("2");
        count++;
        if (count > 10) break;
        continue;
    }
    for (int j = 2; j < i; j++)
    {
        if (i%j==0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine(i);
        count++;
        if (count > 10) break;
    }
    isPrime = true;

}
