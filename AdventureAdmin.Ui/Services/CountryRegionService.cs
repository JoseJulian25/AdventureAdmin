using AdventureAdmin.Data.Context;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdventureAdmin.Ui.Services;

public class CountryRegionService (AdventureWorksContext context) : IService<Data.Models.CountryRegion, int>
{
    public Task<Data.Models.CountryRegion?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.CountryRegion>> GetList(Expression<Func<Data.Models.CountryRegion, bool>> criterio)
    {
        return await context.CountryRegions
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Data.Models.CountryRegion entidad)
    {
        context.CountryRegions.Add(entidad);
        var cantidad = await context.SaveChangesAsync();
        return cantidad > 0;
    }
}