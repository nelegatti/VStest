using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Evaluaciones09.Models;

namespace Evaluaciones09
{
    public class ModelDbContext : DbContext
    {

        public ModelDbContext() : base("Server=.\\SQLEXPRESS;Database=Leasson05;user=alumno;password=alumno")
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        public DbSet<VehicleBrand> VehicleBrands { get; set; }

        public DbSet<VehicleClass> VehicleClasses { get; set; }

        public DbSet<VehicleStatus> VehicleStatus { get; set; }

    }
}