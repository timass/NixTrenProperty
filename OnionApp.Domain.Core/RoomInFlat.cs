using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    class RoomInFlat : RoomIndividual
    {
        public int HowManyRoomsForOneKitchAndBath { get; set; }
        internal RoomInFlat(int floor, bool kitchen, bool bathroom, int howManyRoomsForOneKitchAndBath)
            : base (floor, kitchen, bathroom)
        {
            HowManyRoomsForOneKitchAndBath = howManyRoomsForOneKitchAndBath;
        }
    }
}
