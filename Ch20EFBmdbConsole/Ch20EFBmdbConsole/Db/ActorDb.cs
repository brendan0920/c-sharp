using Ch20EFBmdbConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch20EFBmdbConsole.Db
{
    internal class ActorDb
    {
        private bmdbContext dbContext = new();

        //CRUD Methods
        public List<Actor> GetActors()
        {
            return dbContext.Actors.ToList();
        }

        public Actor FindActors(int id)
        {
            return dbContext.Actors.Where(a => a.Id == id).FirstOrDefault();
        }

        public void AddActor(Actor actor)
        {
            dbContext.Actors.Add(actor);
            dbContext.SaveChanges();
        }

        public void UpdateActor(Actor actor)
        {
            dbContext.SaveChanges();
        }

        public void RemoveActor(Actor actor)
        {
            dbContext.Actors.Remove(actor);
            dbContext.SaveChanges();
        }


    }

}
