using System.ComponentModel.DataAnnotations;

namespace Orders.Shared.Entities;

public class Country
{
    public int Id { get; set; }

    [Display(Name = "País")] // We establish the name of column with DataNotation
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1}" +
                                                     "carácteres.")] // Length of column value, nvarchar(100), and an ErrorMessage
    [Required(ErrorMessage = "El campo {0} es obligatorio.")] // It makes the column País mandatory.
    public string Name { get; set; } = null!; // It won't allow null values.
}