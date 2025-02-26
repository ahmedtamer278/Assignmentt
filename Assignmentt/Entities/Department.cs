using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime HirringDate { get; set; }

        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }
        public Instructor Manager { get; set; }
       public ICollection<Instructor> instructors { get; set; } = new List<Instructor>();

       public ICollection<Student> students { get; set; } = new List<Student>();

    }
}

