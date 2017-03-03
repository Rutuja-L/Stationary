using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryEntity
{
    public class VendorEntity
    {
        public int VendorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int FaxNo { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }
        public List<ItemEntity> ItemsSupplied { get; set; }
    }
}
