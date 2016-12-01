using System;
using System.Collections.Generic;

namespace StatlerWaldorfCorp.PetRegistry.Models
{
    public class Human 
    {
        public Guid ID { get; set;}
        public string Name { get; set;}        
        public ICollection<Pet> Pets { get; set;}
    }
}