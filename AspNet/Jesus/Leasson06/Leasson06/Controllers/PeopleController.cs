using MvcLeassons;
using MvcLeassons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leasson06.Controllers
{
    public class PeopleController:Controller
    {
        public ActionResult Index()
        {
            List<Person> People = DataRepository.GetAllPeople();
            return View(People);
        }

        public ActionResult Edit(int Id)
        {
            Person p = DataRepository.GetPerson(Id);
            ViewBag.Countries = new SelectList(DataRepository.GetAllCountries(),"Id","Name",p.City.State.Country.Id);
            ViewBag.States = new SelectList(p.City.State.Country.States, "Id", "Name", p.City.State.Id);
            ViewBag.Cities = new SelectList(p.City.State.Cities, "Id", "Name", p.City.Id);
            //ViewBag.a = new SelectList(p.City,"",) FIX REVIEW 

            return View(p);
        }

        public ActionResult GetStates(int idCountry)
        {
            Country country = DataRepository.GetCountry(idCountry);
            //List < Object > = new List<Object>;
            List<object> list= new List<object>();
            foreach(State s in country.States)
            {
                list.Add(new { id= s.Id, name= s.Name });
            }
            //
            return Json(list);
        }
        public ActionResult GetCities(int idStates)
        {
            State state = DataRepository.GetCities(idStates);
            List<object> l = new List<object>();
            foreach(City c in state.Cities)
            {
                l.Add(new { id = c.Id, name = c.Name });
            }
            return Json(l);
        }


        public ActionResult EditPartial(int Id)
        {
            Person P = DataRepository.GetPerson(Id);
            return PartialView(P);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, FirstName, LastName, BornDate, Salary, City")] Person P)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "Los datos se Guardaron con Exito";
                P.City = DataRepository.GetCity(P.City.Id);
                DataRepository.EditPerson(P);
                return RedirectToAction("Index");
            }else
            return View(P);
        }

        [HttpPost]
        public ActionResult EditPartial([Bind(Include = "Id, FirstName, LastName, BornDate, Salary")] Person P)
        {
            bool sub1 = false;
            string mes1 = "Los datos no se guardaron";

            if (ModelState.IsValid)
            {
                DataRepository.EditPerson(P);
                sub1 = true;
                mes1 = "Datos Guardados";
            }

            return Json(new {success=sub1,message=mes1});
    
        }

    }
}