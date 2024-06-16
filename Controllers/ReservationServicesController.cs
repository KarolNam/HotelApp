using HotelApp.Database.Entities;
using HotelApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationServicesController : ControllerBase
{
    private readonly ReservationServicesService _reservationServicesService;

    public ReservationServicesController(ReservationServicesService reservationServicesService)
    {
        _reservationServicesService = reservationServicesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ReservationServices>>> GetAllReservationServices()
    {
        var reservationServicesService = await _reservationServicesService.GetAllReservationServicesAsync();
        return Ok(reservationServicesService);
    }

    [HttpPost]
    public async Task<IActionResult> AddReservationServices(ReservationServices reservationServices)
    {
        await _reservationServicesService.AddReservationServicesAsync(reservationServices);
        return Ok();
    }
}
