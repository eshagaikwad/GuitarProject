using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProject.Model
{
    public enum Builder
    {
        Fender, Martin, Gibson, Collings, Olson, Ryan, PRS, Any

    }

    public enum Types
    {
        Acoustic, Electric

    }

    public enum Wood
    {
        IndianRosewood, BrazilianRosewood, Mahogany, Maple, Cocobolo, Cedar, Adirondack, Alder, Sitka

    }
    public class GuitarSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Types Types { get; }

        public Wood BackWood { get; }

        public Wood TopWood { get; }

        public GuitarSpec(Builder builder,string model,Types types,Wood backwood,Wood topwood)
        {
            Builder = builder;
            Model = model;
            Types = types;
            BackWood = backwood;
            TopWood = topwood;


        }

        public bool Matches(GuitarSpec otherSpec)
        { 
            if(Builder!=otherSpec.Builder)
                return false;
            if(Model!=otherSpec.Model)
                return false;
            if (Types!=otherSpec.Types)
                return false;
            if(BackWood!=otherSpec.BackWood)
                return false;
             if(TopWood != otherSpec.TopWood)
                return false;
          return true;

        }

    }
}
