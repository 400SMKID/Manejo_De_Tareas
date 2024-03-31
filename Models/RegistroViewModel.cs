using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido ")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electronico válido")]
        public String Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public bool Recuerdame { get; set; }
    }
}
