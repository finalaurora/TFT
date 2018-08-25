using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class Kitten:Cat
    {
        private new readonly string Sex = "Female";

        public Kitten() => this.Sex = "Female";
    }
}
