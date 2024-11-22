using System;
using System.Threading.Channels;

namespace BossRow
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Task();
            Train();
            Tree();
            NotOrderedEmployees();
        }

        static void Task()
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

            foreach (var e in employees)
                Console.WriteLine(e);

            Display(func);
        }

        static void Train()
        {
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
            foreach (var e in trainEmployees)
                Console.WriteLine(e);

            var func = new Funcitonalitites();
            func.FillEmployeesStructure(trainEmployees);

            Display(func);
        }

        static void Tree()
        {
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
            foreach (var e in treeEmployees)
                Console.WriteLine(e);

            var func = new Funcitonalitites();
            func.FillEmployeesStructure(treeEmployees);

            Display(func);
        }

        static void NotOrderedEmployees()
        {
            List<Employee> NotOrderedEmployees = new List<Employee>()
            {
                new Employee(5, "Jan Kowalski", 3),
                new Employee(6, "Kamil Nowak", 3),
                new Employee(2, "Anna Mariacka", 5),
                new Employee(1, "Andrzej Abacki", 6),
                new Employee(3, "ssss", 4),
                new Employee(7, "ffff", 4),
                new Employee(4, "aaaa")
            };
            foreach (var e in NotOrderedEmployees)
                Console.WriteLine(e);

            var func = new Funcitonalitites();
            func.FillEmployeesStructure(NotOrderedEmployees);
            Display(func);
        }

        static void Display(Funcitonalitites func)
        {
            Console.WriteLine("Tabela employeeStructure dla powyższych pracowników: ");
            Console.WriteLine($"{"EmployeeId",-12} {"SuperiorId",-12} {"Row",-5}");
            Console.WriteLine(new string('-', 34));
            foreach (var es in func.employeeStructures)
            {
                Console.WriteLine($"| {es.EmployeeId,-10} | {es.SuperiorId,-10} | {es.Row,-3} |");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

