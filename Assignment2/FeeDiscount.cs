using System;

class FeeDiscount
{
    public static void calc()
    {
        double fee = 125000;
        double discountPercent = 10;

        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
    }
}
