using AutoMapper;
using Reserva.Application.DTOs;
using Reserva.Application.Interface;
using Reserva.Domain.Entidades;
using Reserva.Domain.Interfaces;

namespace Reserva.Application.Servicos;

public class HotelServico : IHotelServico
{

    private IHotelRepositorio _hotelRepository; 
    private readonly IMapper _mapper;

    public HotelServico(IHotelRepositorio repository, IMapper mapper)
    {
        _hotelRepository = repository;
        _mapper = mapper;
    }

    public async Task<HotelDTO> GetById(int? id)
    {
        var hotelEntidade = await _hotelRepository.GetById(id);
        return _mapper.Map<HotelDTO>(hotelEntidade);
    }

    public async Task<IEnumerable<HotelDTO>> GetHoteis()
    {
        var hoteisEntidade = await _hotelRepository.getHoteis();
        return _mapper.Map<IEnumerable<HotelDTO>>(hoteisEntidade);
        
    }

    public async Task Create(HotelDTO hotelDTO)
    {
        var hotelEntidade = _mapper.Map<Hotel>(hotelDTO);
        await _hotelRepository.Create(hotelEntidade);
    }

    public async Task Remove(int? id)
    {
        var hotelEntidade = _hotelRepository.GetById(id).Result;
        await _hotelRepository.Remove(hotelEntidade);
    }

    public async Task Update(HotelDTO hotelDTO)
    {
        var hotelEntidade = _mapper.Map<Hotel>(hotelDTO);
        await _hotelRepository.Update(hotelEntidade);
    }
}