using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class NaturalStructure : NonLivingBeing
    {
        private bool harvestable;

        public NaturalStructure(bool _harvestable, string _material, uint _age, string _location)
            : base(_material, _age, _location) 
        {
            this.harvestable = _harvestable;
        }
    }
}
