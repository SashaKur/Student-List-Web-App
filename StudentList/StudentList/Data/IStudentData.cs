using StudentList.Models;

namespace StudentList.Data
{
    public interface IStudentData
    {
        Student FindStudent(int ID);
        void DeleteStudent(int ID);
    }
}
