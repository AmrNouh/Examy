namespace ExamDatabase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class QuestionChoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string choice { get; set; }

        public virtual QuestionBank QuestionBank { get; set; }
    }
}
