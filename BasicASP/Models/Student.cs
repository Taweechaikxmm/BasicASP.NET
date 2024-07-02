using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASP.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="กรุณาป้อนชื่อนักเรียน")]
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }
        [DisplayName("คะแนนสอบ")]
        [Range(0,100,ErrorMessage ="กรุณาป้อนคะแนนในช่วง 0 ถึง 100")]
        public int Score { get; set; }
    }
}
