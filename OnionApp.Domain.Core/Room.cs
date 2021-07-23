using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    public abstract class Room : ObjectS
    {
        public int Rooms;       
       /* public virtual int rooms
            { 
            get {return Rooms;}
            set { Rooms = 1; }
            }*/
        public int Floor { get; set;}
    }
}
