using MVCApp.Models;

namespace MVCApp.Services;

public class HelperService
{
    private readonly ScopedService _scopedService;

    public HelperService(ScopedService scopedService)
    {
        _scopedService = scopedService;
    }

    public string GetScopedId()
    {
        return _scopedService.Id;
    }
}