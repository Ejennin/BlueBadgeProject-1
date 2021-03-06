﻿using PokeTrack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrack.Models.TeamModels
{
    public class TeamListItem
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string UserName { get; set; }
        public List<IndividualPokemon> PokemonTeam { get; set; }
    }
}
