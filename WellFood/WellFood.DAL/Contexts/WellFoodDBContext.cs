using Microsoft.EntityFrameworkCore;
using WellFood.DAL.Helpers;
using WellFood.DAL.Models;

namespace WellFood.DAL.Contexts;

public class WellFoodDBContext:DbContext
{
    
    public DbSet<SliderItem> SliderItems { get; set; }
    public WellFoodDBContext(DbContextOptions<WellFoodDBContext>opt):base(opt)
    {
        
    }
}
