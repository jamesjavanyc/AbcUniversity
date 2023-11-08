using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class CourseAssignment
    {
        /* Keys */
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        /* Navigation */
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
