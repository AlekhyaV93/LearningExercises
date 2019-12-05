using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstMVCDemo.Models
{
    public class DepartmentContext : DbContext
    {
        //foriegn key relation to depatment table
        public DbSet<Department> Departments { get; set; }
    }
    
}