using System.Collections.Generic;

namespace DesignPatterns
{
    public class Vehicle
    {

        public int NumberOfWheels { get; set; }

        public string BrandName { get; set; }

        public List<Cylinder> Cylinders { get; set; }
    }
}