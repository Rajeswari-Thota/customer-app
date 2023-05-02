namespace customer_management
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
    public class Management
    {
        List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);

        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        public bool DeleteCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    customers.Remove(c);
                    return true;
                }
            }
            return false;
        }
        public bool UpdateCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    Console.WriteLine("Enter Customer First Name");
                    string fname = Console.ReadLine();
                    Console.WriteLine("Enter Customer Last Name");
                    string lname = Console.ReadLine();
                    Console.WriteLine("Enter Customer Email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Customer Age");
                    int age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter Customer phone");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Enter Customer city");
                    string city = Console.ReadLine();
                    c.Age = age;
                    c.Email = email;
                    c.FirstName = fname;
                    c.LastName = lname;
                    c.Phone = phone;
                    c.City = city;
                    return true;
                }
            }
            return false;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Management m = new Management();

            string ans = "";

            do
            {
                Console.WriteLine("Welcome to Customer Management App");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Display Customer By Id");
                Console.WriteLine("3. Display all Customers");
                Console.WriteLine("4. Delete Customer By Id");
                Console.WriteLine("5. Update Customer By Id");

                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {

                            Console.WriteLine("Enter Customer First Name");
                            string fname = Console.ReadLine();
                            Console.WriteLine("Enter Customer Last Name");
                            string lname = Console.ReadLine();
                            Console.WriteLine("Enter Customer Email");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter Customer Age");
                            int age = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter Customer phone");
                            string phone = Console.ReadLine();
                            Console.WriteLine("Enter Customer city");
                            string city = Console.ReadLine();
                            Random rnd = new Random();
                            int randomNum = rnd.Next(1, 100);
                            int username = randomNum;
                            int id = username;

                            m.AddCustomer(new Customer() { Id = id, FirstName = fname, LastName = lname, Email = email, Age = age, Phone = phone, City = city });
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Customer Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            Customer? p = m.GetCustomer(id);
                            if (p == null)
                            {
                                Console.WriteLine("Customer with specified id does not exists");
                            }
                            else
                            {
                                Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName} {p.Email} {p.Age} {p.Phone} {p.City}");
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (var p in m.GetCustomers())
                            {
                                Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName} {p.Email} {p.Age} {p.Phone} {p.City}");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Customer Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            if (m.DeleteCustomer(id))
                            {
                                Console.WriteLine("Customer Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Customer with specified id does not exist");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter Customer ID");
                            int id = Convert.ToInt16(Console.ReadLine());
                            if (m.UpdateCustomer(id))
                            {
                                Console.WriteLine("Customer Detail Updated Successfully!!");
                            }
                            else
                            {
                                Console.WriteLine("Customer with specified id does not exist");
                            }
                            break;

                        }
                }
                Console.WriteLine("Do you wish to continue? [y/n] ");
                ans = Console.ReadLine();
            } while (ans.ToLower() == "y");
        }
    }
}