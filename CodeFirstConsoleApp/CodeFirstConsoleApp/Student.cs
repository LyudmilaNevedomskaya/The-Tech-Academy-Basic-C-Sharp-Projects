﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConsoleApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }

        //fully defined relationship
        public int? GradeId { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual StudentAddress Address { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
