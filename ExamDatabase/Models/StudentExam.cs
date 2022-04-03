namespace ExamDatabase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class StudentExam
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExamNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        [StringLength(1)]
        public string StudentAnswer { get; set; }

        public int SQuestionGrade { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }

        public virtual Student Student { get; set; }
    }
}
