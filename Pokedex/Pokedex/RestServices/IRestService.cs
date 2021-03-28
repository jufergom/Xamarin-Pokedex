using Pokedex.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.RestServices
{
    public interface IRestService
    {
        Task<List<PokemonItem>> RefreshDataAsync();

        Task<Pokemon> GetPokemon(int id);
    }
}
