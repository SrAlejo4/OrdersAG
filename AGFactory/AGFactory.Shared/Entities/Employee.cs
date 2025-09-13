using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGFactory.Shared.Entities;

public class Employee
{
    public int Id { get; set; }

    [Display(Name = "Primer nombre")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1}" + "carácteres.")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Segundo Nombre")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [MaxLength(30, ErrorMessage = "El campo {0} no puede tener más de {1}" + "carácteres.")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Activo")]
    public bool IsActive { get; set; }

    [Display(Name = "Fecha contratacion")]
    public DateTime HireDate { get; set; }

    [Display(Name = "Salario")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [Range(1000000, double.MaxValue, ErrorMessage = "El salario debe ser mínimo de $1.000.000.")]
    public decimal Salary { get; set; }
}