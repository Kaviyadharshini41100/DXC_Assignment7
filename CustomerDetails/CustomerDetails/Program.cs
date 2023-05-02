namespace CustomerDetails
{
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string email { get; set; }
        public int Age { get; set; }
        public string Phoneno { get; set; }
        public string city { get; set; }
        public string Id { get; set; }
    }
    class Management
    {
        List<Customer> customers = new List<Customer>();
        public void AddDetails()
        {
            Console.WriteLine("Enter firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter mail");
            string mail = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneno");
            string phoneno = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            string id = Convert.ToString(firstname[0] + lastname[0] + phoneno[3]);
            Console.WriteLine(id);
            customers.Add(new Customer { Firstname = firstname, Lastname = lastname, email = mail, Age = age, Phoneno = phoneno, city = city, Id = id });
        }
        public void GetDetails()
        {
            foreach (Customer c in customers)

              Console.WriteLine($"{c.Id} {c.Firstname} {c.Lastname} {c.email} {c.Age} {c.city} {c.Phoneno}");

        }
        public void UpdateDetails()
        {
            Console.WriteLine("Enter id");
            string id = Console.ReadLine();
            foreach (Customer customer in customers)
            {
                if (customer.Id.Equals(id))
                {
                    Console.WriteLine("Enter first name");
                    customer.Firstname = Console.ReadLine();
                    customer.Firstname = Console.ReadLine();
                    Console.WriteLine("Enter last name");
                    customer.Lastname = Console.ReadLine();
                    customer.Lastname = Console.ReadLine();
                    Console.WriteLine("Enter age ");
                    customer.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter mail");
                    customer.email = Console.ReadLine();
                    Console.WriteLine("Enter phone number");
                    customer.Phoneno = (Console.ReadLine());
                    Console.WriteLine("Enter city");
                    customer.city = Console.ReadLine();
                }

            }

        }
        public bool DeleteDetails()
        {
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            foreach (Customer c in customers)
            {
                if (c.Age == age)
                {
                    customers.Remove(c);
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
            Management obj = new Management();

            while (true)
            {
                Console.WriteLine("1 Accept details");
                Console.WriteLine("2 Get Datails");
                Console.WriteLine("3 Update Details");
                Console.WriteLine("4 Delete Details");
                Console.WriteLine("Enter number");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        {
                            obj.AddDetails();
                            break;
                        }
                    case 2:
                        {
                            obj.GetDetails();
                            break;
                        }
                    case 3:
                        {
                           obj.UpdateDetails();
                            break;
                        }
                    case 4:
                        {
                            if (obj.DeleteDetails())
                            {
                                Console.WriteLine("deleted successfully");
                            }
                            else
                            {
                                Console.WriteLine("Age Not found");
                            }

                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Enter a valid information");
                            break;
                        }
                }
            }

        }
    }
}
