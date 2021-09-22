using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weterynarz.Model
{
    enum Species
    {
        Dog = 0,
        Cat = 1,
        Parrot = 2,
        Cow = 3
    }
    class Patient
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public Species species {get; set;}
    }
}
