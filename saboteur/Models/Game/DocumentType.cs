using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace saboteur.Models
{
    public class DocumentType
    {
        [Key]
        public int DocumentTypeId { get; set; }
        [MaxLength(60)]
        public string Type { get; set; }
    }
}
