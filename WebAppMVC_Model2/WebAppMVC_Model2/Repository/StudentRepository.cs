using WebAppMVC_Model2.Models;

namespace WebAppMVC_Model2.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {

            return new List<StudentModel>
            {
                new StudentModel { Id = 1, Name = "홍길동", HP = "010-1111-1111", Major = "컴퓨터공학"},
                new StudentModel { Id = 2, Name = "이순신", HP = "010-2222-2222", Major = "정보통신공학"},
                new StudentModel { Id = 3, Name = "강감찬", HP = "010-3333-3333", Major = "기계설계"},
            };
        }

    }
}
