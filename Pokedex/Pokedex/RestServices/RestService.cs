using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Data;
using Pokedex.RestServices;

namespace Pokedex
{
    public class RestService : IRestService
    {
        public Task<Pokemon> GetPokemon(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PokemonItem>> RefreshDataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
