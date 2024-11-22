
namespace BossRow
{
    /// <summary>
    /// Przykładowa klasa, która pozwoli przechowywać relację oraz rząd relacji pomiędzy pracownikami
    /// </summary>
    public class EmployeeStructure
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int SuperiorId { get; set; }
        public virtual Employee Superior { get; set; }
        public int Row { get; set; } = 0;

        public EmployeeStructure(int emplId, int SupId, int row, Employee employee, Employee superior) 
        {
            EmployeeId = emplId;
            SuperiorId = SupId;
            Row = row;
            Employee = employee;
            Superior = superior;
        }
    }
}
