using System.Collections.Generic;

namespace DesignPatterns.BuilderDP.Entities
{
    public class Vehicle
    {

        public int NumberOfWheels { get; set; }

        public string BrandName { get; set; }

        public List<Cylinder> Cylinders { get; set; }
    }
}