using System;
using System.Security.Cryptography;

partial class Program
{
    static void Main(string[] args)
    {
        CompositeFormatting composite = new CompositeFormatting();
        //string result = composite.CombineStrings("Hello", "World");

        //System.Console.WriteLine(result);

        //composite.InterpolateStrings("Hello", "World");

        //composite.FormatCurrency(123.45m, 50);

        //composite.FormatMeasurements(123456.78912m);

        //composite.FormatPercentages(.36785m);

        //composite.FormatDiscount(67.55m, 59.99m);

        //int invoiceNumber = 1201;
        //decimal productShares = 25.4568m;
        //decimal subtotal = 2750.00m;
        //decimal taxPercentage = .15825m;
        //decimal total = 3185.19m;

        //composite.DisplayInvoiceNumber(invoiceNumber);
        //composite.DisplayProductShares(productShares);
        //composite.DisplayCustomerCharge(subtotal);
        //composite.DisplayTax(taxPercentage);
        //composite.DisplayReceipt(total);

        //string paymentID = "769C";
        //string payeeName = "Mr. Stephen Ortega";
        //string paymentAmount = "$5,000.00";

        //string formattedLine = paymentID.PadRight(6);
        //formattedLine += payeeName.PadRight(24);
        //formattedLine += paymentAmount.PadLeft(10);

        //System.Console.WriteLine(formattedLine);

        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        // Your logic here
        string message = $"Dear Ms. {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n";

        Console.WriteLine(message + "Here's a quick comparison:\n");

        string comparisonMessage = $"{currentProduct.PadRight(19)}{currentReturn:P2}    {currentProfit:C}\n{newProduct.PadRight(19)}{newReturn:p2}    {newProfit:C}";

        // Your logic here

        Console.WriteLine(comparisonMessage);

    }
}