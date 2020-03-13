using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurPoengAPI.Models
{
    public class PostVisit
    {
        public int Id { get; set; }

        [Required]
        public DateTime Registered { get; set; }

        public int Points { get; set; }

        /* Er ditta ein måte å gjera det på ?*/

        [Key, ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        [Key, ForeignKey("Poster")]
        public int PostId { get; set; }
        public Post Poster { get; set; }

    }
}
