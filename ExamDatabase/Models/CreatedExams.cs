using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.Models
{
    public class CreatedExams
    {
        public int Number { get; set; }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }

        public int NumberOfTrueFalse { get; set; }

        public int NumberOfMCQ { get; set; }
    }
}
