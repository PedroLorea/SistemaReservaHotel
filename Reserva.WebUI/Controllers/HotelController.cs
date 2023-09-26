using Microsoft.AspNetCore.Mvc;
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


    // public async Task<IActionResult> Remover() {

    // }


}