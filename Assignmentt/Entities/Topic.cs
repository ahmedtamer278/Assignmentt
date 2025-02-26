using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt.Entities
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

       public ICollection<Course> courses { get; set; } = new List<Course>();

    }
}
