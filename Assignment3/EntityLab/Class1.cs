using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLab
{
    public class Class1
    {
        [Table("EmployeeTable")]
        public class Employee
        {
            [Key]
            [Column("EmpNo")]
            public int EmpNo { get; set; }

            [Column("Name")]
            public string Name { get; set; }

            [Column("Address")]
            public string Address { get; set; }

            [Column("Salary")]
            public double Salary { get; set; }

            public double AnnualSalary => Salary * 12;

            [Column("Designation")]
            public string Designation { get; set; }
        }

        [Table("StudentTable")]
        public class Student
        {
            [Key]
            [Column("RollNo")]
            public int RollNo { get; set; }

            [Column("Name")]
            public string Name { get; set; }

            [Column("Address")]
            public string Address { get; set; }

            [Column("Course")]
            public string Course { get; set; }
        }
    }
}
