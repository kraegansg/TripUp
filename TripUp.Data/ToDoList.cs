using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripUp.Data
{
    class ToDoList
    {
        [Key]
        public int ToDoListId { get; set; }

        [ForeignKey(nameof(Trip))]
        public int TripId { get; set; }
        public virtual Trip Trip { get; set; }

        public string PetCareInstructions { get; set; }
        public string ChildCareInstructions { get; set; }
        public string HouseCareInstructions { get; set; }
    }
}
