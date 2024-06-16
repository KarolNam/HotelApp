using HotelApp.Database;
using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services;

public class ReservationService
{
    private readonly AppDbContext _dbContext;

    public ReservationService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Reservation>> GetAllReservationsAsync()
    {
        return await _dbContext.Reservations.ToListAsync();
    }

    public async Task AddReservationAsync(Reservation reservation)
    {
        _dbContext.Reservations.Add(reservation);
        await _dbContext.SaveChangesAsync();
    }
}