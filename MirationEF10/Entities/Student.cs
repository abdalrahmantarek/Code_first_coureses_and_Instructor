using MirationEF10.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirationEF10.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? LName { get; set; }
        public string? FName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();

        public ICollection<SectionStudent> SectionStudents { get; set; } = new List<SectionStudent>();


    }
}
