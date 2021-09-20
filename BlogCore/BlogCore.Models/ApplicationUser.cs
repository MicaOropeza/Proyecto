using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class ApplicationUser : IdentityUser 
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public string Dirección { get; set; }

        [Required(ErrorMessage = "La ciudad es obligartorio")]
        public string Ciudad { get; set; }


        [Required(ErrorMessage ="El pais es obligatorio")]
        public string Pais { get; set; }
    } 
}
