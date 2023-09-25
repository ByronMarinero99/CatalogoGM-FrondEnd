using CatalogoGM.Models;

namespace CatalogoGM.Services
{
    public interface ICaracteristicasGameService
    {
        Task<IEnumerable<CaracteristicasGames>> GetAll();
    }
}
