namespace ExamDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            StudentExams = new HashSet<StudentExam>();
            Courses = new HashSet<Course>();
            QuestionBanks = new HashSet<QuestionBank>();
        }

        [Key]
        public int Number { get; set; }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }

        public int NumberOfTrueFalse { get; set; }

        public int NumberOfMCQ { get; set; }

        public int InstructorId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExam> StudentExams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionBank> QuestionBanks { get; set; }
    }
}
