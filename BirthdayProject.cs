using System;
using System.IO;

public class Person
{
    //Fill code her
    private string firstName;
    private string lastName;
    private  DateTime dob;
    
    public string FirstName
    {
        get
        {
           return this.firstName; 
        }
        set
        {
            this.firstName=value;
        }
    }
    
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        
        set
        {
            this.lastName = value;
        }
    }
    public DateTime Dob
    {
        get 
        {
            return this.dob;
        }
        set
        {
            this.dob=value;
        }
    }
    
    public string Adult
    {
        get
        {
            if(GetAge(dob) >= 18)
            {
                return "Adult";
            }
            
            else
            {
                return "Child";
            }
        }
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine("First Name: " + this.firstName);
        Console.WriteLine("Last Name: " + this.lastName);
        Console.WriteLine("Age: " + GetAge(this.dob));
        Console.WriteLine(this.Adult);
    }
    
    public int GetAge(DateTime dob)
    {
        DateTime curntDate = DateTime.Today;
        int age = curntDate.Year - dob.Year;
        
        if(dob < curntDate)
        {
            if(dob.Month > curntDate.Month)
            {
                age--;
            }
        }
        return age;
    }
}

public class Progarm
{
    public static void Main(String[] args)
    {
        //Fill code here 
        Person p = new Person();
        
        Console.WriteLine("Enter first name");
        p.FirstName = Console.ReadLine();
        Console.WriteLine("Enter last name");
        p.LastName = Console.ReadLine();
        Console.WriteLine("Enter date of birth in yyy/mm/dd format");
        p.Dob =  DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
        
        p.DisplayDetails();
    }
}
