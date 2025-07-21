using System;

class Program
{
    static void Main()
    {
        bool Bool = true;
        byte Byte = 255;
        sbyte SByte = -128;
        char Char = 'A';
        decimal Decimal = 123.45m;
        double Double = 3.14159;
        float mFloat = 2.718f;
        int Int = 42;
        uint UInt = 100u;
        long Long = -9000000000000000000L;
        ulong ULong = 18000000000000000000UL;
        short Short = -32768;
        ushort UShort = 65535;
        string String = "Hello, world!";

        Console.WriteLine("bool: " + Bool);
        Console.WriteLine("byte: " + Byte);
        Console.WriteLine("sbyte: " + SByte);
        Console.WriteLine("char: " + Char);
        Console.WriteLine("decimal: " + Decimal);
        Console.WriteLine("double: " + Double);
        Console.WriteLine("float: " + mFloat);
        Console.WriteLine("int: " + Int);
        Console.WriteLine("uint: " + UInt);
        Console.WriteLine("long: " + Long);
        Console.WriteLine("ulong: " + ULong);
        Console.WriteLine("short: " + Short);
        Console.WriteLine("ushort: " + UShort);
        Console.WriteLine("string: " + String);
    }
}