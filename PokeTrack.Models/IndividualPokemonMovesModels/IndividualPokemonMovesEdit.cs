﻿using PokeTrack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrack.Models.IndividualPokemonMovesModels
{
    public class IndividualPokemonMovesEdit
    {
        public ICollection<IndividualPokemonMoves> IndividualPokemonMovesList { get; set; } = new List<IndividualPokemonMoves>();
        public string IndividualPokemonName { get; set; }
    }
}
