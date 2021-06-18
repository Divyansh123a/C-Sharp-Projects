using System;
class HelloWorld {
  public static void Main(string[] args) {
    Console.WriteLine("Enter rows");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter symboals");
    int s = Convert.ToInt32(Console.ReadLine());
    for(int i=0; i<r; i++)
    {
        for(int j=0; j<s; j++)
        {
            Console.Write("/\\");
        }
        Console.WriteLine("");
        for(int k=0; k<2*s; k++)
        {
            if(i!=(r-1)){
             if(k==0 || k==(2*s-1)){
                Console.Write("|");}
            else
            {
                Console.Write(" ");
            }
            }
        }
        Console.WriteLine("");
        
    }
  }
}
