using ClsAppEntityCoreFeatures.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;

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
                //g.Name = "General 2";
                //db.Entry(g).Property<DateTime?>("LastUpdate").CurrentValue = DateTime.Now.AddDays(-1);
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


                //People p = new People();
                //p.Name = "Nome 2";
                //p.Phones.Add(new Phone
                //{
                //    People = p,
                //    Number = "(11)9999-8888"
                //});

                //db.People.Add(p);


                People p = db.People.Include(c => c.Phones).Where(c => c.PeopleId == 2).FirstOrDefault();
                db.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}