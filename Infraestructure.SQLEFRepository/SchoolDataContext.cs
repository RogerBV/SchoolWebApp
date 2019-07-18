using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;
namespace Infraestructure.SQLEFRepository
{
    public class SchoolDataContext : DbContext
    {
        private static readonly string DatabaseConnectionStringName = "SchoolDB";
        public DbSet<Student> Students { get; set; }

        public SchoolDataContext() : base(DatabaseConnectionStringName)
        {
        }
    }
}
