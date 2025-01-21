public class Operators
{
    public static void operators()
    {
		// Basic Operators
		int Result;
        int Num1 = 20, Num2 = 10;
        // Addition Operation
        Result = (Num1 + Num2);
        Console.WriteLine($"Addition Operator: {Result}" );
        // Subtraction Operation
        Result = (Num1 - Num2);
        Console.WriteLine($"Subtraction Operator: {Result}");
        // Multiplication Operation
        Result = (Num1 * Num2);
        Console.WriteLine($"Multiplication Operator: {Result}");
        // Division Operation
        Result = (Num1 / Num2);
        Console.WriteLine($"Division Operator: {Result}");
        // Modulo Operation
        Result = (Num1 % Num2);
        Console.WriteLine($"Modulo Operator: {Result}");
		
		
		// Assignment Operators
		int x = 15;
            x += 10;  //It means x = x + 10 i.e. 15 + 10 = 25
            Console.WriteLine($"Add Assignment Operator: {x}");
            // initialize variable x again
            x = 20;
            x -= 5;  //It means x = x - 5 i.e. 20 - 5 = 15
            Console.WriteLine($"Subtract Assignment Operator: {x}");
            // initialize variable x again
            x = 15;
            x *= 5; //It means x = x * 5  i.e. 15 * 5 = 75
            Console.WriteLine($"Multiply Assignment Operator: {x}");
            // initialize variable x again
            x = 25;
            x /= 5; //It means x = x / 5 i.e. 25 / 5 = 5
            Console.WriteLine($"Division Assignment Operator: {x}");
            // initialize variable x again
            x = 25;
            x %= 5; //It means x = x % 5 i.e. 25 % 5 = 0
            Console.WriteLine($"Modulo Assignment Operator: {x}");
			
			// Relational Operators
			bool Res;
            int N1 = 5, N2 = 10;
            // Equal to Operator
            Res = (N1 == N2);
            Console.WriteLine("Equal (=) to Operator: " + Res);
            // Greater than Operator
            Res = (N1 > N2);
            Console.WriteLine("Greater (<) than Operator: " + Res);
            // Less than Operator
            Res = (N1 < N2);
            Console.WriteLine("Less than (>) Operator: " + Res);
            // Greater than Equal to Operator
            Res = (N1 >= N2);
            Console.WriteLine("Greater than or Equal to (>=) Operator: " + Res);
            // Less than Equal to Operator
            Res = (N1 <= N2);
            Console.WriteLine("Lesser than or Equal to (<=) Operator: " + Res);
            // Not Equal To Operator
            Res = (N1 != N2);
            Console.WriteLine("Not Equal to (!=) Operator: " + Res);
			
			// Logical Operators
			bool a = true, b = false, c;
            //Logical AND operator
            c = a && b;
            Console.WriteLine("Logical AND Operator (&&) : " + c);
            //Logical OR operator
            c = a || b;
            Console.WriteLine("Logical OR Operator (||) : " + c);
            //Logical NOT operator
            c = !a;
            Console.WriteLine("Logical NOT Operator (!) : " + c);
			
			// Bitwise Operators
			int p = 12, q = 25, ans;
            // Bitwise AND Operator
            ans = p & q;
            Console.WriteLine($"Bitwise AND: {ans}");
            // Bitwise OR Operator
            ans = p | q;
            Console.WriteLine($"Bitwise OR: {ans}");
            // Bitwise XOR Operator
            ans = p ^ q;
            Console.WriteLine($"Bitwise XOR: {ans}");


	
	
	
        
    }
		
}