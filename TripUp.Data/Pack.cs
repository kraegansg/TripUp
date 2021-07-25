using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripUp.Data
{
    class Pack
    {
        [Key]
        public int PackId { get; set; }
        public string Clothes { get; set; }
        public string BathItems { get; set; }
        public string Essentials { get; set; }
        public string Other {get; set;}
    }
}
