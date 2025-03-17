using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class Smurf : LivingBeing
    {
        private uint hatColor; 

        public Smurf(uint _hatColor, string _name, uint _health, uint _energy, uint _age, string _location)
            : base(_name, _health, _energy, _age, _location)
        {
            this.hatColor = _hatColor;
        }
    }
}
