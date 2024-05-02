using _5praktika.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5praktika.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public DbSet<Achievement> Achievements { get; set; }
    public DbSet<StudentGrade> StudentGrades { get; set; }
	public DbSet<Student> Students { get; set; }
    public DbSet<TeacherDiscipline> TeacherDisciplines { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Achievement>().ToTable("achievements");
		modelBuilder.Entity<StudentGrade>().ToTable("student_grades");
		modelBuilder.Entity<Student>().ToTable("students");
		modelBuilder.Entity<TeacherDiscipline>().ToTable("teacher_disciplines");
		modelBuilder.Entity<Teacher>().ToTable("teachers");
	}
}
