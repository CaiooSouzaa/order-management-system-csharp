using Exercicios.Ex10;

public class Ex10_main
{
    public void Executar()
    {
        System.Console.WriteLine("Enter cliente data");
        System.Console.Write("Name: ");
        string name = Console.ReadLine();

        System.Console.Write("Email: ");
        string email = Console.ReadLine();

        System.Console.Write("Birth date (DD/MM/YYYT): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Client c1 = new Client(name, email, date);

        System.Console.WriteLine("Enter order data: ");
        System.Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        DateTime agora = DateTime.Now;

        Order order = new Order(agora, status, c1);

        System.Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"Enter {i + 1} item data: ");
            System.Console.Write("Product name: ");
            string nameProduct = Console.ReadLine();

            System.Console.Write("Product price: ");
            double priceProduct = double.Parse(Console.ReadLine());
            
            System.Console.Write("Quantity: ");
            int quantityProduct = int.Parse(Console.ReadLine());


            Product p1 = new Product(nameProduct, priceProduct);
            OrderItem oI = new OrderItem(priceProduct, quantityProduct, p1);

            order.AddItem(oI);
        }

        System.Console.WriteLine("");

        System.Console.WriteLine("ORDER SUMARY");

        System.Console.WriteLine("Order moment: " + agora.ToString("dd/MM/yyyy HH:mm:ss"));
        System.Console.WriteLine("Order status: " + order.Status);
        System.Console.WriteLine("Client: " +order.Client.Name + " (" + order.Client.Date.ToString("dd/MM/yyyy") + ") - " + order.Client.Email);
        System.Console.WriteLine("Order items");
        foreach(OrderItem oI in order.Itens)
        {
            System.Console.WriteLine(oI.Product.Name + ", $" + oI.Price.ToString("F2") + ", Quantity: " + oI.Quantity + ", Subtotal: $" + oI.SubTotal().ToString("F2"));

        }
        System.Console.WriteLine("Total price: " + order.Total());


    }
}