using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StationaryEntity
{
    public class RequestEntity
    {
        public int RequestId { get; set; }
        public UserEntity Requestor { get; set; }
        public BankUnit Bank { get; set; }
    }
}
