using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLeassons.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obligatorio")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Ingrese entre 4 y 50 caracteres")]
        public string FirstName { get; set; }
        [Display(Name = "Apellido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo obligatorio")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Ingrese entre 4 y 50 caracteres")]
        public string LastName { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]

        public DateTime BornDate { get; set; }
        [Display(Name = "Salario Anual")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Range(0, Int32.MaxValue, ErrorMessage = "El salario no puede ser negativo")]
        public decimal Salary { get; set; }

        public City City { get; set; }

    }
}
