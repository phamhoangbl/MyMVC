using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    [Table("Department")]
    public class Department
    {
        public Int64 DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } 
    }
}