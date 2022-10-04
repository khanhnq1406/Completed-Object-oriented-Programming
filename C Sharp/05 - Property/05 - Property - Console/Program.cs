using System.Collections.Specialized;

namespace PropertyConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
            Property property = new Property("World");
            property.username_prop = Console.ReadLine();
            Console.WriteLine("Username: " + property.username_prop + "\nPassword: " + property.password_prop);
        }
    }
}