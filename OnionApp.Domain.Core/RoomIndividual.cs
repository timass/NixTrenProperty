using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionApp.Domain.Core
{
    [Table("RoomIndividuals")]
  public class RoomIndividual : Room
    {
        public bool Kitchen { get; set; }
        public bool Bathroom { get; set; }       
    }
}
