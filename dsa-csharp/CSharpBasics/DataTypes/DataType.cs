namespace dsa_csharp.CSharpBasics.DataTypes
{
    public class DataType
    {
        public static void Run()
        {
            // Integer types
            int intValue = 100;
            long longValue = 10000000000;
            short shortValue = 32000;

            // Floating point types
            float floatValue = 10.5f;
            double doubleValue = 20.1234;
            decimal decimalValue = 30.12345m;

            // Character and string
            char charValue = 'A';
            string stringValue = "Hello, World!";

            // Boolean
            bool boolValue = true;

            // Type conversion
            int convertedInt = Convert.ToInt32(doubleValue);
            string intToString = intValue.ToString();

            // Nullable type
            int? nullableInt = null;

            // var and dynamic
            var implicitInt = 100; // Type inferred at compile-time
            dynamic dynamicValue = 100; // Type resolved at runtime

            Console.WriteLine($"int: {intValue}, long: {longValue}, short: {shortValue}");
            Console.WriteLine($"float: {floatValue}, double: {doubleValue}, decimal: {decimalValue}");
            Console.WriteLine($"char: {charValue}, string: {stringValue}");
            Console.WriteLine($"bool: {boolValue}");
            Console.WriteLine($"Converted int: {convertedInt}, int to string: {intToString}");
            Console.WriteLine($"Nullable int: {nullableInt}");
            Console.WriteLine($"var: {implicitInt}, dynamic: {dynamicValue}");
        }


        // to run this file please call in program.cs. 
    }
}
