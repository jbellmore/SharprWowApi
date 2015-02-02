﻿using System.Collections.Generic;

namespace SharprWowApi.WowModels.BattlePet
{
    public class BattlePetSpeciesRoot
    {
        public int SpeciesId { get; set; }
        public int PetTypeId { get; set; }
        public int CreatureId { get; set; }
        public string Name { get; set; }
        public bool CanBattle { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public List<BattlePetAbilitiesRoot> abilities { get; set; }
    }
}