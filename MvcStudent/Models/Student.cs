using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(300)]
        [Display(Name = "姓名")]

        public string? Name { get; set; }
        [StringLength(1)]
        [Display(Name = "性别")]

        public string? Sex { get; set; }
        [Display(Name = "年龄")]
        [Range(1, 200)]
        public int Age { get; set; }
        [Display(Name = "出生日期")]
        public DateTime Brith { get; set; }
        [Display(Name = "手机")]
        [StringLength(13)]
        public string? Phone { get; set; }
        [Display(Name = "体温")]
        [Range(30, 50)]
        public decimal TemperaTure { get; set; }
        [Display(Name = "填表日期")]
        public DateTime InputTime { get; set; }
    }
}
