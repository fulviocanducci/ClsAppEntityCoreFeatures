using ClsAppEntityCoreFeatures.Model;
using System;

namespace ClsAppEntityCoreFeatures
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Database db = new Database())
            {

                //ADD
                //---------------------------------------------------------------------------------
                //General g = new General();
                //g.Name = "General 4";
                ////db.Entry(g).Property<DateTime?>("LastUpdate").CurrentValue = DateTime.Now.AddDays(-1);
                //db.Add(g);


                //EDIT
                //---------------------------------------------------------------------------------
                //General ge = db.General.Find(2);
                //if (ge != null)
                //{
                //    EntityEntry<General> _en = db.Entry(ge);
                //    _en.Property<DateTime?>("LastUpdate").CurrentValue = DateTime.Now.AddDays(-1);
                //    _en.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //}

                //SELECT
                //---------------------------------------------------------------------------------
                //var re = db.General
                //    .OrderByDescending(c => EF.Property<DateTime?>(c, "LastUpdate"))
                //    .Select(c => new
                //    {
                //        c.Id,
                //        c.Name,
                //        LastUpdate = EF.Property<DateTime?>(c, "LastUpdate")
                //    })
                //    .ToList();

                //SELECT WITH TUPLE
                //---------------------------------------------------------------------------------
                //List<Tuple<int, string, DateTime?>> items =
                //    db
                //    .General
                //    .Select(c => new Tuple<int, string, DateTime?>(c.Id, c.Name, EF.Property<DateTime?>(c, "LastUpdate")))
                //    .ToList();

                //foreach (Tuple<int, string, DateTime?> item in items)
                //{
                //    //item.Item1;
                //    //item.Item2;  
                //    //item.Item3;
                //}

                //db.SaveChanges();

            }

            Console.ReadKey();
        }
    }
}