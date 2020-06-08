﻿using PokeTrack.Models.PokemonModels;
using PokeTrack.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PokeTrack.Controllers
{
    [Authorize]
    public class PokemonController : ApiController
    {
        private PokemonService CreatePokemonService()
        {
            var pokemonService = new PokemonService();
            return pokemonService;
        }
        public IHttpActionResult Get()
        {
            PokemonService pokemonService = CreatePokemonService();
            var pokemon = pokemonService.GetPokemons();
            return Ok(pokemon);
        }
        public IHttpActionResult Post(PokemonCreate pokemon)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePokemonService();

            if (!service.CreatePokemon(pokemon))
                return InternalServerError();

            return Ok();
        }
    }
}
