using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class NonLivingBeing : Entity
    {
        private string material;

        protected NonLivingBeing(string _material, uint _age, string _location)
            : base(_age, _location)
        {
            this.material = _material;
        }
    }
}
