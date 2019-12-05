using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCDemo.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}