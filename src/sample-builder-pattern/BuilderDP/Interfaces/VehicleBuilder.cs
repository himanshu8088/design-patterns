using System.Collections.Generic;
using DesignPatterns.BuilderDP.Entities;

namespace DesignPatterns.BuilderDP.Interfaces
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