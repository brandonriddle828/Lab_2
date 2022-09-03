public class Program
{


    static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("Welcome to the Lab 2 assignment. " +
            "Press 'Enter' to start the program!");
        Console.ReadLine();
        Console.Clear();

        //program.Question1();
        //program.Question2();
        //program.Question3();
        program.Question4();

    }

    public void Question1()
    {
        bool flag = false;
        do
        {
            try
            {
                Console.WriteLine("First we are going to add two numbers!");
                Console.WriteLine("Please type the first number.");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Great! Now type the second number.");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Thank you! The sum of {a} + {b} = {a + b}");
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to move to the next question.");
                Console.ReadLine();
                Console.Clear();
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
                Console.WriteLine("You have entered something wrong, please try again.");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        while (flag == false);
    }



    public void Question2()
    {
        bool flag = false;
        do
        {
            try
            {
                Console.WriteLine("Now we are going to multiply two numbers!");
                Console.WriteLine("Please type the first number.");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Great! Now type the second number.");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine($"Thank you! The sum of {c} * {d} = {c * d}");
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to move to the next question.");
                Console.ReadLine();
                Console.Clear();
                flag = true;
            }

            catch (Exception e)
            {
                flag = false;
                Console.WriteLine("You have entered something wrong, please try again.");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        while (flag == false);

    }

    public void Question3()
    {

        Console.WriteLine("This is the 3rd question.");
        Console.WriteLine("Here is neatly printed list of data types.");
        Console.WriteLine();

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
        Console.WriteLine("{0,-20} {1,5} {2,40}{3,40}", names[i], size[i], min[i], max[i]);
        Console.WriteLine("===========================================================================================================");
        Console.WriteLine();
        Console.WriteLine("Please press enter to move to the next question.");
        Console.ReadLine();
        Console.Clear();

    }

    public void Question4()
    {
       
        bool flag = false;
        do
        {
            try
            {
                Console.Clear();
                flag = true;
                Console.WriteLine("This is the final question on the assignment.\n" +
                    "Here we have created a 5 function calculator!");
                Console.WriteLine();
                Console.WriteLine("Please press 'Enter' To Start");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("Please type the first number you want to start with!");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Now type the operator sign you wish to use. Example ( -, +, *, /, or % )");
                string y = Console.ReadLine();
                Console.WriteLine("Now type the last number you wish to use!");
                double z = double.Parse(Console.ReadLine());
                double result=0;

                switch(y)
                {
                    case "+":
                        {
                            Console.WriteLine("Great! So...");
                            result = x + z;
                            Console.WriteLine($"{x}{y}{z} = {result}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();

                        }

                        break;

                        case "-":
                        {
                            Console.WriteLine("Great! So...");
                            result = x - z;
                            Console.WriteLine($"{x}{y}{z} = {result}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();

                        }

                        break;

                    case "*":
                        {
                            Console.WriteLine("Great! So...");
                            result = x * z;
                            Console.WriteLine($"{x}{y}{z} = {result}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();

                        }

                        break;

                    case "/":
                        {
                            Console.WriteLine("Great! So...");
                            result = x / z;
                            Console.WriteLine($"{x}{y}{z} = {result}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();

                        }

                        break;

                    case "%":
                        {
                            Console.WriteLine("Great! So...");
                            result = x % z;
                            Console.WriteLine($"{x}{y}{z} = {result}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();

                        }
                        break;

                        default:
                        {
                                        
                            flag = false;
                            Console.WriteLine("You have entered something wrong, please press enter and try again.");
                            Console.WriteLine();
                            Console.WriteLine();

                        }
                        break;
                }



                if (Console.ReadKey().Key != ConsoleKey.Escape && flag==true)
                

                    do
                    {
                        Console.WriteLine($"Your previous result is {result} \nWhat would you like to do next to this number?");
                        Console.WriteLine($"Type the operator sign you wish to use. Ex (-,+,*,/,%)");
                        string sign = Console.ReadLine();
                        Console.WriteLine("Now choose the next number you wish to use!");
                        double nextNumber = double.Parse(Console.ReadLine());



                        if (sign == "+")
                        {
                            Console.WriteLine("Great! So...");
                            Console.WriteLine($"{result} + {nextNumber} = {result = result + nextNumber}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();
               


                        }
                        else if (sign == "-")
                        {
                            Console.WriteLine("Great! So...");
                            Console.WriteLine($"{result} - {nextNumber} = {result = result - nextNumber}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();
               
                        }
                        else if (sign == "*")
                        {
                            Console.WriteLine("Great! So...");
                            Console.WriteLine($"{result} * {nextNumber} = {result = result * nextNumber}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();
               
                        }
                        else if (sign == "/")
                        {
                            Console.WriteLine("Great! So...");
                            Console.WriteLine($"{result} / {nextNumber} = {result = result / nextNumber}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();
               

                        }
                        else if (sign == "%")
                        {
                            Console.WriteLine("Great! So...");
                            Console.WriteLine($"{result} % {nextNumber} = {result = result % nextNumber}");

                            Console.WriteLine();
                            Console.WriteLine("Do you wish to use the calculator again?\n" +
                                "No:Press 'esc' \n" +
                                "Yes:Press any other key");
                            Console.WriteLine();

                        }

                        else
                        {
                            flag = false;
                            Console.WriteLine("You have entered something wrong, please press enter and try again.");
                            Console.WriteLine();
                            Console.WriteLine();
                      
                            
                        }

                    }
        
                    while (Console.ReadKey().Key != ConsoleKey.Escape && flag == true);
                   
            }

            catch (Exception e)
            {
                flag = false;
                Console.WriteLine("You have entered something wrong, please press enter and try again.");
                Console.WriteLine();
                Console.WriteLine();
                
                Console.Clear();
            }
        }
        while (flag == false) ;

    }
   
}
