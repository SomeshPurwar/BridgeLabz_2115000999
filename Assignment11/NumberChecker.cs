using System;


public class NumberChecker
{
    public static int CountDigits(int number)
    {
		int len=0;
		while(number>0){
			len++;
			number/=10;
		}
		return len;
    }

    public static int[] GetDigitsArray(int number)
    {
		int len=CountDigits(number);
        int[] digit=new int[len];
		int i=len-1;
		while(number>0){
			int a=number%10;
			digit[i--]=a;
			number/=10;
		}
		return digit;
    }

    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        return digits.Contains(0) && digits[0] != 0;
    }

    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int digitCount = digits.Length;
        int sum = 0;
		for(int i=0;i<digits.Length;i++){
			sum+=(int)Math.Pow(digits[i],digitCount);
		}
        return sum == number;
    }

    public static (int largest, int secondLargest) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue, secondLargest = int.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit < largest)
            {
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }

    public static (int smallest, int secondSmallest) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue, secondSmallest = int.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit > smallest)
            {
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
	

    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {number}");

        int digitCount = CountDigits(number);
        Console.WriteLine($"Count of digits: {digitCount}");

        int[] digitsArray = GetDigitsArray(number);
        Console.WriteLine("Digits array: [" + string.Join(", ", digitsArray) + "]");

        bool isDuck = IsDuckNumber(number);
        Console.WriteLine($"Is Duck Number: {isDuck}");

        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine($"Is Armstrong Number: {isArmstrong}");

        var (largest, secondLargest) = FindLargestAndSecondLargest(digitsArray);
        Console.WriteLine($"Largest digit: {largest}, Second Largest digit: {secondLargest}");

        var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digitsArray);
        Console.WriteLine($"Smallest digit: {smallest}, Second Smallest digit: {secondSmallest}");
    }
}
