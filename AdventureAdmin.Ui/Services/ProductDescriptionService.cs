using AdventureAdmin.Data.Context;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdventureAdmin.Ui.Services;

public class ProductDescriptionService (AdventureWorksContext context) : IService<Data.Models.ProductDescription, int>
{
    public Task<Data.Models.ProductDescription?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.ProductDescription>> GetList(Expression<Func<Data.Models.ProductDescription, bool>> criterio)
    {
        return await context.ProductDescriptions
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Data.Models.ProductDescription entidad)
    {
        context.ProductDescriptions.Add(entidad);
        var cantidad = await context.SaveChangesAsync();
        return cantidad > 0;
    }
}