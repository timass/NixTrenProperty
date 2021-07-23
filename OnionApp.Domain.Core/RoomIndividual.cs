using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class RoomIndividual : Room
    {
        public bool Kitchen;
        public bool Bathroom;
        internal RoomIndividual(int floor, bool kitchen, bool bathroom)
        {
            Rooms = 1; Floor = floor; Kitchen = kitchen; Bathroom = bathroom;
        }
    }
}
