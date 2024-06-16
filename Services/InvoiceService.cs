using HotelApp.Database;
using HotelApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services;

public class InvoiceService
{
    private readonly AppDbContext _dbContext;

    public InvoiceService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Invoice>> GetAllInvoicesAsync()
    {
        return await _dbContext.Invoices.ToListAsync();
    }

    public async Task AddInvoiceAsync(Invoice invoice)
    {
        _dbContext.Invoices.Add(invoice);
        await _dbContext.SaveChangesAsync();
    }
}