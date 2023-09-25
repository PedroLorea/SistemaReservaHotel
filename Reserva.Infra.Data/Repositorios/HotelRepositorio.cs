using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Entidades;
using Reserva.Domain.Interfaces;

namespace Reserva.Infra.Data.Context {

    public class HotelRepositorio : IHotelRepositorio {

        ApplicationDbContext _hotelContext;

        public HotelRepositorio(ApplicationDbContext context) {
            _hotelContext = context;
        }

        public async Task<Hotel> Create(Hotel hotel)
        {
            _hotelContext.Add(hotel);
            await _hotelContext.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel?> GetById(int? id)
        {
            return await _hotelContext.Hoteis.FindAsync(id);
        }

        public async Task<IEnumerable<Hotel>> getHoteis()
        {
            return await _hotelContext.Hoteis.ToListAsync();
        }

        public async Task<Hotel> Remove(Hotel hotel)
        {
            _hotelContext.Remove(hotel);
            await _hotelContext.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> Update(Hotel hotel)
        {
            _hotelContext.Update(hotel);
            await _hotelContext.SaveChangesAsync();
            return hotel;
        }
    }

}