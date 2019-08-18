using AutoMapper;
using BrConselhosProva.Application.Features.Teachers;
using BrConselhosProva.Domain.Features.Teachers;
using BrConselhosProva.Infra.ORM.Context;
using BrConselhosProva.Infra.ORM.Features.Teachers;
using BrConselhosProva.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrConselhosProva.WebApp.Controllers
{
    public class TeacherController : Controller
    {

        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        // GET: Teacher
        [HttpGet]
        public ActionResult List()
        {
            var teachers = _teacherService.GetTeachers();
            var teacherViews = Mapper.Map<List<Teacher>, List<TeacherListViewModel>>(teachers);

            return View(teacherViews);
        }

        // GET: Teacher/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        public ActionResult Create(FormCollection formValues)
        {
            try
            {
                Teacher teacher = new Teacher()
                {
                    Name = formValues["Name"]
                };

                _teacherService.Save(teacher);

                return RedirectToAction("List");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Teacher Id
        [HttpGet]
        public ActionResult DeleteTeacher(Guid id)
        {
            try
            {
                _teacherService.Delete(id);

                return RedirectToAction("List");
            }
            catch
            {
                return new EmptyResult();
            }

        }

    }
}
