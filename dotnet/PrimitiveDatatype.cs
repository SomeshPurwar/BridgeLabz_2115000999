public class PrimitiveDatatypes
{
    public static void primitive()
    {
		// byte
        byte b1 = 66;
            //You cannot store negative number using byte data type.
            //The following statement will give compile time error
            //byte b2 = -100;
            //The following Statement will give compile time error
            //The maximum value you can store in a byte variable is 255
            //byte b3 = 256;
            Console.WriteLine($"Decimal: {b1}");
            Console.WriteLine($"ASCII Equivalent Character of {b1} is {(char)b1}");
            Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"Byte Size:{sizeof(sbyte)} Byte");
            
            sbyte sb1 = 66;
            //You can store negative number using sbyte data type.
            //The following statement will not give compile time error
            sbyte sb2 = -100;
            //The following Statement will give compile time error
            //The maximum value you can store in a sbyte variable is 128
            //sbyte sb3 = 128;
            //The following Statement will give compile time error
            //The minimum value you can store in a sbyte variable is -128
            //sbyte sb4 = -129;
            Console.WriteLine($"\nDecimal: {sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb1} is {(char)sb1}");
            Console.WriteLine($"ASCII Equivalent Character of {sb2} is {(char)sb2}");
            Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
            Console.WriteLine($"SByte Size:{sizeof(sbyte)} Byte");
            
			
			// char 
			char ch = 'B';
            Console.WriteLine($"Char: {ch}");
            Console.WriteLine($"Equivalent Number: {(byte)ch}");
            Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
            Console.WriteLine($"Char Size: {sizeof(char)} Byte");
			
			// string
			string str = "ABC";
            var howManyBytes = str.Length * sizeof(Char);
            Console.WriteLine($"str Value: {str}");
            Console.WriteLine($"str Size: {howManyBytes}");
            
			// Numeric without decimal
			//Int16 num1 = 123;
            short num1 = 123;
            //Int32 num2 = 456;
            int num2 = 456;
            // Int64 num3 = 789;
            long num3 = 789;
            Console.WriteLine($"short Min Value:{short.MinValue} and Max Value:{short.MaxValue}");
            Console.WriteLine($"short Size:{sizeof(short)} Byte");
            Console.WriteLine($"int Min Value:{int.MinValue} and Max Value:{int.MaxValue}");
            Console.WriteLine($"int Size:{sizeof(int)} Byte");
            Console.WriteLine($"long Min Value:{long.MinValue} and Max Value:{long.MaxValue}");
            Console.WriteLine($"long Size:{sizeof(long)} Byte");
			
			// Numeric Datatype with decimal
			float a = 1.123f;
            double b = 1.456;
            decimal c = 1.789m;
            
            Console.WriteLine($"float Size:{sizeof(float)} Byte");
            Console.WriteLine($"float Min Value:{float.MinValue} and Max Value:{float.MaxValue}");
            Console.WriteLine($"double Size:{sizeof(double)} Byte");
            Console.WriteLine($"double Min Value:{double.MinValue} and Max Value:{double.MaxValue}");
            Console.WriteLine($"decimal Size:{sizeof(decimal)} Byte");
            Console.WriteLine($"decimal Min Value:{decimal.MinValue} and Max Value:{decimal.MaxValue}");
            Console.ReadKey();
			
			
    }
		
}