using Microsoft.AspNetCore.Mvc;
using WellFood.BL.Services.Abstractions;
using WellFood.DAL.Contexts;
using WellFood.DAL.Models;

namespace WellFood.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ISliderItemService _sliderItemService;

    public HomeController(ISliderItemService sliderItemService)
    {
        _sliderItemService = sliderItemService;
    }

    public async Task<IActionResult> Index()
    {
       List<SliderItem> sliderItems=await _sliderItemService.GetAllSliderItemsAsync();
        return View(sliderItems);
    }
}
