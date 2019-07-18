using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Infrastructure.DataMapping
{
    public static class StudentDataMapping
    {
        public static Student ToEntity(this CreateStudent newStudent)
        {
            return new Student()
            {
                Name = newStudent.Name
                ,
                Grade = newStudent.Grade
                ,
                School = newStudent.School
            };
        }
        public static RegisteredStudent toDTO(this Student studentOnDb)
        {
            return new RegisteredStudent()
            {
                Id = studentOnDb.Id
                ,
                Name = studentOnDb.Name
                ,
                Grade = studentOnDb.Grade
                ,
                School = studentOnDb.School
            };
        }
        public static Student ToEntity(this UpdateStudent updateStudent)
        {
            return new Student()
            {
                Id = updateStudent.Id
                ,
                Name = updateStudent.Name
                ,
                Grade = updateStudent.Grade
                ,
                School = updateStudent.School
            };
        }
    }
}
