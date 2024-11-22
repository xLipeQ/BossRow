
namespace BossRow
{
    public class Employee
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public int? SuperiorId { get; set; } = null;
        public virtual Employee? Superior { get; set; } = null;

        public Employee(int id, string name, int? supId = null) 
        {
            Id = id;
            Name = name;
            SuperiorId = supId;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {SuperiorId}";
        }

    }
}
