using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class Entity
    {
        private static uint idCount = 0;
        private uint id;
        private uint age;
        protected string location;

        protected Entity(uint _age, string _location) 
        {
            this.id = ++idCount;
            this.age = _age;
            this.location = _location;
        }

        protected Entity(uint id, uint age, string location)
        {
            this.id = id;
            this.age = age;
            this.location = location;
        }
    }
}
