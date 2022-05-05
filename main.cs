using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int sidea;
        int sideb;
        int sidec;

        Console.WriteLine("Please enter the Lengths of the sides on the triangle");
        Console.WriteLine("");

        Console.Write("Side A: ");
        sidea = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Side B: ");
        sideb = Convert.ToInt32(Console.ReadLine());
        Console.Write("");
        Console.Write("Side C: ");
        sidec = Convert.ToInt32(Console.ReadLine());
        Console.Write("");

        if (sidea <= 0 || sideb <= 0 || sidec <= 0 )
        {
            Console.Write("Somthing went wrong...");
        }
        else
        {
        if (sidea == sideb && sideb == sidec && sidec == sidea)
        {
            Console.Write("Your triangle is an equilateral.");
        }
        else if (sidea == sideb || sideb == sidec || sidec == sidea)
        {
            Console.Write("Your triangle is an isosceles.");
        }
        else if (sidea != sideb && sideb != sidec && sidec != sidea)
        {
            Console.Write("Your triangle is an scalene.");
        }
        else
        {
            Console.Write("Somthing went wrong...");
        }

        Console.WriteLine("\nDone.");
        }
    }
}