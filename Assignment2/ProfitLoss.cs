using System;

class ProfitLoss
{
    public static void calc()
    {
        double costPrice = 129;
        double sellingPrice = 191;
        double profit = sellingPrice - costPrice;
        double profitPercentage = (profit / costPrice) * 100;
        Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
                          $"The Profit is INR {profit:F2} and the Profit Percentage is {profitPercentage:F2}%");
    }
}
