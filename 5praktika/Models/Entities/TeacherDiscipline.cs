using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5praktika.Models.Entities

{
	public class TeacherDiscipline
    {
        [Key]
		[Column("discipline_id")]
		public int DisciplineID { get; set; }
		[Column("teacher_id")]
		public int TeacherID { get; set; }
		[Column("discipline_name")]
		public string DisciplineName { get; set; }
		[Column("department")]
		public string Department { get; set; }
    }
}
