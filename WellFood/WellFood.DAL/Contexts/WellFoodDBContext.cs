using Microsoft.EntityFrameworkCore;
using WellFood.DAL.Models;

namespace WellFood.DAL.Contexts;

public class WellFoodDBContext:DbContext
{
    private readonly string _connectionStr = @"Server=WIN-LIOGS5LQGIQ\SQLEXPRESS;Database=WellFoodDB;Trusted_Connection=True;TrustServerCertificate=True";
    public DbSet<SliderItem> SliderItems { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionStr);
        base.OnConfiguring(optionsBuilder);
    }
}
