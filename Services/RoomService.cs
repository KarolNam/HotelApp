using HotelApp.Database;
using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services;

public class RoomService
{
    private readonly AppDbContext _dbContext;

    public RoomService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Room>> GetAllRoomsAsync()
    {
        return await _dbContext.Rooms.ToListAsync();
    }

    public async Task AddRoomAsync(Room room)
    {
        _dbContext.Rooms.Add(room);
        await _dbContext.SaveChangesAsync();
    }
}