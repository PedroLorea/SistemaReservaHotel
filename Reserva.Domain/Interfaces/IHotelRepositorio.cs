using Reserva.Domain.Entidades;

namespace Reserva.Domain.Interfaces {

    public interface IHotelRepositorio
    {
        Task<IEnumerable<Hotel>> getHoteis();
        Task<Hotel?> GetById(int? id);
        Task<Hotel> Remove(Hotel hotel);
        Task<Hotel> Update(Hotel hotel);
        Task<Hotel> Create(Hotel hotel);
    }
}