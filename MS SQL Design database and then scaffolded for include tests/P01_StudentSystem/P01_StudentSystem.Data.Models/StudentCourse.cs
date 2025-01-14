﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public int CourseId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
