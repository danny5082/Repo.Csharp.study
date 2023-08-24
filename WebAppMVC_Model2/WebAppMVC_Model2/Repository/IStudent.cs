using WebAppMVC_Model2.Models;

namespace WebAppMVC_Model2.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);

    }
}
