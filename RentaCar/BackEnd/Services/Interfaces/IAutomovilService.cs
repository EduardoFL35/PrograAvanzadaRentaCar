using Entities.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IAutomovilService
    {
        Task<IEnumerable<Automovile>> GetAutomovilesAsync();
        Automovile GetById(int id);
        bool AddAutomovile(Automovile automovile);
        bool UpdateAutomovile(Automovile automovile);
        bool DeleteAutomovile(Automovile automovile);
    }
}
