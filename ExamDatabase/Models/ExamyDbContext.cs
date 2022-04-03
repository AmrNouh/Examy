using System.Data.Entity;

namespace ExamDatabase.Models
{
    public partial class ExamyDbContext : DbContext
    {
        public ExamyDbContext()
            : base("name=ExamyDbContext")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<InstructorCourse> InstructorCourses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<QuestionBank> QuestionBanks { get; set; }
        public virtual DbSet<QuestionChoice> QuestionChoices { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<StudentExam> StudentExams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.TotalGrade)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.InstructorCourses)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.QuestionBanks)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.course_Id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Topics)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.courseId);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Exams)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("CourseExams").MapLeftKey("CourseId").MapRightKey("ExamNumber"));

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Instructors)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => e.DeptId);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DeptId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.QuestionBanks)
                .WithMany(e => e.Exams)
                .Map(m => m.ToTable("ExamQuestions").MapLeftKey("ExamNumber").MapRightKey("QuestionId"));

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Salary)
                .HasPrecision(8, 2);

            modelBuilder.Entity<QuestionBank>()
                .Property(e => e.ModelAnswer)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QuestionBank>()
                .HasMany(e => e.QuestionChoices)
                .WithRequired(e => e.QuestionBank)
                .HasForeignKey(e => e.QuestionId);

            modelBuilder.Entity<QuestionBank>()
                .HasMany(e => e.StudentExams)
                .WithRequired(e => e.QuestionBank)
                .HasForeignKey(e => e.QuestionId);

            modelBuilder.Entity<StudentCourse>()
                .Property(e => e.Grade)
                .HasPrecision(6, 2);

            modelBuilder.Entity<StudentExam>()
                .Property(e => e.StudentAnswer)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.sudent_Id);
        }
    }
}
