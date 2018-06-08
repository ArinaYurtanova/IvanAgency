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
    public class Tour
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string TourName { get; set; }

        [DataMember]
        [Required]
        public decimal PriceTour { get; set; }

        [ForeignKey("TourId")]
        public virtual List<TravelTour> TravelTours { get; set; }
    }
}

