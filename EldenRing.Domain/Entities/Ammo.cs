using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenRing.Domain.Entities
{
    public class Ammo
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public const string Type = "Pierce";
        public string AttackPowerJson { get; set; }
        public string? Passive { get; set; }
    }
}
