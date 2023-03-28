using Microsoft.EntityFrameworkCore;
using StudentAPI.Data.Interface;
using StudentAPI.Model;

namespace StudentAPI.Data.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly StudentAPIDbContext _context;
        public StudentRepository(StudentAPIDbContext _context)
        {
            this._context = _context;
        }

        public async Task<int> delete(int Id)
        {
            _context.Database.ExecuteSql($"DeleteStudent @Id ={Id}");
            return Id;
        }

        public async Task<List<Student>> getall()
        {
            var result = await _context.StudentDetails.ToListAsync();
            return result;
        }

        public async Task<int> post(Student student)
        {
            _context.Database.ExecuteSql($"Insertstudent @Name = {student.Name}, @Age ={student.Age}, @Marks={student.Marks}");
            return student.Id;
        }

        public async Task<int> put(int Id, UpdateStudent updatestudent)
        {
           _context.Database.ExecuteSql($"UpdateStudent @Id = {Id},@Name = {updatestudent.Name}, @Age ={updatestudent.Age}, @Marks={updatestudent.Marks}");

            return Id;
        }
    }
}
