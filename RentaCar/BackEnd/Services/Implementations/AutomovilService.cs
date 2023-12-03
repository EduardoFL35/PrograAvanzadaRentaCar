using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class AutomovilService : IAutomovilService
    {
        public IUnidadDeTrabajo _unidadDeTrabajo;

        public AutomovilService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public bool AddAutomovile(Automovile automovile)
        {
            bool resultado = _unidadDeTrabajo._automovilDAL.Add(automovile);  
            _unidadDeTrabajo.Complete();
            return resultado;
        }

        public bool DeleteAutomovile(Automovile automovile)
        {
            bool resultado = _unidadDeTrabajo._automovilDAL.Remove(automovile); 
            _unidadDeTrabajo.Complete();
            return resultado;
        }

        public async Task<IEnumerable<Automovile>> GetAutomovilesAsync()
        {
            IEnumerable<Automovile> automoviles;
            automoviles = await _unidadDeTrabajo._automovilDAL.GetAll();
            return automoviles;
        }

        public Automovile GetById(int id)
        {
            Automovile automovil;
            automovil = _unidadDeTrabajo._automovilDAL.Get(id);
            return automovil;
        }

        public bool UpdateAutomovile(Automovile automovile)
        {
            bool resultado = _unidadDeTrabajo._automovilDAL.Update(automovile);
            _unidadDeTrabajo.Complete();
            return resultado;
        }
    }
}
