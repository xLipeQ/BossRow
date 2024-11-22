
namespace BossRow.Test
{
    public class DataSet
    {
        public DataSet() { }

        public List<Employee> TaskEmployees = new()
        {
            new Employee(1, "Jan Kowalski"),
            new Employee(2, "Kamil Nowak", 1),
            new Employee(3, "Anna Mariacka", 1),
            new Employee(4, "Andrzej Abacki", 2),
        };

        public List<Employee> NoSuperiorEmployees = new()
        {
            new Employee(1, "Jan Kowalski"),
            new Employee(2, "Kamil Nowak", 1),
            new Employee(3, "Anna Mariacka", 1),
            new Employee(4, "Andrzej Abacki", 5),
        };

        public List<Employee> TrainEmployees = new List<Employee>()
        {
            new Employee(1, "Jan Kowalski"),
            new Employee(2, "Kamil Nowak", 1),
            new Employee(3, "Anna Mariacka", 2),
            new Employee(4, "Andrzej Abacki", 3),
            new Employee(5, "Piąty", 4),
            new Employee(6, "Szósty", 5),
            new Employee(7, "Siódmy", 6)
        };

        public List<Employee> OnlySuperiors = new()
        {
            new Employee(1, ""),
            new Employee(2, ""),
            new Employee(3, ""),
            new Employee(4, "")
        };

    }
}
