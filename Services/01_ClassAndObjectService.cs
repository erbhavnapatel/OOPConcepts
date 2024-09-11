namespace OOPConcepts.Services
{
    // Class declaration
    // Primary constructor declaration
    public class Order(int orderId, int productId, string productName, int total)
    {
        // Instance variables
        public int orderId = orderId;
        public int productId = productId;
        public string? productName = productName;
        public int total = total;

        public int GetOrderId()
        {
            return this.orderId;
        }
        public int GetProductId()
        {
            return this.productId;
        }
        public string? GetProductName()
        {
            return this.productName;
        }
        public int GetTotal()
        {
            return this.total;
        }

        // Method
        public int TotalSum()
        {
            Console.WriteLine("Fetching total sum");
            return total;
        }
    }

    public class MainClassAndObject()
    {
        public void MainMethod()
        {
            // Creating object
            Order order = new(1, 1, "Product1", 500);
            Console.WriteLine(order.ToString());
        }
    }
}
