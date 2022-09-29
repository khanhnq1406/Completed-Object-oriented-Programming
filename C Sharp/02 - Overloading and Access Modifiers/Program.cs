using System.Runtime.CompilerServices;
using System.Security.AccessControl;

internal class Program
{
    enum LuongNhanVien
    {
        NV1,
        NV2 = 10,
        NV3,
        NV4,
    };
    private static void Main(string[] args)
    {
        MyFloat a = new MyFloat(1.1f);
        MyFloat b = new MyFloat(2.2f);
        MyFloat c = new MyFloat();
        c = a + b;
        Console.WriteLine("a + b = {0}", c.ToString());
        c = a - b;
        Console.WriteLine("a - b = {0}", c.ToString());
        string strRef = "Ref string";
        string strOut;
        Ref(ref strRef);
        Out(out strOut);
        Console.WriteLine("Ref: {0}\nOut: {1}", strRef, strOut);
        Console.WriteLine("---enum---\nNV1: {0}\nNV2: {1}\nNV3: {2}\nNV4: {3}\n",(int)LuongNhanVien.NV1, LuongNhanVien.NV2, (int)LuongNhanVien.NV3, (int)LuongNhanVien.NV4);
        Console.ReadKey();
    }
    private static void Ref(ref string strRef)
    {
        strRef = "Hello";
    }
    private static void Out(out string strOut)
    {
        strOut = "Hi";
    }
}