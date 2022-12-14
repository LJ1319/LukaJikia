using System.Collections.Immutable;

namespace CustomersOrders
{
    internal class Program
    {
        static void Main()
        {
            string customersFile = @"C:\Users\LJ\source\repos\LukaJikia\Day_25\Practice\CustomersOrders\Customers.txt";
            string ordersFile = @"C:\Users\LJ\source\repos\LukaJikia\Day_25\Practice\CustomersOrders\Orders.txt";

            List<Customer> customersList = new List<Customer>();
            string[] customersText = File.ReadAllLines(customersFile);

            List<Order> ordersList = new List<Order>();
            string[] ordersText = File.ReadAllLines(ordersFile);

            foreach (var line in customersText)
            {
                Customer customer = new Customer
                {
                    CustomerId = int.Parse(line.Split('|')[0]),
                    CustomerName = line.Split('|')[1]
                };

                customersList.Add(customer);
            }

            foreach (var line in ordersText)
            {
                Order order = new Order
                {
                    OrderId = int.Parse(line.Split('|')[0]),
                    Date = DateOnly.Parse(line.Split('|')[1]),
                    Product = line.Split('|')[2],
                    Price = double.Parse(line.Split('|')[3]),
                    CustomerId = int.Parse(line.Split('|')[4]),
                };

                ordersList.Add(order);
            }

            //foreach (var customer in customersList)
            //{
            //    Console.WriteLine(customer);
            //}

            //foreach (var order in ordersList)
            //{
            //    Console.WriteLine(order);
            //}

            // 1 - თითოეული კლიენტის შეკვეთების რაოდენობა.
            var customerId = 1;
            var customerOrdersCount = from c in customersList
                                      join o in ordersList
                                      on c.CustomerId equals o.CustomerId
                                      where c.CustomerId == customerId
                                      select o;
            Console.WriteLine($"Customer with id {customerId} has following orders:");
            foreach (var customerOrder in customerOrdersCount)
            {
                Console.WriteLine(customerOrder);
            }
            Console.WriteLine("------------------------------");

            // 2 - თითოეული კლიენტის შეკვეთების ჯამური ფასი.
            Console.WriteLine($"Orders sum of customer with id {customerId} is:");
            var customerOrdersSum = (from c in customersList
                                     join o in ordersList
                                     on c.CustomerId equals o.CustomerId
                                     where c.CustomerId == customerId
                                     select o.Price).Sum();

            Console.WriteLine(customerOrdersSum);
            Console.WriteLine("-------------------------- ----");

            // 3 - თითეული კლიენტის მინიმალური შეკვეთის ფასი.
            Console.WriteLine($"Minimum order price of customer with id {customerId} is:");
            var customerOrdersMinAmount = (from c in customersList
                                           join o in ordersList
                                           on c.CustomerId equals o.CustomerId
                                           where c.CustomerId == customerId
                                           select o.Price).Min();

            Console.WriteLine(customerOrdersMinAmount);
            Console.WriteLine("------------------------------");

            // 4 - მხოლოდ ის კლიენტები ვისაც ერთზე მეტი შეკვეთა აქვთ.
            Console.WriteLine($"Customer(s) with more than one order:");
            var customersMoreThanOneOrder = from c in customersList
                                            join o in ordersList
                                            on c.CustomerId equals o.CustomerId into g
                                            where g.Count() > 1
                                            select new
                                            {
                                                c.CustomerId,
                                                c.CustomerName,
                                            };

            foreach (var customerMoreThanOneOrder in customersMoreThanOneOrder)
            {
                Console.WriteLine($"{customerMoreThanOneOrder.CustomerId}|{customerMoreThanOneOrder.CustomerName}");
            }
            Console.WriteLine("------------------------------");

            // 5 - მხოლოდ ის კლიენტები ვისი საშუალო შეკვეთაც მეტია 10-ზე.
            Console.WriteLine($"Customer(s) with average more than 10:");
            var customersAverageMoreThanTen = from c in customersList
                                              join o in ordersList
                                              on c.CustomerId equals o.CustomerId into g
                                              select new
                                              {
                                                  c.CustomerName,
                                                  c.CustomerId,
                                                  Orders = g,
                                                  Average = g.Average(o => o.Price)
                                              };

            foreach (var customerAverageMoreThanTen in customersAverageMoreThanTen)
            {
                if (customerAverageMoreThanTen.Average > 10)
                {
                    Console.WriteLine($"{customerAverageMoreThanTen.CustomerId}|{customerAverageMoreThanTen.CustomerName}");
                }
            }
            Console.WriteLine("------------------------------");
        }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public override string? ToString()
        {
            return $"{CustomerId}|{CustomerName}";
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public DateOnly Date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int CustomerId { get; set; }

        public override string? ToString()
        {
            return $"{OrderId}|{Date}|{Product}|{Price}|{CustomerId}";
        }
    }
}