namespace MVCApp.Services;

public class ScopedService
{
    public string Id { get; set; }
    public ScopedService()
    {
        Id = Guid.NewGuid().ToString();
    }
}