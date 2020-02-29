using Concert_Executives.Models;
using System;

namespace Concert_Executives
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ConcertPerformersContextDB();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Performer performer1 = new Performer();
            performer1.Name = "Freddy Mercury";
            performer1.Nationality = "America";
            performer1.Genre = "Rock";
            context.Add(performer1);
            //------------------------------------------------------
            Performer performer2 = new Performer();
            performer2.Name = "Yes";
            performer2.Nationality = "YEs";
            performer2.Genre = "YEEEES";
            context.Add(performer2);
            context.SaveChanges();
            //------------------------------------------------------
            Performer performer3 = new Performer();
            performer3.Name = "Ozzy Ousburne";
            performer3.Nationality = "American";
            performer3.Genre = "Rooock";
            context.Add(performer3);
            //------------------------------------------------------
            Performer performer4 = new Performer();
            performer4.Name = "Hrisitiyan Bashkehayov";
            performer4.Nationality = "Bulgarian";
            performer4.Genre = "RoCk";
            context.Add(performer4);
            context.SaveChanges();
            context.SaveChanges();
        }
    }
}