using AdventureAdmin.Data.Context;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdventureAdmin.Ui.Services;

public class ContactTypeService (AdventureWorksContext context) : IService<Data.Models.ContactType, int>
{
    public Task<Data.Models.ContactType?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.ContactType>> GetList(Expression<Func<Data.Models.ContactType, bool>> criterio)
    {
        return await context.ContactTypes
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Data.Models.ContactType entidad)
    {
        context.ContactTypes.Add(entidad);
        var cantidad = await context.SaveChangesAsync();
        return cantidad > 0;
    }
}