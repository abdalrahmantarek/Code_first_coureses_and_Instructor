﻿using MirationEF10.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirationEF10.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }

        ///forign key 
        public int CourseId { get; set; }
        public Course Course { get; set; }

        ///forign key 
        public int? InstructorId { get; set; }

        public Instructor? Instructor { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();

        public ICollection<SectionStudent> SectionStudents { get; set; } = new List<SectionStudent>();

    }
}