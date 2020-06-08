﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrack.Data
{
    public class Pokemon
    {
        [Key]
        public int PokemonID { get; set; }

        [Required]
        public string PokemonName { get; set; }
        [Required]
        public string PokemonType { get; set; }
        [Required]
        [Range(1, 4)]//this may not be the right way to do this
        public List<Move> MoveList { get; set; }
        [Required]
        public string DietType { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
        public List<Move> Move { get; set; }
    }
}