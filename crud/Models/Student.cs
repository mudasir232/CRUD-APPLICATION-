using System;
using System.Collections.Generic;

namespace crud.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? FatherName { get; set; }
    }
}
