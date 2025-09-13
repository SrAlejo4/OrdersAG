using Orders.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities;

public class City : IEntityWithName
{
    public int Id { get; set; }

    [Display(Name = "Ciudad")] // We establish the name of column with DataNotation
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1}" +
                                                     "carácteres.")] // Length of column value, nvarchar(100), and an ErrorMessage
    [Required(ErrorMessage = "El campo {0} es obligatorio.")] // It makes the column Ciudad mandatory.
    public string Name { get; set; } = null!; // It won't allow null values.

    // Make a relation between City and State (One-to-many) in DataBase
    public int StateId { get; set; }

    public State? State { get; set; }
}