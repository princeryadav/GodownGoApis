using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace LearnProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoDownController : Controller
    {
        private readonly IGoDownService _goDownService;

        public GoDownController(IGoDownService goDownService)
        {
            _goDownService = goDownService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var goDowns = await _goDownService.GetGoDownsAsync();
            return Json(goDowns);
        }
    }
}
