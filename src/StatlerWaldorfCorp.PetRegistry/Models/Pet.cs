using System;

namespace StatlerWaldorfCorp.PetRegistry.Models
{
    public class Pet
    {
        public Guid ID { get; set;}
        public string Name { get; set;}        
        public Human Owner { get; set;}
    }
}