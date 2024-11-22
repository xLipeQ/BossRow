namespace BossRow.Test
{
    public class EmployeeStructureTest
    {
        [Fact]
        public void FindRow_TaskData_Functionality()
        {
            // Arange
            var functionalities = new Funcitonalitites();
            var dataSet = new DataSet();

            // Act
            functionalities.FillEmployeesStructure(dataSet.TaskEmployees);
            var result21 = functionalities.GetSuperiorRowOfEmployee(2, 1); // row = 1
            var result41 = functionalities.GetSuperiorRowOfEmployee(4, 1); // row = 2
         
            // Assert
            Assert.Equal(1, result21);
            Assert.Equal(2, result41);
        }

        [Fact]
        public void FindRow_TaskData_NullResults()
        {
            // Arange
            var functionalities = new Funcitonalitites();
            var dataSet = new DataSet();

            // Act
            functionalities.FillEmployeesStructure(dataSet.TaskEmployees);
            var result = functionalities.GetSuperiorRowOfEmployee(4, 3); // row = null

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void FindRow_TrainData_Functionality()
        {
            // Arange
            var functionalities = new Funcitonalitites();
            var dataSet = new DataSet();

            // Act
            functionalities.FillEmployeesStructure(dataSet.TrainEmployees);

            // Assert
            var result71 = functionalities.GetSuperiorRowOfEmployee(7, 1); 
            var result63 = functionalities.GetSuperiorRowOfEmployee(6, 3); 
            var result51 = functionalities.GetSuperiorRowOfEmployee(5, 1); 
            var result76 = functionalities.GetSuperiorRowOfEmployee(7, 6); 
            var result12 = functionalities.GetSuperiorRowOfEmployee(1, 2);
            var result43 = functionalities.GetSuperiorRowOfEmployee(4, 3);

            Assert.Equal(6, result71);
            Assert.Equal(3, result63);
            Assert.Equal(4, result51);
            Assert.Equal(1, result76);
            Assert.Null(result12);
            Assert.Equal(1, result43);
        }

        [Fact]
        public void CreateTable_NoSuperior_ThrowArgumentExeption()
        {
            // Arange
            var functionalities = new Funcitonalitites();
            var dataSet = new DataSet();

            // Act + Arrange
            Assert.Throws<ArgumentException>(() => functionalities.FillEmployeesStructure(dataSet.NoSuperiorEmployees));
        }

        [Fact]
        public void CreateTable_OnlySuperior_EmptyTable()
        {
            // Arange
            var functionalities = new Funcitonalitites();
            var dataSet = new DataSet();

            // Act
            functionalities.FillEmployeesStructure(dataSet.OnlySuperiors);

            // Arrange
            Assert.Empty(functionalities.employeeStructures);
        }
    }
}