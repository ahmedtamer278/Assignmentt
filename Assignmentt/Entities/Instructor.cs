using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Adress { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public decimal HourRate { get; set; }

        public Department ManagerDepartment { get; set; }

        [ForeignKey (nameof (WorkDepartment))]
        public int DepartmentId { get; set; }
        public Department WorkDepartment { get; set; }

       public ICollection<CourseInstructor> Instructorscourse {  get; set; } = new List<CourseInstructor>();


    }
}
