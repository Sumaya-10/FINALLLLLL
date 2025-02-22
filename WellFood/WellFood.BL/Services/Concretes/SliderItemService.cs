

using Microsoft.EntityFrameworkCore;
using WellFood.BL.Services.Abstractions;
using WellFood.DAL.Contexts;
using WellFood.DAL.Models;

namespace WellFood.BL.Services.Concretes;

public class SliderItemService : ISliderItemService
{
    private readonly WellFoodDBContext _context;

    public SliderItemService(WellFoodDBContext context)
    {
        _context = context;
    }

    public async Task<List<SliderItem>> GetAllSliderItemsAsync()
    {
        List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
        return sliderItems;
    }
}
