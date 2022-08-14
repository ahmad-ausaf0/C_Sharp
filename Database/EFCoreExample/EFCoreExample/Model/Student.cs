using System;
using System.Collections.Generic;

namespace EFCoreExample.Model
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public int? CourseId { get; set; }
    }
}
