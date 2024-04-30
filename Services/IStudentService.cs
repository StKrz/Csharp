using WebStarterDBApp1.DTO;
using WebStarterDBApp1.Models;

namespace WebStarterDBApp1.Services
{
    public interface IStudentService
    {
        Student? InsertStudent(StudentInsertDTO dto);
        Student? UpdateStudent(StudentUpdateDTO dto);
        Student? DeleteStudent(int id);
        Student? GetStudent(int id);
        IList<Student> GetAllStudents();
    }
}
