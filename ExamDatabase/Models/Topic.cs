namespace ExamDatabase.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Topic
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int courseId { get; set; }

        public virtual Course Cours { get; set; }
    }
}
