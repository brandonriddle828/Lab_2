public class Program
{


    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Lab 2 assignment. ");
        
        Program program = new Program();
        program.Question1();

    }
    
        public void Question1 ()
        {

            Console.WriteLine("Now we are going to add two numbers!");
            Console.WriteLine("Please type the first number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Great! Now type the second number!");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Thank you! The sum of {a} + {b} = {a + b}");

        }
    
}
