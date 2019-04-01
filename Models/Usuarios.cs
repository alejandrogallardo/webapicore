using System;
using System.ComponentModel.DataAnnotations;

namespace contactos.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        [Display(Name="Username")]
        [StringLength(20, ErrorMessage = "El numero para {0} debe contener al menos {2} y maximo {1} de caracteres", MinimumLength=6)]
        public string username {get; set;}
        
        [Required]
        [StringLength(100, ErrorMessage = "El numero para {0} debe contener al menos {2} y maximo {1} de caracteres", MinimumLength=6)]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string password {get; set;}
        public string email {get; set;}

        [DataType(DataType.Date)]
        public DateTime fechaCreado {get; set;}
    }
}