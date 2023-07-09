using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.Clear();
        int totalSoldToday = 0;
        Address address1 = new Address("123 Star Wars Street","Ebbyville","Utah","United Kingdom");
        Customer customer1 = new Customer("Ebby Anne", address1);
        List<Product> productList1 = new List<Product>();
        Product product1 = new Product("32 Gigs (16 X 2) DDR4 2400 Desktop Ram","706542",45,4);
        productList1.Add(product1);
        Product product2 = new Product("NVMe 4.0 SSD 2048 GB","134072",100,2);
        productList1.Add(product2);
        Order order1 = new Order(productList1, customer1);
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.LabelPacket());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}\n");
        totalSoldToday = totalSoldToday + (product1.TotalPrice() + product2.TotalPrice());

        Address address2 = new Address("123 Valley View Drive","Ebbyville","Utah","United States");
        Customer customer2 = new Customer("Rascal", address2);
        List<Product> productList2 = new List<Product>();
        Product product3 = new Product("Gaming Laptop","290793",1299,1);
        productList2.Add(product3);
        Product product4 = new Product("Ryzen 7600X Processor","247141",400,1);
        productList2.Add(product4);
        Order order2 = new Order(productList2, customer2);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.LabelPacket());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");  
        totalSoldToday = totalSoldToday + (product3.TotalPrice() + product4.TotalPrice());

        Address address3 = new Address("123 Valley View Drive","Rexville","Ebbyville","Scotland");
        Customer customer3 = new Customer("Moldy", address3);
        List<Product> productList3 = new List<Product>();
        Product product5 = new Product("Gaming Desktop","219605",1099,2);
        productList3.Add(product5);
        Product product6 = new Product("Intel Core I-7 13700x Processor","132739",600,1);
        productList3.Add(product6);
        Order order3 = new Order(productList3, customer3);
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine(order3.LabelPacket());
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost()}"); 
        totalSoldToday = totalSoldToday + (product5.TotalPrice() + product6.TotalPrice()); 
        Console.WriteLine();
        Console.WriteLine($"Total sales for today is: ${totalSoldToday}");
    }
}