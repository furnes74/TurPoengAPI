using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurPoengAPI.Models
{
    public class Pictures
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        
        [MaxLength(400)]
        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public bool BlnPrivatePicture { get; set; }

        public DateTime Created { get; set; }
        
        [Key, ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        [Key, ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Poster { get; set; }

    }
}
