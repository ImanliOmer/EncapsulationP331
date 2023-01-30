namespace EncapsulationP331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(678904, "Alex", "Foxtrot");
            invoice.Article = "USB-hab";
            invoice.Quantity = 6;
            invoice.Price = 30;

            var totalPrice =invoice.CostCalculation(true);
            Console.WriteLine(totalPrice);
        }
    }
}