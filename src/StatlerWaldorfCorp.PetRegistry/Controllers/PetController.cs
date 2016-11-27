using Microsoft.AspNetCore.Mvc;

namespace StatlerWaldorfCorp.TeamService
{
	[Route("[controller]")]    
    public class PetController : Controller
    {
		[HttpGet]
        public virtual IActionResult GetAll()
		{
			return this.Ok();
		}
    }
}