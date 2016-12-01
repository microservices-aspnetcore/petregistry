using System.Collections.Generic;
using StatlerWaldorfCorp.PetRegistry.Models;

namespace StatlerWaldorfCorp.PetRegistry.Persistence
{
    public class MemoryPetRepository : IPetRepository
    {
        private ICollection<Pet> pets = new List<Pet>();

        public MemoryPetRepository()
        {
        }

        public IEnumerable<Pet> List() 
        {
            return this.pets;
        }

        public Pet Add(Pet pet)
        {
            this.pets.Add(pet);
            return pet;
        }
    }
}