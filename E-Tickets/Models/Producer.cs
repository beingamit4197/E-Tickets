using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public String Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
