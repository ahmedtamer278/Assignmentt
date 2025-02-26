using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? Duration { get; set; }

        [ForeignKey(nameof(Topic))]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        public ICollection<StudentCourse> StudenCourses { get; set; }= new List<StudentCourse>();
        public ICollection<CourseInstructor> instructorCourses { get; set; }= new List<CourseInstructor>();
    }
}
