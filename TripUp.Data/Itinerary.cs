using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripUp.Data
{
    class Itinerary
    {
        [Key]
        public int ItineraryId { get; set; }
        public string PitStop { get; set; }
        public int TravelDistance { get; set; }
        public DateTime TravelTime { get; set; }

    }
}
