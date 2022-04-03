namespace ExamDatabase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StudentCourses")]
    public partial class StudentCourse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sudent_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int course_Id { get; set; }

        public decimal? Grade { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        public virtual Course Cours { get; set; }

        public virtual Student Student { get; set; }
    }
}
