using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IvanAgencyModel
{
    [DataContract]
    public class TravelTour
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int TravelId { get; set; }

        [DataMember]
        public int TourId { get; set; }

        [DataMember]
        public decimal TourPrice { get; set; }

        public virtual Travel Travel { get; set; }

        public virtual Tour Tour { get; set; }
    }
}