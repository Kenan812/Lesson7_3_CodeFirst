using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7_3_CodeFirst.Models
{
    public class Mark
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int Grade { get; set; }

        public Student Student { get; set; }

    }
}
