using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public abstract class Room : ObjectS
    {
        public int Rooms { get; set; }
        public int Floor { get; set;}
    }
}
