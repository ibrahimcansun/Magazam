using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MagazamMVC.Models.Concrete
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DepartmenName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}