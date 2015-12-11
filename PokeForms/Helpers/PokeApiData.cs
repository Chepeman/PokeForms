using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;


namespace PokeForms.Helpers
{
	public class PokeApiData
	{
		static PokeApiData _default;
		public static PokeApiData Default {
			get{
				if (_default == null)
					_default = new PokeApiData ();
				return _default;
			}
		}

		HttpClient _webClient;

		public PokeApiData ()
		{
			_webClient = new HttpClient ();
			_webClient.Timeout = TimeSpan.FromSeconds (30);
		}

		public async Task<PokemonData> GetPokemonData (int PokemonID)
		{
			var uri = new Uri (Constants.EndPoint + "pokemon/" + PokemonID);

			var response = await _webClient.GetAsync (uri);
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync ();
				var Items = JsonConvert.DeserializeObject <PokemonData> (content);
				var debug = true;
				return Items;
			}

			return null;
		}
	}
}

