using WebApplication1.Students;
namespace WebApplication1.ServiceLayer
{
    public class StudentDataService
    {
        List<Student> students = new List<Student> {
            new Student { Name = "Jon", Id = 2, CourseName = "Maths" },
            new Student { Name = "Doe", Id = 3, CourseName = "Science" }
            };


        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetById(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        public Student CreateStudent(Student createStudent)
        {
            if (!students.Contains(createStudent))
            {
                createStudent.Id = students.Count + 1;
                students.Add(createStudent);
            }
            return createStudent;
        }

        public Student UpdateStudent(int id, Student updatedStudent)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    student.Name = updatedStudent.Name;
                    student.Id = updatedStudent.Id;
                    student.CourseName = updatedStudent.CourseName;
                }
            }

            return null;
        }

        public bool DeleteStudent(int id)
        {
            var deleteStudent=students.FirstOrDefault(s=>s.Id == id);

            if(deleteStudent != null)
            {
                students.Remove(deleteStudent);
                return true;
            }
            return false;
        }
    }
}
