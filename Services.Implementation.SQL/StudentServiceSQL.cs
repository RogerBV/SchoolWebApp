using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Declarations;
using Services.Interfaces.Declarations.Common;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Infraestructure.SQLEFRepository;
using Infrastructure.DataMapping;
using Domain.Entities;
namespace Services.Implementation.SQL
{
    public class StudentServiceSQL : IStudentService
    {
        public RegisteredStudent Create(CreateStudent newRegistry)
        {
            using (SchoolDataContext schoolContext = new SchoolDataContext())
            {
                var newStudent = newRegistry.ToEntity();
                schoolContext.Students.Add(newStudent);
                schoolContext.SaveChanges();
                return newStudent.toDTO();
            }
        }

        public RegisteredStudent Delete(DeletedStudent deletedStudent)
        {
            using (SchoolDataContext schoolContext = new SchoolDataContext())
            {
                Student studentToDelete = (Student)schoolContext.Students.Where(b => b.Id == deletedStudent.Id).First();
                schoolContext.Entry(studentToDelete).State = System.Data.Entity.EntityState.Deleted;
                schoolContext.SaveChanges();
                return studentToDelete.toDTO();
            }
        }

        public List<RegisteredStudent> List()
        {
            using (SchoolDataContext schoolContext = new SchoolDataContext())
            {
                return schoolContext.Students.ToList().Select(x => x.toDTO()).ToList();
            }
        }

        public RegisteredStudent Update(UpdateStudent updateRegistry)
        {
            using (SchoolDataContext schoolContext = new SchoolDataContext())
            {
                var studentToUpdate = updateRegistry.ToEntity();
                schoolContext.Students.Attach(studentToUpdate);
                //schoolContext.Entry(studentToUpdate).Property(x => x.Name).IsModified = true;
                schoolContext.Entry(studentToUpdate).State = System.Data.Entity.EntityState.Modified;
                schoolContext.SaveChanges();
                return studentToUpdate.toDTO();
            }
        }

    }
}
