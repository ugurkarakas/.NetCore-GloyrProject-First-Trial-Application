using gloyr5gen.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Models
{
    public class AdvertisementDetailsModel
    {
        public Advertisement Advertisement { get; set; }

        public List<Sehir> Advertisementsehirs { get; set; }

        public List<CalismaSekli> AdvertisementCalismaSeklis { get; set; }

        public List<Category> Categories { get; set; }
    }
}