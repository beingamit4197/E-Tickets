﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Actor
    {
        [Key]

        public int Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationship

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
 