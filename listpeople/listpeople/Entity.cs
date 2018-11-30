using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listpeople
{
    class Entity
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Name = value;
            }

        }
        public Entity(string name)
        {
            _name = name;

        }
    }
}
