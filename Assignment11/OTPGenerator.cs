using System;

public class OTPGenerator
{
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 999999);
    }

    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void print()
    {
        int[] otpArray = new int[10];

        for (int i = 0; i < 10; i++)
        {
            otpArray[i] = GenerateOTP();
            Console.WriteLine($"Generated OTP {i + 1}: {otpArray[i]}");
        }

        bool areUnique = AreOTPsUnique(otpArray);
        if (areUnique)
        {
            Console.WriteLine("\nAll OTPs are unique.");
        }
        else
        {
            Console.WriteLine("\nSome OTPs are not unique.");
        }
    }
}
