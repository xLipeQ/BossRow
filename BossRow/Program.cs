namespace BossRow
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Jan Kowalski"),
                new Employee(2, "Kamil Nowak", 1),
                new Employee(3, "Anna Mariacka", 1),
                new Employee(4, "Andrzej Abacki", 2)
            };

            var func = new Funcitonalitites();
            func.FillEmployeesStructure(employees);

            Console.WriteLine("Tabela employeeStructure dla danych z zadania: ");
            Console.WriteLine($"{"EmployeeId",-12} {"SuperiorId",-12} {"Row",-5}");
            Console.WriteLine(new string('-', 34));
            foreach (var es in func.employeeStructures)
            {
                Console.WriteLine($"| {es.EmployeeId,-10} | {es.SuperiorId,-10} | {es.Row,-3} |");
            }

            Console.WriteLine();
            Console.WriteLine();

            List<Employee> trainEmployees = new List<Employee>()
            {
                new Employee(1, "Jan Kowalski"),
                new Employee(2, "Kamil Nowak", 1),
                new Employee(3, "Anna Mariacka", 2),
                new Employee(4, "Andrzej Abacki", 3),
                new Employee(5, "Piąty", 4),
                new Employee(6, "Szósty", 5),
                new Employee(7, "Siódmy", 6)
            };

            func.FillEmployeesStructure(trainEmployees);
            Console.WriteLine("Tabela employeeStructure dla ciągu 7 pracowników: ");
            Console.WriteLine($"{"EmployeeId",-12} {"SuperiorId",-12} {"Row",-5}");
            Console.WriteLine(new string('-', 34));
            foreach (var es in func.employeeStructures)
            {
                Console.WriteLine($"| {es.EmployeeId,-10} | {es.SuperiorId,-10} | {es.Row,-3} |");
            }
            Console.WriteLine();
            Console.WriteLine();


            List<Employee> treeEmployees = new List<Employee>()
            {
                new Employee(1, "Jan Kowalski"),
                new Employee(2, "Kamil Nowak", 1),
                new Employee(3, "Anna Mariacka", 2),
                new Employee(4, "Andrzej Abacki", 2),
                new Employee(5, "Piąty", 1),
                new Employee(6, "Szósty", 5),
                new Employee(7, "Siódmy", 5),
            };

            func.FillEmployeesStructure(treeEmployees);
            Console.WriteLine("Tabela employeeStructure dla wyważonego drzewa 7 pracowników: ");
            Console.WriteLine($"{"EmployeeId",-12} {"SuperiorId",-12} {"Row",-5}");
            Console.WriteLine(new string('-', 34));
            foreach (var es in func.employeeStructures)
            {
                Console.WriteLine($"| {es.EmployeeId,-10} | {es.SuperiorId,-10} | {es.Row,-3} |");
            }
        }
    }
}

