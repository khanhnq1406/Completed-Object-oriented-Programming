using System.Collections.Specialized;

internal class Program
{
    class Property
    {
        private string username;
        private string password;
        public Property(string password)
        {
            this.password = password;
        }
        public string username_prop 
        { 
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string password_prop
        {
            get
            {
                return password;
            }
        }
    }
    private static void Main(string[] args)
    {
        Property property = new Property("World");
        property.username_prop = Console.ReadLine();
        Console.WriteLine("Username: " + property.username_prop + "\nPassword: " + property.password_prop);
    }
}