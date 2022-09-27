// See https://aka.ms/new-console-template for more information
Console.Write("Input a character: ");
string input;
input = Console.ReadLine();
bool isVowel = false;
foreach (var item in input)
{
	Console.WriteLine(item);
	if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
	{
		isVowel = true;
		break;
	}
}
if (isVowel)
{
	Console.WriteLine("You have input, Vowel");
}
else
{
	Console.WriteLine("This is not a Vowel");
}
