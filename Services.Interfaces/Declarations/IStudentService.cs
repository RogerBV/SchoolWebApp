using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Declarations.Common;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Services.Interfaces.Declarations
{
    public interface IStudentService:
        ICRUDService<CreateStudent,UpdateStudent,RegisteredStudent>
    {
    }
}
