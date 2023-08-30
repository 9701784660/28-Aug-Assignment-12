using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_12.Models
{
    [Table("Comments")]
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}