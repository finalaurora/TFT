using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    interface ISound
    {
        void ProduceSound();
    }
    abstract class Animal:ISound
    {
        protected int Age { get; set; }
        protected string Name { get; set; }
        protected string Sex { get; set; }

        public void ProduceSound()
        {

            throw new NotImplementedException();
        }
    }
}
