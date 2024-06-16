using HotelApp.Database;
using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services;

public class GuestService
{
    private readonly AppDbContext _dbContext;

    public GuestService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Guest>> GetAllGuestsAsync()
    {
        return await _dbContext.Guests.ToListAsync();
    }

    public async Task AddGuestAsync(Guest guest)
    {
        _dbContext.Guests.Add(guest);
        await _dbContext.SaveChangesAsync();
    }
}