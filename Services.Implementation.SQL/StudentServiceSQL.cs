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

        public void Delete(int Id)
        {
            throw new NotImplementedException();
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
                schoolContext.Entry(studentToUpdate).Property(x => x.Name).IsModified = true;
                return studentToUpdate.toDTO();
            }
        }
    }
}
