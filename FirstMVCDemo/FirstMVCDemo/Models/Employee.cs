using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCDemo.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int employeeID { get; set; }
        public int departmentID { get; set; }
        public string employeeName { get; set; }
        public string gender { get; set; }
        public string city { get; set; }

    }
}