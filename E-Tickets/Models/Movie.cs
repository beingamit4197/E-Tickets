using E_Tickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Movie
    {
        private const string V = "CinemaId";
        private const string V1 = "ProducerId";

        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory{ get; set; }

        //RelationShip

        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema

        public int CinemaId { get; set; }

        [ForeignKey(V)]

        public Cinema Cinema { get; set; }

        //Producer

        public int ProducerId { get; set; }

        [ForeignKey(V1)]

        public Producer Producer { get; set; }



    }
}
