namespace SealedClass
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }

    }
    sealed class Executive : Employee
    {
        public double Money { get; set; }
        public string Type { get; set; }


        public Executive() : base()
        {
            Money = 0;
            Type = string.Empty;
        }

        public Executive(int id, string firstName, string lastName, double money, string type)
            : base(id, firstName, lastName)
        {
            Money = money;
            Type = type;


        }

        public override double Pay()
        {
         
            return Money;
        }




        static void Main(string[] args)
        {
            // employee object
            Employee mike = new Employee(5, "Mike", "Smith");
            mike.Fullname();
            mike.Pay();
            
       

            //executive object created using parameterized constructor
            Executive Bob = new Executive(10, "Bob", "Jones", 1000000, "mangmnt");

            Console.WriteLine($"{Bob.Fullname()}");
            Console.WriteLine($"The salary is : {(Bob.Pay())}");

            // executive object created using the default constructor
            // values are assigned using properties
            Executive Scott = new Executive();
            Scott.Id = 20;
            Scott.FirstName = "Scott";
            Scott.LastName = "Baker";
            Scott.Type = "Manager";
            Scott.Money = 2000000;
            Console.WriteLine(Scott.Fullname());
            Console.WriteLine(Scott.Pay());

        }
    }
}
