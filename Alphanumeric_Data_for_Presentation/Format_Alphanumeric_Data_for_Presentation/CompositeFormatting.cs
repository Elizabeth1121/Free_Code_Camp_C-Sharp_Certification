partial class Program
{
    public class CompositeFormatting
    {
        public string CombineStrings(string first, string second)
        {
            return String.Format("{0} {1}!", first, second);
        }

        public void InterpolateStrings(string first, string second)
        {
            System.Console.WriteLine($"{first} {second}");
            System.Console.WriteLine($"{second} {first}");
            System.Console.WriteLine($"{first} {first} {first}");
        }

        public void FormatCurrency(decimal price, int discount)
        {
            System.Console.WriteLine($"Price: {price:C} (save: {discount:C})");
        }

        public void FormatMeasurements(decimal measurement)
        {
            System.Console.WriteLine($"Measurement: {measurement:N} units");

            System.Console.WriteLine($"Measurement: {measurement:N4} units");
        }

        public void FormatPercentages(decimal tax)
        {
            System.Console.WriteLine($"Tax rate: {tax:P2}");
        }

        public void FormatDiscount(decimal price, decimal salePrice)
        {
            System.Console.WriteLine("You saved {0:C2} off the regular {1:C2} rate", price - salePrice, price);
            System.Console.WriteLine($"A discount of {((price - salePrice) / price):P2}");
        }

        public void DisplayInvoiceNumber(int input)
        {
            System.Console.WriteLine($"Invoice Number: {input}");
        }

        public void DisplayProductShares(decimal shares)
        {
            System.Console.WriteLine($" Shares: {shares:N3} Product");
        }

        public void DisplayCustomerCharge(decimal charge)
        {
            System.Console.WriteLine($"         Sub Total: {charge:C}");
        }

        public void DisplayTax(decimal tax)
        {
            System.Console.WriteLine($"         Tax: {tax:P2}");
        }

        public void DisplayReceipt(decimal receipt)
        {
            System.Console.WriteLine($"         Total Billed: {receipt:C}");
        }
    }
}