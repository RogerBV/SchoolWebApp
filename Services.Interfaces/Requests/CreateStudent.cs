using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class CreateStudent
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string School { get; set; }
    }
}
