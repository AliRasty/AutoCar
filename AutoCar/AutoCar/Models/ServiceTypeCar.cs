using System.ComponentModel.DataAnnotations;

namespace AutoCar.Models
{
    public class ServiceTypeCar
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(500)]
        public string Name { get; set; }
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public double Price { get; set; }
    }
}
