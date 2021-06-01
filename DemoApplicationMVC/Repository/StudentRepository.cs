using DemoApplicationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplicationMVC.Repository
{
    public class StudentRepository
    {
        public List<StudentModel>GetAllStudents()
        {
            return DataSource();
        }

        public StudentModel GetStudentById(int studentId)
        {
            return DataSource().Where(x => x.StudentId == studentId).FirstOrDefault();
        }

        public List<StudentModel>SearchStudent(string studentName,string studentBranch,string studentGender)
        {
            return DataSource().Where(x => x.StudentName == studentName || x.StudentBranch == studentBranch || x.StudentGender==studentGender).ToList();
        }
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>()
            {
                new StudentModel(){StudentId=1,StudentName="Hari",StudentBranch="CSE",StudentGender="F"},
                new StudentModel(){StudentId=2,StudentName="Priya",StudentBranch="ECE",StudentGender="F"},
                new StudentModel(){StudentId=3,StudentName="Latha",StudentBranch="CSE",StudentGender="F"},
                new StudentModel(){StudentId=4,StudentName="Sai",StudentBranch="ECE",StudentGender="M"},
                new StudentModel(){StudentId=5,StudentName="Janu",StudentBranch="EEE",StudentGender="M"}
            };
        }

    }
}
