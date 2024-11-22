
namespace BossRow
{
    /// <summary>
    /// Posiada wymagane funkcje
    /// </summary>
    public class Funcitonalitites
    {
        /// <summary>
        /// Tabela EmployeeStructures - zakładam, 
        /// że kolumny employeeId oraz superiorId mają index (klastrowy) w bazie
        /// dzięki temu znalezienie rekordu jest w czasie Log(n)
        /// </summary>
        public List<EmployeeStructure> employeeStructures = new();

        public Funcitonalitites() { }

        /// <summary>
        /// Wypełnia "tabelę" EmployeeStructures. Każdy z obiektów reprezentuje wiersz w tabeli
        /// </summary>
        /// <param name="employees">"Tabela pracowników" - założenia:
        /// <para>
        /// 1. Jest poprawna pod kątem bazy danych (id są unikalne)
        /// </para>
        /// 2. Graf przełożonych jest drzewem (nie ma cykli)
        /// </param>
        public void FillEmployeesStructure(List<Employee> employees)
        {
            employeeStructures.Clear();
            
            // utworzymy listę posortowaną po Id
            SortedList<int, Employee> sortedEmployees = new(employees.Count);
            foreach(var e in employees)
                sortedEmployees.Add(e.Id, e);

            foreach(var e in sortedEmployees)
            {
                var currentSupId = e.Value.SuperiorId;
                var row = 0;
                while(currentSupId != null)
                {
                    if (!sortedEmployees.TryGetValue(currentSupId.Value, out var superior))
                        throw new ArgumentException($"There is no such superior with id: {currentSupId}");
                    
                    row++;
                    employeeStructures.Add(new EmployeeStructure(e.Value.Id, currentSupId.Value, row, e.Value, superior));
                    currentSupId = superior.SuperiorId;
                }
            }
        }
        
        /// <summary>
        /// Zwraca rząd przełożonego w <see cref="employeeStructures"/>
        /// </summary>
        /// <param name="employeeId">Identifikator pracownika</param>
        /// <param name="superiorId">Identifikator potencjalengo przełożonego</param>
        /// <returns>rząd przełożonego lub null gdy superior nie jest przełożonym</returns>
        public int? GetSuperiorRowOfEmployee(int employeeId, int superiorId)
        {
            return employeeStructures.Where(es => es.EmployeeId == employeeId && es.SuperiorId == superiorId).FirstOrDefault()?.Row;
        }

    }
}
