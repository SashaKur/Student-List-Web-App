using StudentList.Models;

namespace StudentList.Data
{
    public class StudentData : IStudentData
    {
        public Student FindStudent(int ID) => Students.Find(student => student.ID == ID);


        public void DeleteStudent(int ID)
        {
            var student = FindStudent(ID);

            if (student != null)
                Students.Remove(student);
        }

        public static List<Student> Students = new List<Student>()
        {
            new Student
            {
                ID = 1,
                Avatar = "https://www.shareicon.net/data/512x512/2016/01/12/702227_users_512x512.png",
                FirstName = "William",
                LastName = "Martinez",
                BirthDate = DateTime.Now.AddYears(-24),
                Studies = "Logistics"
            },

            new Student
            {
                ID = 2,
                Avatar = "https://www.shareicon.net/data/512x512/2016/07/03/790265_people_512x512.png",
                FirstName = "John",
                LastName = "Smith",
                BirthDate = DateTime.Now.AddYears(-20),
                Studies = "Computer Science"
            },



            new Student
            {
                ID = 3,
                Avatar = "https://www.shareicon.net/data/512x512/2016/09/02/823818_user_512x512.png",
                FirstName = "David",
                LastName = "Smith",
                BirthDate = DateTime.Now.AddYears(-21),
                Studies = "Physics"
            },

            new Student
            {
                ID = 4,
                Avatar = "https://www.shareicon.net/data/512x512/2015/11/17/673462_woman_512x512.png",
                FirstName = "Maria",
                LastName = "Garcia",
                BirthDate = DateTime.Now.AddYears(-28),
                Studies = "Web Design"
            },
        };



    }
}
