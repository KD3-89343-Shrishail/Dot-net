namespace Assignment1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Substract");
                Console.WriteLine("3. Multiple");
                Console.WriteLine("4. Divison");


                choice = Convert.ToInt32(Console.ReadLine());

                if(choice > 0 && choice < 5)
                {
                    Console.WriteLine("Enter first number ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number ");
                    int j = Convert.ToInt32(Console.ReadLine());



                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("result = " + add(i, j));
                            break;

                        case 2:
                            Console.WriteLine("result = " + sub(i, j));
                            break;

                        case 3:
                            Console.WriteLine("result = " + mul(i, j));
                            break;

                        case 4:
                            Console.WriteLine("result = " + div(i, j));
                            break;

                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                }

            } while (choice > 0 && choice < 5);

        }

        public static int add(int i, int j)
        {
            return (i + j);
        }

        public static int sub(int i, int j)
        {
            return (i - j);
        }

        public static int mul(int i, int j)
        {
            return (i * j);
        }

        public static int div(int i, int j)
        {
            return (i / j);
        }

    }
}
