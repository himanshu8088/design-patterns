using System.Collections.Generic;
using DesignPatterns.BuilderDP.Interfaces;
using DesignPatterns.BuilderDP.Entities;

namespace DesignPatterns.BuilderDP.Implementaions
{
    public class CarBuilder : VehicleBuilder
    {

        public override VehicleBuilder WithNumberOfWheels(int count)
        {
            this.NumberOfWheels = count;
            return this;
        }

        public override VehicleBuilder WithBrandName(string name)
        {
            this.BrandName = name;
            return this;
        }

        public override VehicleBuilder WithCylinders(List<Cylinder> cylinders)
        {
            this.Cylinders = cylinders;
            return this;
        }

        public override Vehicle Build()
        {

            return new Vehicle()
            {
                NumberOfWheels = this.NumberOfWheels,
                BrandName = this.BrandName,
                Cylinders = this.Cylinders
            };
        }
    }
}