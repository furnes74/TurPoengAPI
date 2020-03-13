using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurPoengAPI.Models
{
    public class PersonActive
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public DateTime LastActiveTime { get; set; }
    }
}
