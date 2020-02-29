using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Concert_Executives.Models
{
    public class Performer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nationality { get; set; }
        [Required]
        public string Genre { get; set; }
        //Navigacionno svoistvo
        public ICollection<Concert> Concerts { get; set; }
        public Performer()
        {
            this.Concerts = new HashSet<Concert>();
        }
    }
}
