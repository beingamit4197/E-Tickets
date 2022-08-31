using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Cinema
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string Logo { get; set; }

        
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Desccription")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
