namespace assigment_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>
        {
            new Customer("Alice", "123-456-7890", "alice@example.com"),
            new Customer("Bob", "098-765-4321", "bob@example.com")
        };


            PerformActionOnCustomers(customers, PrintCustomerDetails);


            PerformActionOnCustomers(customers, SendWelcomeEmail);
        }


        public static void PerformActionOnCustomers(List<Customer> customers, Action<Customer> action)
        {
            foreach (var customer in customers)
            {
                action(customer);
            }
        }


        public static void PrintCustomerDetails(Customer customer)
        {
            Console.WriteLine($"Name: {customer.Name}, Mobile: {customer.Mobile}, Email: {customer.Email}");
        }


        public static void SendWelcomeEmail(Customer customer)
        {
            Console.WriteLine($"Sending welcome email to {customer.Email}");
        }
    }
}
