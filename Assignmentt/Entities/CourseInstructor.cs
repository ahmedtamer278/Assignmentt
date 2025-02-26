using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignmentt.Entities
{
    [PrimaryKey(nameof(InstructorId), nameof(CourseId))]

    internal class CourseInstructor
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string Evaluate { get; set; }
    }
}
