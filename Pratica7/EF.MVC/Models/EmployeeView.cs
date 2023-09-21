using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF.MVC.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo Nombre debe tener como máximo 10 caracteres.")]
        [RegularExpression(@"^[a-zA-Z]+(\s[a-zA-Z]+)*$", ErrorMessage = "Este campo solo permite letras.")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        [StringLength(20, ErrorMessage = "El campo Apellido debe tener como máximo 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z]+(\s[a-zA-Z]+)*$", ErrorMessage = "Este campo solo permite letras.")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Rol es obligatorio.")]
        [StringLength(30, ErrorMessage = "El campo Rol debe tener como máximo 30 caracteres.")]
        [RegularExpression(@"^[a-zA-Z]+(\s[a-zA-Z]+)*$", ErrorMessage = "Este campo solo permite letras.")]
        [Display(Name = "Rol")]
        public string Title { get; set; }
    }
}
    
