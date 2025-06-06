using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace ORMConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] objects = { new EntityLab.Class1.Employee(), new EntityLab.Class1.Student() };

            foreach (var obj in objects)
            {
                Type type = obj.GetType();
                var tableAttr = type.GetCustomAttribute<TableAttribute>();
                if (tableAttr == null) continue;

                string tableName = tableAttr.Name;
                var props = type.GetProperties()
                                .Where(p => p.GetCustomAttribute<Attribute>() == null)
                                .Where(p => p.GetCustomAttribute<ColumnAttribute>() != null);

                string columnList = string.Join(", ", props.Select(p => p.GetCustomAttribute<ColumnAttribute>().Name));
                string valueList = string.Join(", ", props.Select(p => "@" + p.Name));

                string insertSQL = $"INSERT INTO {tableName} ({columnList}) VALUES ({valueList});";

                // Output to file
                File.AppendAllText("sql_output.txt", insertSQL + Environment.NewLine);

                Console.WriteLine($"Generated SQL for {type.Name}:");
                Console.WriteLine(insertSQL);
            }
        }
    }
}
