using HotelApp.Database;
using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services;

public class ReservationServicesService
{
    private readonly AppDbContext _dbContext;

    public ReservationServicesService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<ReservationServices>> GetAllReservationServicesAsync()
    {
        return await _dbContext.ReservationServices.ToListAsync();
    }

    public async Task AddReservationServicesAsync(ReservationServices reservationServices)
    {
        _dbContext.ReservationServices.Add(reservationServices);
        await _dbContext.SaveChangesAsync();
    }
}