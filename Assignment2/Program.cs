namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.AcceptDetails();
            s.PrintDetails();
        }
    }

    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student()
        {
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }


        public int Std
        {
            get
            {
                return std;
            }
            set
            {
                std = value;
            }
        }

        public char Div
        {
            get
            {
                return div;
            }
            set
            {
                div = value;
            }
        }

        public double Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }


        public void AcceptDetails()
        {
            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the gender true - Male, false - Female ");
            gender = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter the age : ");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the std : ");
            std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the div : ");
            div = Console.ReadLine()[0];


            Console.WriteLine("Enter the marks : ");
            marks = Convert.ToDouble(Console.ReadLine());

        }

        public void PrintDetails()
        {
            Console.WriteLine("Name = " + name);
            if(gender == true)
            {
                Console.WriteLine("Gender = Male");
            }
            else
            {
                Console.WriteLine("Gender = Female");
            }
            Console.WriteLine("Age = "+ age);
            Console.WriteLine("Std = " + std);
            Console.WriteLine("div = " + div);
            Console.WriteLine("Marks = " + marks);
        }

    }
}
