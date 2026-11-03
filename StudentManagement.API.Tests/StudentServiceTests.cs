using StudentManagement.API.Services;

namespace StudentManagement.API.Tests
{
    public class StudentServiceTests
    {
        [Fact]
        public void GetAll_ShouldReturnSeededStudents()
        {
            // Arrange
            var service = new StudentService();

            // Act
            var students = service.GetAll();

            // Assert
            Assert.NotNull(students);
            Assert.NotEmpty(students);
            Assert.True(students.Count >= 2);
        }
    }
}