using System.Collections.Generic;

namespace DesignPatterns
{
    public abstract class VehicleBuilder : Builder<Vehicle>
    {

        protected int NumberOfWheels = 5;
        protected string BrandName = "Chevrolet";
        protected List<Cylinder> Cylinders = new List<Cylinder>();

        public abstract VehicleBuilder WithNumberOfWheels(int count);
        public abstract VehicleBuilder WithBrandName(string name);
        public abstract VehicleBuilder WithCylinders(List<Cylinder> cylinders);
    }
}