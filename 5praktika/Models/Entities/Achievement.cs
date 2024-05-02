using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5praktika.Models.Entities

{
    public class Achievement
    {
        [Key]
		[Column("achievement_id")]
		public int AchievementID { get; set; }
		[Column("student_id")]
		public int StudentID { get; set; }
		[Column("achievement_date")]
		public DateTime AchievementDate { get; set; }
		[Column("achievement_type")]
		public string AchievementType { get; set; }
		[Column("description")]
		public string Description { get; set; }
    }
}
