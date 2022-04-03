namespace ExamDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QuestionBank")]
    public partial class QuestionBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionBank()
        {
            QuestionChoices = new HashSet<QuestionChoice>();
            StudentExams = new HashSet<StudentExam>();
            Exams = new HashSet<Exam>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(500)]
        public string Body { get; set; }

        public int Grade { get; set; }

        [Required]
        [StringLength(1)]
        public string ModelAnswer { get; set; }

        public int CourseId { get; set; }

        public virtual Course Cours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionChoice> QuestionChoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExam> StudentExams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
