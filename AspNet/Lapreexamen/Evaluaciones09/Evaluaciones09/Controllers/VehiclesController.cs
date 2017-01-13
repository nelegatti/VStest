using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evaluaciones09.Models;

namespace Evaluaciones09.Controllers
{
    public class VehiclesController : Controller
    {
        // GET: Vehicles

        private ModelDbContext db = new ModelDbContext();

        public ActionResult Index()
        {
            List<Vehicle> vehicle = db.Vehicles.ToList();
            return View(vehicle);
        }
        public ActionResult Edit(int Id)
        {
            Vehicle v = db.Vehicles.Find(Id);
            ViewBag.VehiclesBrands = new SelectList(db.VehicleBrands.ToList(),"Id","Name",v.VehicleModel.VehicleBrand.Id);
            ViewBag.VehiclesModels = new SelectList(v.VehicleModel.VehicleBrand.VehicleModels.ToList(),"Id","Name",v.VehicleModel.Id);
            ViewBag.VehiclesStatus = new SelectList(db.VehicleStatus.ToList(),"Id","Name",v.VehicleStatus.Id);

            return View(v);
        }


        public ActionResult GetModels(int id)
        {
            VehicleBrand marca = db.VehicleBrands.Find(id);
            List<object> modelos = new List<object>();
            foreach( VehicleModel m in marca.VehicleModels)
            {
                modelos.Add(new { id = m.Id, name=m.Name});
            }

            return Json(modelos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }

    }
}