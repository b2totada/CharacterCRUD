using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.DTOs.Character;

namespace backend.Services.CharacterService
{
    //Service interface. Gets/sets data from/for the db and returns data to the client in the client-server(request-response) communication.
    public interface ICharacterService
    {
        //The Task type is needed to be able to make asynchronous calls which is important for larger scale applications to not block a
        //thread completely from receiving further calls by making it wait for a response.

        //Gets all the characters from the db and returns them in a list.
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
        //Gets a certain character from the db based on it's Id and returns it.
        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
        //Adds a new character to the db and returns all the characters from the db in a list.
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
    }
}