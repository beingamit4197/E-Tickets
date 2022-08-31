using E_Tickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data.Services
{
    interface IActorService
    {

        IEnumerable<Actor> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        Actor Update(int id, Actor newActor);

        void Delete(int id);

    }
}
