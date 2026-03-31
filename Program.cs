using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Easter_fun;

class Program
{
    static void Main(string[] args)
    {
        int     []intArray      = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        char    []charArray     = ['a', 'b', 'c', 'A', 'B', 'C'];
        string  []stringArray   = ["Alice", "in", "Borderlands"];
        double  []doubleArray   = [1.2, 3.4, 5.6, 7.8, 9.0];
        bool    []boolArray     = [true, false, true, false];
        float   []floatArray    = [323423524, 2348402358032, 059805];
        decimal []decimalArray  = [324324234.34534636m, 23423453454.43635645764m];
        long    []longArray     = [234234, 235436456467, 4564354654, 3565675676];
        

        Console.WriteLine("Hello, World!");
        var data = Heisann();
        Console.WriteLine($"This prints the string {data.LittleString}");
        Console.WriteLine($"This prints the int type with the value {data.nr}");
        Console.WriteLine($"This prints the double type with the value {data.dd}");
        Console.WriteLine($"This prints the typc char with the value {data.a}");
        Console.WriteLine($"This prints the typc bool with the value {data.b}");
        
        var arrData = new List<(string Label, Array Data)>
        {
            ("int", intArray),
            ("char", charArray),
            ("string", stringArray),
            ("double", doubleArray),
            ("bool", boolArray),
            ("float", floatArray),
            ("decimal", decimalArray),
            ("long", longArray) 
        };

        foreach (var item in arrData)
        {
            string tString = "";
           
            foreach(var value in item.Data)
            {
                tString += value + " ";
            }

            Console.WriteLine(pType(item.Label, tString));
        }
     

    List<int> intString = new List<int>();
    intString.Add(1);
    intString.Add(2);
    foreach(int nr in intString)
        {
            Console.WriteLine(nr);
        }
       
    Dictionary<string, double> MyDict = new Dictionary<string, double>();

       MyDict.Add("Bond", 007);  //Only prints 7
       MyDict.Add("Born", 123);
    foreach(var thing in MyDict)
        {
            Console.WriteLine($"{thing.Key}: {thing.Value}");
        }

    // //Oppgave 2    
        Calculator Calc = new Calculator();
        Console.Write("Pick an option between +, -, * and /: ");
        string input = Console.ReadLine();
        Console.Write("Enter the first number you wish to calculate: ");
        double a = int.Parse(Console.ReadLine()); 
        Console.Write("Enter the second number you wish to calculate: ");
        double b = int.Parse(Console.ReadLine());
        
       Calc.DoMath(input, a, b);
        Console.WriteLine(Calc.DoMath(input, a, b));
    }
    
    static string pType(string op, string arr) => op switch
    {
        "int"       =>  $"Ints: {arr}\n",
        "char"      =>  $"Chars: {arr}\n",
        "string"    =>  $"Strings: {arr}\n",
        "double"    =>  $"Doubles: {arr}\n",
        "bool"      =>  $"Bools: {arr}\n",
        "float"     =>  $"Floats: {arr}\n",
        "decimal"   =>  $"Decimals: {arr}\n",
        "long"      =>  $"Longs: {arr}\n",
                   _=>  "Error"
    };

//Oppgave 1
    static (string LittleString, int nr, double dd, char a, bool b) Heisann()
    {
    string LittleString = "This is a little String";
    int nr = 5;
    double dd = 5.5;
    char a = 'A';
    bool b = true;
    
    return (LittleString, nr, dd, a, b);
    }


}
