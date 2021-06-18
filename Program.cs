using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals4              //DO NOT CHANGE the name of namespace
{
    public class Program                 //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)   //DO NOT CHANGE 'Main' Signature
        {
            
            Console.WriteLine("Enter any alphabet : ");
            //Get the value
char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter number of repeats : ");
            //Get the valu
            int n =Convert.ToInt32(Console.ReadLine());
           for(int i=1; i<=n; i+=2)
           {
               for(int x =1; x<=(n-i)/2; x++)
               {
                   Console.Write(" ");
               }
                   for(int k=1; k<=i; k++)
                   {
                       Console.Write(c);
                   }
                    Console.WriteLine("");
               
           }
}}}
