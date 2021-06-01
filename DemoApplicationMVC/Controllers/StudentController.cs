using DemoApplicationMVC.Models;
using DemoApplicationMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplicationMVC.Controllers
{
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public string StudentDetails(int id)
        //{
        //    return $"Student id {id}";
        //}
        private readonly StudentRepository studentRepository;
        public StudentController()
        {
            studentRepository = new StudentRepository();
        }
        public List<StudentModel>AllStudentDetails()
        {
            return studentRepository.GetAllStudents();
        }
        public StudentModel GetStudent(int id)
        {
            return studentRepository.GetStudentById(id);
        }
        public List<StudentModel>SearchStudents(string studentName,string studentBranch,string studentGender)
        {
            return studentRepository.SearchStudent(studentName, studentBranch, studentGender);
        }
    }
}
