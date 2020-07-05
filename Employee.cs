using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4PrototypeStrategy
{
    class Employee : ICloneable
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Name = {Name} ID = {ID} Age={Age} Salary={Salary}";
        }
       
    }
}
