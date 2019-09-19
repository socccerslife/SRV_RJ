using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Model
{
    public class StudentRepository : IStudentRepository
    {
        string path;
        SQLiteConnection conn;
        public StudentRepository(string dbName)
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalCacheFolder.Path, dbName);
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);

            conn.CreateTable<Student>();
        } 

        public Student GetStudentById(int studentId)
        {
            var student = conn.Table<Student>().ToList();
            return student.First(p => p.StudentId == studentId);
        }
        public bool InsertStudent(Student student)
        {
            if (conn.Insert(student) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool UpdateStudent(Student student)
        {
            if (conn.Update(student) >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            Student s = GetStudentById(studentId);
            if (conn.Delete(s) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
