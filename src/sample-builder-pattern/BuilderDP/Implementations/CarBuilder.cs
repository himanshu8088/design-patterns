using System.Collections.Generic;

namespace DesignPatterns
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