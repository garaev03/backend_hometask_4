namespace hometask_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ProductDB products=new ProductDB();
            Console.WriteLine();
            Console.WriteLine("1.ADD PRODUCT");
            Console.WriteLine("2.SEARCH PRODUCT");
            Console.WriteLine("3.PRODUCTS LIST");
            Console.WriteLine("4.LEAVE");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            while (true)
            {
                Console.Write("ENTER VALUE: ");
                string value = Console.ReadLine();
                switch (value)
                {
                    case "1":
                        AddProduct();
                        continue;
                    case "2":
                        Console.Write("SEARCH THE PRODUCT BY NAME: ");
                        products.searchProduct(Console.ReadLine());
                        continue;
                    case "3":
                        Console.WriteLine("PRODUCTS LIST:");
                        products.ProductsList();
                        continue;
                    case "4":
                        Console.WriteLine("YOU ENDED THE SESSION!");
                        return;
                    default:
                        Console.WriteLine("-PLEASE ENTER A VALID VALUE-");
                        continue;
                }
            }
            void AddProduct()
            {
                if (products.valid)
                {
                    i++;
                    Console.WriteLine("PRODUCT NUMBER: " + i);
                    Console.WriteLine("ADD PRODUCT ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ADD PRODUCT NAME: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("ADD PRODUCT PRICE: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Product product = new Product
                    {
                        ID = id,
                        NAME = name,
                        PRICE = price
                    };
                    products.addToProducts(product);
                }
                else
                {
                    Console.WriteLine("DATABASE IS ALREADY FULL!");
                }
            }    
        }
    }
}
