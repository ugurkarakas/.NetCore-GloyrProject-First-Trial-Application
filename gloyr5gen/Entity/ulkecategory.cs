using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Entity
{
    public class ulkecategory
    {
        public int ulkecategoryId { get; set; }

        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }

        public int ulkeId { get; set; }
        public ulke ulke { get; set; }
    }
}
