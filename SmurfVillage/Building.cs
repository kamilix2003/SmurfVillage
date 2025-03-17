using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class Building : NonLivingBeing
    {
        private float area;
        private uint capacity;

        public Building(float _area, uint _capacity, string _material, uint _age, string _location)
            : base(_material, _age, _location)
        {
            this.area = _area;
            this.capacity = _capacity;
        }
    }
}
