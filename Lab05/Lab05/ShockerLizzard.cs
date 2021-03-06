﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    public class ShockerLizzard : Fiend, ITremorSense
    {
        public override string Name { get; } = "ShockerLizzard";
        public override int HP { get; set; } = 12;
        public override string SubType { get; set; }
        public override string Immunity { get; set; } = "Fire, Poison";
        public override string NativePlane => base.NativePlane;
        protected override bool Hostile { get => base.Hostile; set => base.Hostile = value; }

        public override string[] Abilities()
        {
            string[] abs = new string[0];
            return abs;
        }

        public override int ThreatLevel(int strength)
        {
            return base.ThreatLevel(strength);
        }

        public override string Feed(int count, int hunger)
        {
            if (count > hunger)
            {
                return "Satisfied";
            }
            else
            {
                return "Hungry";
            }
        }

        public override void Transport()
        {
            //How to transport
        }

        public string Dig()
        {
            //Can dig and burrow
            return "burrow";
        }

        public string TremorSense()
        {
            //Can "see" through the ground
            return "blindsight";
        }
    }
}
