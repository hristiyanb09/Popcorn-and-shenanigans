using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Concert_Executives.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Place { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [ForeignKey("PerformerId")]
        [Column("Performer")]
        public int PerformerId { get; set; }
        public double Price { get; set; }
        public Performer Performer { get; set; }
    }
}
