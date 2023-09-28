using Microsoft.AspNetCore.Mvc;
using Reserva.Application.DTOs;
using Reserva.Application.Interface;

namespace Reserva.WebUI.Controllers;

public class HotelController : Controller {

    private readonly IHotelServico _hotelServico;

    public HotelController(IHotelServico hotelServico)
    {
        _hotelServico = hotelServico;
    }


    [HttpGet]
    public async Task<IActionResult> Index() {
        var hoteis = await _hotelServico.GetHoteis();
        return View(hoteis);
    }


    [HttpGet]
    public IActionResult Create() {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Create(HotelDTO hotelDTO) {
        
        if(ModelState.IsValid){
            await _hotelServico.Create(hotelDTO);
            return RedirectToAction(nameof(Index));
        }

        return View(hotelDTO);
    }


}