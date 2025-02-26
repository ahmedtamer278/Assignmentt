using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string? Adress { get; set; }
        public int Age { get; set; }

        public int DpartmentId { get; set; }
        public Department Department { get; set; }

      public  ICollection<StudentCourse> StudentsCourse { get; set; } = new List<StudentCourse>();
    }
}
