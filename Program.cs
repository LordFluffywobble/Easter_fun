using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Easter_fun;

class Program
{
    static void Main(string[] args)
    {
        // var data = Heisann();

        // Console.WriteLine("Hello, World!");
        // Console.WriteLine($"This prints the string {data.LittleString}");
        // Console.WriteLine($"This prints the int type with the value {data.nr}");
        // Console.WriteLine($"This prints the double type with the value {data.dd}");
        // Console.WriteLine($"This prints the typc char with the value {data.a}");
        // Console.WriteLine($"This prints the typc bool with the value {data.b}");
        

     { 
        int     []intArray      = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // char    []charArray     = ['a', 'b', 'c', 'A', 'B', 'C'];
        // string  []stringArray   = ["Alice", "in", "Borderlands"];
        // double  []doubleArray   = [1.2, 3.4, 5.6, 7.8, 9.0];
        // bool    []boolArray     = [true, false, true, false];
        // float   []floatArray    = [323423524, 2348402358032, 059805];
        // decimal []decimalArray  = [324324234.34534636m, 23423453454.43635645764m];
        // long    []longArray     = [234234, 235436456467, 4564354654, 3565675676];


        string st ="";
        

       // Console.Write("Ints: "); 
        foreach(int num in intArray)
            {
                // Console.Write(num + " ");
                st += num + " ";
            }
        Console.WriteLine("Ints: " + st + "\n");
        // string pType(string st, string op) => op switch
        //     {
        //         "int"   =>  $"ints: {output}",
            
        //         _       => "Error"
        //     };      

        // Console.WriteLine("ints: ");
        // foreach(int num in intArray)
        // {
        //     Console.Write(num + " ");
        // }
        // Console.WriteLine("\n");
        

        // Console.WriteLine("chars: ");
        // foreach(char l in charArray)
        // {
        //     Console.Write(l + " ");  
        // }
        // Console.WriteLine("\n");
        

        // Console.WriteLine("strings: ");
        // foreach (string s in stringArray)
        // {
        //     Console.Write(s + " ");
        // }
        // Console.WriteLine("\n");
        

        // Console.WriteLine("doubles: ");
        // foreach (double d in doubleArray)
        // {
        //     Console.Write(d + " ");
        // }
        // Console.WriteLine("\n");
        
   
        // Console.WriteLine("bools: ");
        // foreach (bool b in boolArray)
        // {
        //     Console.Write(b + " ");
        // }
        // Console.WriteLine("\n");
        

        // Console.WriteLine("floats: ");
        // foreach (float f in floatArray)
        // {
        //     Console.Write(f + " ");    
        // }
        // Console.WriteLine("\n");

        // Console.WriteLine("decimals: ");
        // foreach (decimal d in decimalArray)
        // {
        //     Console.Write(d + " ");
        // }
        // Console.WriteLine("\n");

        // Console.WriteLine("longs: ");
        // foreach (long l in longArray)
        // {
        //     Console.Write(l + " ");
        // }
        // Console.WriteLine("\n");
     }    

    // //Oppgave 2    
    //     Calculator Calc = new Calculator();
    //     Console.Write("Pick an option between +, -, * and /: ");
    //     string input = Console.ReadLine();
    //     Console.Write("Enter the first number you wish to calculate: ");
    //     double a = int.Parse(Console.ReadLine()); 
    //     Console.Write("Enter the second number you wish to calculate: ");
    //     double b = int.Parse(Console.ReadLine());
        
    //    Calc.DoMath(input, a, b);
    //     Console.WriteLine(Calc.DoMath(input, a, b));
    }
    
//Oppgave 1
    // static (string LittleString, int nr, double dd, char a, bool b) Heisann()
    // {
    // string LittleString = "This is a little String";
    // int nr = 5;
    // double dd = 5.5;
    // char a = 'A';
    // bool b = true;
    
    // return (LittleString, nr, dd, a, b);
    // }

//Oppgave 2

}
