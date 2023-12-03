using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface ISedeService
    {
        Task<IEnumerable<Sede>> GetSedesAsync();
        Sede GetById(int id);
        bool AddSede(Sede sede);
        bool UpdateSedeo(Sede sede);
        bool DeleteSede(Sede sede);
    }
}
