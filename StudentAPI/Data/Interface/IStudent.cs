using StudentAPI.Model;

namespace StudentAPI.Data.Interface
{
    public interface IStudent
    {
        Task<List<Student>> getall();
        Task<int> post(Student student);
        Task<int> delete(int Id);
        Task<int> put(int Id, UpdateStudent updatestudent);
    }
}
