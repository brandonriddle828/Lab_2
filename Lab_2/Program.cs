public class Program
{


    static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Welcome to the Lab 2 assignment. " +
            "Press ENTER to start the program!");
        Console.ReadLine();
        Console.Clear();

       // program.Question1();
       // program.Question2();
        program.Question3();

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

    public void Question3()
    {

        string[] names = 
        { 
            "sbyte", "byte", "short", "ushort",
            "int", "uint", "long", "ulong", "float", "double", "decimal" 
        };


        int[] size = 
        { 
            sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), 
            sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float),sizeof(double),sizeof(decimal) 
        };

        string [] min =
        {
            sbyte.MinValue.ToString(), byte.MinValue.ToString(), short.MinValue.ToString(),  ushort.MinValue.ToString(), 
            int.MinValue.ToString(), uint.MinValue.ToString(), long.MinValue.ToString(), ulong.MinValue.ToString(), float.MinValue.ToString(), 
            double.MinValue.ToString(), decimal.MinValue.ToString()
        };

        string[] max=
{
            sbyte.MaxValue.ToString(), byte.MaxValue.ToString(), short.MaxValue.ToString(),  ushort.MaxValue.ToString(),
            int.MaxValue.ToString(), uint.MaxValue.ToString(), long.MaxValue.ToString(), ulong.MaxValue.ToString(), float.MaxValue.ToString(),
            double.MaxValue.ToString(), decimal.MaxValue.ToString()
        };


        Console.WriteLine("===========================================================================================================");
        Console.WriteLine("{0,-20} {1,5} {2,30} {3,39}\n", "Type", "Bytes in memory", "Min", "Max");
        Console.WriteLine("===========================================================================================================");
        for (int i = 0; i < names.Length; i++)
            Console.WriteLine("{0,-20} {1,5:N1} {2,40}{3,40}", names[i], size[i], min[i], max[i]);




    }
}
