using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters  = new List<Character> {
            new Character(),
            new Character{ Id = 1, Name = "Gigel" }
        };
        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id );
            if(character is not null) {
                var serviceResponse = new ServiceResponse<Character>();
                serviceResponse.Data = character;
                return serviceResponse;
            }
            throw new Exception("Character not found");
        }

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }
    }
}