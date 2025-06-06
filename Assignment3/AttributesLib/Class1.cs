namespace AttributesLib
{
    public class Class1
    {
        [AttributeUsage(AttributeTargets.Class)]
        public class DataTableAttribute : Attribute
        {
            public string TableName { get; }
            public DataTableAttribute(string name) => TableName = name;
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class DataColumnAttribute : Attribute
        {
            public string ColumnName { get; }
            public DataColumnAttribute(string name) => ColumnName = name;
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class KeyColumnAttribute : Attribute { }

        [AttributeUsage(AttributeTargets.Property)]
        public class UnMappedAttribute : Attribute { }
    }
}
