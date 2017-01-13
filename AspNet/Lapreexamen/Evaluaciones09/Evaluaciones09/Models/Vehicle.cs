﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evaluaciones09.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int OdometerValue { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public int VehicleModelId { get; set; }
        public virtual VehicleStatus VehicleStatus { get; set; }

        public int VehicleStatusId { get; set; }
    }
}