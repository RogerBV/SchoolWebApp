using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Responses
{
    public class RegisteredStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }
    }
}
