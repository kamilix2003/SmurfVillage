using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class LivingBeing : Entity
    {
        private string name;
        protected uint health;
        protected uint energy;

        protected LivingBeing(string _name, uint _age, string _location)
            : base(_age, _location)
        {
            this.name = _name;
            this.health = 100;
            this.energy = 100;
        }
    }
}
