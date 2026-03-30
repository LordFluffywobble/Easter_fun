using System.Globalization;
using System.Security.Cryptography;

//Oppgave 2
namespace Easter_fun;
public class Calculator
{
    public string DoMath(string op,double a, double b) => op switch
    {
      "+"   => $"The sum of {a} pluss {b} is: {a+b}",
      "-"   => $"The remainder of {a} divided by {b} is: {a-b}",
      "*"   => $"The product of {a} times {b} is: {a*b}",
      "/"   => $"The quotient of {a} divided by {b} is: {a/b}",
      _     => "Error"
    };
    
}
