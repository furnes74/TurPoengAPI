using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurPoengAPI.Models
{
    public class IdrettslagPost
    {
        public int IdrettslagId { get; set; }
        public Idrettslag Idrettslag { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public int OverridePoints { get; set; }

    }
}
