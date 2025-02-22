using WellFood.DAL.Models;

namespace WellFood.BL.Services.Abstractions;

public  interface ISliderItemService
{
    Task<List<SliderItem>> GetAllSliderItemsAsync();
}
