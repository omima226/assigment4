namespace assigment_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee("Alice", 5, 60000),
            new Employee("Bob", 3, 50000),
            new Employee("Charlie", 10, 80000)
        };


            SortEmployees(employees, (e1, e2) => e1.YearsOfExperience.CompareTo(e2.YearsOfExperience));
            Console.WriteLine("Employees sorted by years of experience:");
            PrintEmployees(employees);


            CalculateBonus(employees, e => e.Salary * 0.10);
            Console.WriteLine("\nBonuses based on salary (10%):");
            PrintBonuses(employees);


            CalculateBonus(employees, e => e.YearsOfExperience * 1000);
            Console.WriteLine("\nBonuses based on years of experience:");
            PrintBonuses(employees);
        }

        public static void SortEmployees(List<Employee> employees, Func<Employee, Employee, int> comparison)
        {
            employees.Sort(new Comparison<Employee>(comparison));
        }

        public static void CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator)
        {
            foreach (var employee in employees)
            {
                employee.Salary += bonusCalculator(employee); 
            }
        }

        public static void PrintEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Experience: {employee.YearsOfExperience}, Salary: {employee.Salary:C}");
            }
        }

        public static void PrintBonuses(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, New Salary (with bonus): {employee.Salary:C}");
            }
        }
    }
}
