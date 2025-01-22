using System;

class Program
{
	static Program()   // static constructor
        {
            Console.WriteLine("Static Constructor Executed!");
        }
	static void Main(){
		ImplicitConstructor imCons=new ImplicitConstructor();
		Console.WriteLine($"i = {imCons.i}");
            Console.WriteLine($"b = {imCons.b}");
            //value null will be printed, so here we checking the null
            if (imCons.s == null)
            {
                Console.WriteLine("s = null");
            }
            Console.ReadKey();
			
			ExplicitConstructor obj1 = new ExplicitConstructor();
            ExplicitConstructor obj2 = new ExplicitConstructor();
            ExplicitConstructor obj3 = new ExplicitConstructor();
            ExplicitConstructor obj4 = new ExplicitConstructor();
            Console.ReadKey();
			
			Employee e1 = new Employee();
            e1.Display();
            Console.ReadKey();
			
			ParameterizedConstructor a = new ParameterizedConstructor(10);
            ParameterizedConstructor b = new ParameterizedConstructor(20);
            Console.ReadKey();
			
			CopyConstructor c = new CopyConstructor(10);
            c.Display();
            CopyConstructor d = new CopyConstructor(c);
            d.Display();
            Console.ReadKey();
		
	}
	
}
