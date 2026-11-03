using StudentManagement.API.Models;

namespace StudentManagement.API.Services
{
    public class StudentService : IStudentService
    {
        private static readonly List<Student> Students = new()
        {
            new Student { Id = 1, Name = "Anil", Email = "anil@example.com", Course = "ASP.NET Core" },

            new Student { Id = 2, Name = "Rina", Email = "rina@example.com", Course = "C#" }
        };

        public List<Student> GetAll()
        {
            return Students;
        }

        public Student? GetById(int id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        public Student Add(Student student)
        {
            student.Id = Students.Max(x => x.Id) + 1;
            Students.Add(student);
            return student;
        }
    }
}