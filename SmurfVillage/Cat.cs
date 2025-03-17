using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class Cat : LivingBeing
    {
        private uint furColor;
        private string furPattern;

        public Cat(uint _furColor, string _furPattern, string _name, uint _health, uint _energy, uint _age, string _location)
            : base(_name, _health, _energy, _age, _location)
        {
            this.furColor = _furColor;
            this.furPattern = _furPattern;
        }
    }
}
