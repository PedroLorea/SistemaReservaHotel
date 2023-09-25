using Reserva.Application.DTOs;

namespace Reserva.Application.Interface;

public interface IHotelServico{

    Task<IEnumerable<HotelDTO>> GetHoteis();
    Task<HotelDTO> GetById(int? id);
    Task Create(HotelDTO hotelDTO); 
    Task Remove(int? id); 
    Task Update(HotelDTO hotelDTO); 

}