using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    [Table("Employee")]
    public class Employee
    {
        public Int64 EmployeeId { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string City { set; get; }
        public Int64 DepartmentId { set; get; }

    }
}