using AutoMapper;
using BrConselhosProva.Application.Features.Students;
using BrConselhosProva.Domain.Features.Students;
using BrConselhosProva.Domain.Features.Teachers;
using BrConselhosProva.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrConselhosProva.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;
        private ITeacherRepository _teacherRepository;

        public StudentController(IStudentService studentService, ITeacherRepository teacherRepository)
        {
            _studentService = studentService;
            _teacherRepository = teacherRepository;
        }


        // GET: Student
        public ActionResult List()
        {
            var students = _studentService.GetTeachers();
            var studentViews = Mapper.Map<List<Student>, List<StudentListViewModel>>(students);

            return View(studentViews);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            var dropDown = _teacherRepository.GetAll();

            ViewBag.Teachers = new SelectList(dropDown, "Id", "Name"); ;

            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection formValues)
        {
            try
            {
                Student student = new Student()
                {
                    Name = formValues["Name"],
                    Birthday = DateTime.Parse(formValues["Birthday"]),
                    TeacherId = new Guid(formValues["TeacherId"])
                };

                _studentService.Save(student);

                return RedirectToAction("List");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Student Id
        [HttpGet]
        public ActionResult DeleteStudent(Guid id)
        {
            try
            {
                _studentService.Delete(id);

                return RedirectToAction("List");
            }
            catch
            {
                return new EmptyResult();
            }

        }
    }
}
