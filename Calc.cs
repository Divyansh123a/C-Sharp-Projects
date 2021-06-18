using System;

class CalculatorProgram
{
    public int Addition(int a,int b)
    {
        return a + b;
    }
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
    
    public int Multiplication(int a, int b)
    {
        return a*b;
    }
    
    public double Division(int a, int b, out double remainder)
    {
        remainder = a%b;
        return a/b;
    }
}

class Program{
    
    public static void Main(String[] args)
    {
        CalculatorProgram clc =  new CalculatorProgram();
        Console.WriteLine("Enter the operator");
        char op = Console.ReadLine()[0];
        Console.WriteLine("Enter the operands");
        int a =  Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        
        double remainder = 0.0;
        
        switch(op)
        {
            case '+':
                Console.WriteLine("Result of {a} + {b} is {clc.Addition(a,b)}");
                break;
            case '-':
                Console.WriteLine("Result of {a} - {b} is {clc.Subtraction(a,b)}");
                break;
            case '*':
                Console.WriteLine("Result of {a} * {b} is {clc.Multiplication(a,b)}");
                break;
            case '/':
                Console.WriteLine("Result of {a} / {b} is {clc.Division(a,b, out remainder)}");
                Console.WriteLine("Remainder = {remainder}");
                break;
                
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
