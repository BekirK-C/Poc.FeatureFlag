using Microsoft.AspNetCore.Mvc;
using Poc.FeatureFlag.Constants;
using Unleash;

namespace Poc.FeatureFlag.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeatureController : ControllerBase
{
    private readonly IUnleash _unleash;

    public FeatureController(IUnleash unleash)
    {
        _unleash = unleash;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_unleash.IsEnabled(FeatureFlags.IsAvailableForAllUsers)
            ? "New feature is available for all users."
            : "This feature is under development and is not available for all users!");
    }
}