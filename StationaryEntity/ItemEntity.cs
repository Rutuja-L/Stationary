using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryEntity
{
    public class ItemEntity
    {
        public int Code { get; set;}
        public string Description { get; set; }
        public Enum Unit { get; set; }
        public string Specification { get; set; }
        public double Price { get; set; }
        public List<string> Image { get; set; }

    }
}
