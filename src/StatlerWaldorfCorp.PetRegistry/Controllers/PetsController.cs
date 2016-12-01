using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.PetRegistry.Persistence;
using StatlerWaldorfCorp.PetRegistry.Models;

namespace StatlerWaldorfCorp.PetRegistry
{    
	[Route("[controller]")]
    public class PetsController : Controller
    {
        private IPetRepository repository;

        public PetsController(IPetRepository repository) 
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Pet pet)
        {
            this.repository.Add(pet);
            return this.Created($"/pets/{pet.ID}", pet);
        }

		[HttpGet]
        public IActionResult GetAll()
		{
			return this.Ok(this.repository.List());
		}
    }
}