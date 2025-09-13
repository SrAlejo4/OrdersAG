using Orders.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities;

public class State : IEntityWithName
{
    public int Id { get; set; }

    [Display(Name = "Estado")] // We establish the name of column with DataNotation
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1}" +
                                                     "carácteres.")] // Length of column value, nvarchar(100), and an ErrorMessage
    [Required(ErrorMessage = "El campo {0} es obligatorio.")] // It makes the column Estado mandatory.
    public string Name { get; set; } = null!; // It won't allow null values.

    // Make a relation between State and Country (One-to-many) in DataBase
    public int CountryId { get; set; }

    public Country? Country { get; set; }

    // Create a collection of Cities in State entity, it can be null in case of zero cities.
    public ICollection<City>? Cities { get; set; }

    public int CitiesNumber => Cities == null ? 0 : Cities.Count;
}