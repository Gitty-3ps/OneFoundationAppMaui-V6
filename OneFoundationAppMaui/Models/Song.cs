using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFoundationAppMaui.Models
{
    [Table("songs")]
    public class Song : BaseEntity
    {
        [MaxLength(60)]
        public string Title { get; set; }

        public string Authors { get; set; }

        public string Lyrics { get; set; }
    }
}
