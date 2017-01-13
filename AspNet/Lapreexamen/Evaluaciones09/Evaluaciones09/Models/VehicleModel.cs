namespace Evaluaciones09.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public int VehicleBrandId { get; set; }
        public virtual VehicleClass VehicleClass { get; set; }
        public int VehicleClassId { get; set; }
    }
}