namespace lw1;

internal class Program1
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Byte: {Byte.MinValue} | {Byte.MaxValue}");
        Console.WriteLine($"SByte: {SByte.MinValue} | {SByte.MaxValue}");
        Console.WriteLine($"Char: {Char.MinValue} | {Char.MaxValue}");
        Console.WriteLine($"DateTime: {DateTime.MinValue} | {DateTime.MaxValue}");
        Console.WriteLine($"Single: {Single.MinValue} | {Single.MaxValue}");
        Console.WriteLine($"Double: {Double.MinValue} | {Double.MaxValue}");
        Console.WriteLine($"Decimal: {Decimal.MinValue} | {Decimal.MaxValue}");
        Console.WriteLine($"Int16: {Int16.MinValue} | {Int16.MaxValue}");
        Console.WriteLine($"Int32: {Int32.MinValue} | {Int32.MaxValue}");
        Console.WriteLine($"Int64: {Int64.MinValue} | {Int64.MaxValue}");
        Console.WriteLine($"UInt16: {UInt16.MinValue} | {UInt16.MaxValue}");
        Console.WriteLine($"UInt32: {UInt32.MinValue} | {UInt32.MaxValue}");
        Console.WriteLine($"UInt64: {UInt64.MinValue} | {UInt64.MaxValue}");
        
        Program2.Pr2();
        Program3.Pr3();
    }
}