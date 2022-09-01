public class Program
{


    static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Welcome to the Lab 2 assignment. " +
            "Press ENTER to start the program!");
        Console.ReadLine();
        Console.Clear();

        program.Question1();
        program.Question2();

    }
    
    public void Question1 ()
    {
        Console.WriteLine("First we are going to add two numbers!");
        Console.WriteLine("Please type the first number");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Great! Now type the second number!");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Thank you! The sum of {a} + {b} = {a + b}");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to move to the next question.");
        Console.ReadLine();
        Console.Clear();
    }



    public void Question2()
    {
        Console.WriteLine("Now we are going to multiply two numbers!");
        Console.WriteLine("Please type the first number");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Great! Now type the second number!");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine($"Thank you! The sum of {c} * {d} = {c * d}");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to move to the next question.");
        Console.ReadLine();
        Console.Clear();

    }
}
