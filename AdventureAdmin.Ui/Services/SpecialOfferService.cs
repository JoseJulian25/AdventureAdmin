using AdventureAdmin.Data.Context;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdventureAdmin.Ui.Services;

public class SpecialOfferService (AdventureWorksContext context) : IService<Data.Models.SpecialOffer, int>
{
    public Task<Data.Models.SpecialOffer?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.SpecialOffer>> GetList(Expression<Func<Data.Models.SpecialOffer, bool>> criterio)
    {
        return await context.SpecialOffers
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Data.Models.SpecialOffer entidad)
    {
        context.SpecialOffers.Add(entidad);
        var cantidad = await context.SaveChangesAsync();
        return cantidad > 0;
    }
}