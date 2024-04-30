using WebStarterDBApp1.Models;

namespace WebStarterDBApp1.DAO
{
    public interface IStudentDAO
    {
        Student? Insert(Student? student);
        Student? Update(Student? student);
        void Delete(int id);
        Student? GetByID(int id);
        List<Student> GetAll();
    }
}
