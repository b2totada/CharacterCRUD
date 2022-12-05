using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.DTOs.Character;
using backend.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    //Controller for CharacterService. Provides an additional layer between client and service to increase scalability.
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        //CharacterService injection in constructor
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
            
        }

        #region Service Calls
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get()
        {
            var serviceResponse = await _characterService.GetAllCharacters();
            serviceResponse.Message = serviceResponse.Data.Count == 0 ? "No characters in db" : "";
            return Ok(serviceResponse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingle(int id)
        {
            var serviceResponse = await _characterService.GetCharacterById(id);
            return serviceResponse.Success ? Ok(serviceResponse) : NotFound(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> UpdateCharacter(UpdateCharacterDTO updatedCharacter)
        {
            var serviceResponse = await _characterService.UpdateCharacter(updatedCharacter);
            return serviceResponse.Success ? Ok(serviceResponse) : NotFound(serviceResponse);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> DeleteCharacter(int id)
        {
            var serviceResponse = await _characterService.DeleteCharacter(id);
            return serviceResponse.Success ? Ok(serviceResponse) : NotFound(serviceResponse);
        }
        #endregion
    }
}