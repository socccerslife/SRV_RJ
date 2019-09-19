using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Model
{
    public interface IStudentRepository
    {
        Student GetStudentById(int studentId);
        bool InsertStudent(Student student);
        bool DeleteStudent(int studentId);
        bool UpdateStudent(Student student);
    }
}
