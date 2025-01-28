using System;

public class NumberChecker2
{
    public static int GetDigitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    public static int[] GetDigits(int number)
    {
        int digitCount = GetDigitCount(number);
        int[] digits = new int[digitCount];
        
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        return digits;
    }

    public static int[] ReverseDigitsArray(int[] digits)
    {
        int i=0;
		int j=digits.Length-1;
		while(i<j){
			int temp=digits[i];
			digits[i]=digits[j];
			digits[j]=temp;
			i++;
			j--;
		}
		return digits;
    }

    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;
        
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }

        return true;
    }

    public static bool IsPalindrome(int number)
    {
        int[] digits = GetDigits(number);
        int[] reversedDigits = ReverseDigitsArray((int[])digits.Clone());
        
        return AreArraysEqual(digits, reversedDigits);
    }

    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigits(number);
        
        foreach (int digit in digits)
        {
            if (digit != 0)
                return true;
        }
        
        return false;
    }
	
	public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Count of digits: " + GetDigitCount(number));

        int[] digitsArray = GetDigits(number);
        Console.WriteLine("Digits array: [" + string.Join(", ", digitsArray) + "]");

        int[] reversedDigits = ReverseDigitsArray(digitsArray);
        Console.WriteLine("Reversed Digits: [" + string.Join(", ", reversedDigits) + "]");

        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine("Is Palindrome: " + isPalindrome);

        bool isDuckNumber = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuckNumber);
		
		Console.WriteLine("Enter the size of the first array:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[n1];
        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < n1; i++)
        {
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the size of the second array:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] array2 = new int[n2];
        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < n2; i++)
        {
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool areArraysEqual =AreArraysEqual(array1, array2);
        Console.WriteLine("Are the two arrays equal? " + areArraysEqual);
    }
}


    

