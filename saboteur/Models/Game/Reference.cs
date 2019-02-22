using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models
{
    public class Reference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferenceId { get; set; }
        public int DocumentId { get; set; }
        public int DocumentTypeId { get; set; }
        public DateTime DateRetrieved { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }
        [MaxLength(60)]
        public string Title { get; set; }

        public DocumentType DocumentType { get; set; }
        public Player Player { get; set; }
        public Episode Episode { get; set; }
    }
}
