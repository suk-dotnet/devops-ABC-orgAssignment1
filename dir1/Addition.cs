class add
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("enter 1st num= ");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("enter 2nd num= ");
        b=int.Parse(Console.ReadLine());
        
        int result= a+b;
        
        Console.WriteLine("Addition is: "+result);
        Console.ReadKey();
    }
}