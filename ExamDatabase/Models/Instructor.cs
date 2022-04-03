namespace ExamDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            InstructorCourses = new HashSet<InstructorCourse>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Degree { get; set; }

        public int DeptId { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; }
    }
}
