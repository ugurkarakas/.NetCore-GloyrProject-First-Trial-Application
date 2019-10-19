using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Entity
{
    public class AdvertisementCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
    }
}
