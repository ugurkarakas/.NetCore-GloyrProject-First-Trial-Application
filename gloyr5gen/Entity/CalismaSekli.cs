using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Entity
{
    public class CalismaSekli
    {
        public int CalismaSekliId { get; set; }

        public string calismaseklibilgi { get; set; }

        public int AdvertisementId { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
