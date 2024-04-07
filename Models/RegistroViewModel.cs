using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Error.Requerido")]
        [EmailAddress(ErrorMessage = "Error.Email")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Error.Requerido")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public bool Recuerdame { get; set; }
    }
}
