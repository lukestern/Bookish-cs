using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bookish_cs.Controllers
{
    [Route("/[controller]/{action=Memberlist}")]
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;

        public MemberController(ILogger<MemberController> logger)
        {
            _logger = logger;
        }

        //public IActionResult MemberList()
        //{
        //    return View(new PersonManagementViewModel());
        //}
    }
}