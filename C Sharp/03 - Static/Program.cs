static class StaticClass
{
    public static string str_of_StaticClass;
    static StaticClass()
    {
        str_of_StaticClass = "This is string of Static Class";
    }
    public static void FuncOfStaticClass()
    {
        Console.WriteLine("This is function of Static Class");
    }
}
class StaticVariable
{
    public static string str_of_StaticVariable;
    public StaticVariable()
    {
        str_of_StaticVariable = "This is string of Static Variable";
    }
    public static void Test(string input)
    {
        str_of_StaticVariable = input;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------Static Class Example------");
        Console.WriteLine(StaticClass.str_of_StaticClass);
        StaticClass.FuncOfStaticClass();
        Console.WriteLine("------Static Variable Example------");
        StaticVariable.str_of_StaticVariable = "This is string of static variable before assign";
        Console.WriteLine(StaticVariable.str_of_StaticVariable);
        StaticVariable.Test("hello");
        Console.WriteLine("This is string of static variable after assign");
        Console.WriteLine(StaticVariable.str_of_StaticVariable);


    }
}