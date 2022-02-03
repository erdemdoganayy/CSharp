using System.ComponentModel.DataAnnotations;

namespace BlazorAppCRUD.Data
{
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {
            Educations = new List<Education>();
        }
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Village { get; set; }


        public IList<Education> Educations { get; set; }
    }

}
