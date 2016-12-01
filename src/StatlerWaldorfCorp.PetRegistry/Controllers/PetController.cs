using Microsoft.AspNetCore.Mvc;

namespace StatlerWaldorfCorp.PetRegistry
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