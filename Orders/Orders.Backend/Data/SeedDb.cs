using Orders.Shared.Entities;

namespace Orders.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context) // We make an injection from DataContext to SeedDb
    {
        _context = context;
    }

    // This method create the DataBase in case it doesn't exist
    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync(); // This line create the DataBase
        await CheckCountriesAsync();
        await CheckCategoriesAsync();
    }

    private async Task CheckCategoriesAsync()
    {
        // The method Any allows me to identify if there are categories in DataBase.
        if (!_context.Categories.Any()) // a No at the beginning.
        {
            _context.Categories.Add(new Category { Name = "Calzado" });
            _context.Categories.Add(new Category { Name = "Tecnología" });
            await _context.SaveChangesAsync(); // Save the new rows
        }
    }

    private async Task CheckCountriesAsync()
    {
        if (!_context.Countries.Any())
        {
            _context.Countries.Add(new Country { Name = "Colombia" });
            _context.Countries.Add(new Country { Name = "Bolivia" });
            await _context.SaveChangesAsync(); // Save the new rows
        }
    }
}