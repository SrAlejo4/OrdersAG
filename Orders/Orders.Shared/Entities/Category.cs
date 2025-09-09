using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities;

public class Category
{
    public int Id { get; set; }

    [Display(Name = "Categoría")] // We establish the name of column with DataNotation
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1}" +
                                                     "carácteres.")] // Length of column value, nvarchar(100), and an ErrorMessage
    [Required(ErrorMessage = "El campo {0} es obligatorio.")] // It makes the column Categoria mandatory.
    public string Name { get; set; } = null!; // It won't allow null values.
}