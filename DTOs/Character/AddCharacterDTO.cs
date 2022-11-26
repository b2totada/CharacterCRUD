using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTOs.Character
{
    //A DTO(Data-Transfer-Object) is used to represent the data in the service model (which is a map of the data in the db) to the client.
    //It's important because it provides the client with a limited toolset to interact with the db (f.e.: to not receive every piece of
    //data from the db or to be able to add new data to the db without having to set every property of that data)

    //DTO for the client to add a new character to the db
    public class AddCharacterDTO
    {
        //Id has been omitted so the client don't have to set it
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strenght { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}