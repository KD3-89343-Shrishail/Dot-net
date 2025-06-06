using System.Reflection;

namespace MathsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dllPath = @"E:\MyGit\dot net\Ms.Net\MathsLib\MathsLib.dll";
            Assembly mathsAssembly = Assembly.LoadFrom(dllPath);

            Type mathsType = mathsAssembly.GetType("MathsLib.Maths");
            object mathsInstance = Activator.CreateInstance(mathsType);

            while (true)
            {
                Console.WriteLine("1. Sum\n2. Subtract\n3. Multiply\n4. Divide\n5. Exit");
                Console.Write("Choose an operation: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5) break;

                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                string methodName = choice switch
                {
                    1 => "Sum",
                    2 => "Subtract",
                    3 => "Multiply",
                    4 => "Divide",
                    _ => null
                };

                MethodInfo method = mathsType.GetMethod(methodName);
                object result = method.Invoke(mathsInstance, new object[] { a, b });
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
