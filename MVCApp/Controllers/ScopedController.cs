using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Services;

namespace MVCApp.Controllers;

public class ScopedController : Controller
{
    private readonly ScopedService _scopedService;
    private readonly HelperService _helperService;

    public ScopedController(ScopedService scopedService, HelperService helperService)
    {
        _scopedService = scopedService;
        _helperService = helperService;
    }

    public IActionResult Index()
    {
        return View(new DataDto()
        {
            Id = _scopedService.Id,
            SecondId = _helperService.GetScopedId()
        });
    }
}