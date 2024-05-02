using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5praktika.Models.Entities

{
	public class Student
    {
        [Key]
        [Column("student_id")]
        public int StudentID { get; set; }
		[Column("username")]
		public string Username { get; set; }
		[Column("password")]
		public string Password { get; set; }
		[Column("first_name")]
		public string FirstName { get; set; }
		[Column("last_name")]
		public string LastName { get; set; }
    }

}
