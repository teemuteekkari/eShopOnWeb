using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopWeb.Web.Controllers.Api;

// No longer used - shown for reference only if using full controllers instead of Endpoints for APIs
[Route("api/[controller]/[action]")]
[ApiController]
public class BaseApiController : ControllerBase
{

    private string JoinTwoStrings(string one, string two) {
        var NewString = string.Concat(one, two);
        return NewString;
    }
 }
