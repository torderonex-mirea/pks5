using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5praktika.Models.Entities

{
	public class Teacher
    {
        [Key]
		[Column("teacher_id")]
		public int TeacherID { get; set; }
		[Column("full_name")]
		public string FullName { get; set; }
    }
}
