using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDatabase.Models
{
    public class ExamQuestion
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public int Grade { get; set; }
    }
}
