using AdventureAdmin.Data.Context;
using Aplicada1.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdventureAdmin.Ui.Services;

public class ShiftService (AdventureWorksContext context) : IService<Data.Models.Shift, int>
{
    public Task<Data.Models.Shift?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Data.Models.Shift>> GetList(Expression<Func<Data.Models.Shift, bool>> criterio)
    {
        return await context.Shifts
            .Where(criterio)
            .ToListAsync();
    }

    public async Task<bool> Guardar(Data.Models.Shift entidad)
    {
        context.Shifts.Add(entidad);
        var cantidad = await context.SaveChangesAsync();
        return cantidad > 0;
    }
}