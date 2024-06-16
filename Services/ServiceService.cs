using HotelApp.Database;
using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services;

public class ServiceService
{
    private readonly AppDbContext _dbContext;

    public ServiceService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Service>> GetAllServicesAsync()
    {
        return await _dbContext.Services.ToListAsync();
    }

    public async Task AddServiceAsync(Service service)
    {
        _dbContext.Services.Add(service);
        await _dbContext.SaveChangesAsync();
    }
}