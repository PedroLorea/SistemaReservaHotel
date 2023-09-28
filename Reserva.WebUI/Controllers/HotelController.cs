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

    [HttpGet]
    public IActionResult Remove(int? id) {
        if(id == null) return NotFound();

        var hotelDto = _hotelServico.GetById(id);

        if(hotelDto == null) return NotFound();

        return View(hotelDto);
    }

    [HttpPost, ActionName("Remove")]
    public async Task<IActionResult> RemoveConfirmation(int id){
        await _hotelServico.Remove(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int? id) {
        if(id == null) return NotFound();

        var hotelDto = await _hotelServico.GetById(id);

        if(hotelDto == null) return NotFound();

        return View(hotelDto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(HotelDTO hotelDTO) {

        if(ModelState.IsValid){

            await _hotelServico.Update(hotelDTO);
            
            return View("Index");
        }

        return View(hotelDTO);
    }
}