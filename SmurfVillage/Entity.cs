using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmurfVillage
{
    class Entity
    {
        static uint id_count = 0;
        private uint id;
        private uint age;
        protected string location;

        protected Entity(uint _age, string _location) 
        {
            this.id = ++id_count;
            this.age = _age;
            this.location = _location;
        }

        private Entity(uint id, uint age, string location)
        {
            this.id = id;
            this.age = age;
            this.location = location;
        }
    }
}
