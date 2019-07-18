using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Services.Implementation.SQL;
using System.Web.Http;
namespace SchoolWebApp.Controllers.API
{
    public class StudentController : ApiController
    {
        private IStudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentServiceSQL();
        }
        [HttpPost]
        public RegisteredStudent Create(CreateStudent newStudent)
        {
            return this._studentService.Create(newStudent);
        }
        [HttpPut]
        public RegisteredStudent Update(UpdateStudent reg)
        {
            return this._studentService.Update(reg);
        }
        [HttpGet]
        public List<RegisteredStudent> List()
        {
            var list = this._studentService.List();
            foreach (var item in list)
            {
                item.StudentId = item.Id;
            }
            return list;
        }
        // GET: Student
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}