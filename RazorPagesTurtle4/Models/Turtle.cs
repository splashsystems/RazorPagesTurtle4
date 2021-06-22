using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTurtle4.Models
{
    public class Turtle
    {
        public int ID { get; set; }
        public string TurtleName { get; set; }
        [Display(Name = "Realease Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
