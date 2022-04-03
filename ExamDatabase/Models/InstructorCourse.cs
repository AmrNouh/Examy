namespace ExamDatabase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("InstructorCourses")]
    public partial class InstructorCourse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InstructorId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [StringLength(50)]
        public string Evaluation { get; set; }

        public virtual Course Cours { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
