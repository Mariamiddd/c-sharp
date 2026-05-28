namespace davaleba7_methods_and_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vqmnit product objects
            Product product1 = new Product();
            product1.id = 1;
            product1.name = "Mobile Phone";
            product1.description = "A high-end smartphone with a sleek design and powerful features.";
            product1.price = 600;
            product1.quantity = 50;
            product1.brand = "Samsung";
            product1.category = "Electronics";
            product1.rating = 4.5;
            product1.isAvailable = true;
            product1.discountPercent = 10;

            double discountedPrice = product1.calculateDiscountedPrice();
            product1.raiseQuantity(20);


            //product information displayed in console
            Console.WriteLine($"Product Name: {product1.name}");
            Console.WriteLine($"Description: {product1.description}");
            Console.WriteLine($"Quantity: {product1.quantity}");
            Console.WriteLine($"Brand: {product1.brand}");
            Console.WriteLine($"Category: {product1.category}");
            Console.WriteLine($"Rating: {product1.rating}");
            Console.WriteLine($"Available: {(product1.isAvailable ? "maragshia" : "araa maragshi")}");

            if (product1.hasActiveDiscount())
            {
                Console.WriteLine($"original price: ${product1.price}");
                Console.WriteLine($"discount price: ${discountedPrice}");
            }
            else
            {
                Console.WriteLine($"Standard Price: ${product1.price} (No active discounts)");
            }
        }
    }

    //product class
    public class Product()
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public double rating { get; set; }
        public bool isAvailable { get; set; }
        public double discountPercent { get; set; }

        //fasdaklebis gamotvla
        public double calculateDiscountedPrice()
        {
           return price - (price * discountPercent / 100);
            

        }

        //vzrdit raodenobas
        public void raiseQuantity(int amount)
        {
            quantity += amount;
        }

        //check products aqvs to ara fasdakleba
        public bool hasActiveDiscount()
        {
            return discountPercent > 0;
        }

    }

    

}
