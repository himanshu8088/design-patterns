using System;
using System.Collections.Generic;
using System.Diagnostics;
using DesignPatterns.BuilderDP.Interfaces;
using DesignPatterns.BuilderDP.Implementaions;
using DesignPatterns.BuilderDP.Entities;

namespace DesignPatterns.BuilderDP
{
    public class BuilderPattern : Pattern
    {
        public override void Run()
        {
            base.Run();
            VehicleBuilder carBuilder = new CarBuilder();
            List<Cylinder> cylinders = new List<Cylinder>()
            {
                new TataCylinderBuilder().WithSpecification("Buggati 7th Gen Cylinder").WithCubicCapacity(600).Build(),
                new TataCylinderBuilder().WithSpecification("Buggati 4th Gen Cylinder").WithCubicCapacity(8000).Build(),
                new TataCylinderBuilder().WithCubicCapacity(8000).Build(),
            };

            Vehicle vehicle = carBuilder.WithBrandName("Buggati")
                                   .WithNumberOfWheels(4)
                                   .WithCylinders(cylinders)
                                   .Build();
            Debug.WriteLine("Car builded successfully");
        }
    }
}