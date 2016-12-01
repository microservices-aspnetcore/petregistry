using System.Collections.Generic;
using StatlerWaldorfCorp.PetRegistry.Models;

namespace StatlerWaldorfCorp.PetRegistry.Persistence
{
    public interface IPetRepository
    {
           IEnumerable<Pet> List();
           Pet Add(Pet pet);
    }
}
