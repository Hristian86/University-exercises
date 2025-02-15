﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public string ContentType { get; set; }

        [Required]
        public DateTime SubmissionTime { get; set; }

        [Required]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }


    }
}
