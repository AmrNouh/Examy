using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.Models
{
    public class AvailableExams
    {
        public int ExamNumber { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public string InstructorName { get; set; }

    }
}
