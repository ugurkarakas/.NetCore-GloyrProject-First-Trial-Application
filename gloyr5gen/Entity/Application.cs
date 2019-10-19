using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Entity
{
    public class Application //basvuru
    {
        public int ApplicationId { get; set; }
        public string basvurunumara { get; set; }
        public double toplam { get; set; }
        public DateTime basvurutarihi { get; set; }
    }
}
