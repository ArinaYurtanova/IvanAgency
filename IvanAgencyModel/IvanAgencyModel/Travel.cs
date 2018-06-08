using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IvanAgencyModel
{
    [DataContract]
    public class Travel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string TravelName { get; set; }

        [DataMember]
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("TravelId")]
        public virtual List<Order> Orders { get; set; }

        [ForeignKey("TravelId")]
        public virtual List<TravelTour> TravelTours { get; set; }
    }
}
