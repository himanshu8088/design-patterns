using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class BuilderPatternConsole{
        public static void Main(string[] args){
            
            VehicleBuilder carBuilder =new CarBuilder();
            List<Cylinder> cylinders = new List<Cylinder>()
            {
                new TataCylinderBuilder().WithSpecification("Buggati 7th Gen Cylinder").WithCubicCapacity(600).Build(),
                new TataCylinderBuilder().WithSpecification("Buggati 4th Gen Cylinder").WithCubicCapacity(8000).Build(),
                new TataCylinderBuilder().WithCubicCapacity(8000).Build(),
            };

            Vehicle vehicle=carBuilder.WithBrandName("Buggati")
                                   .WithNumberOfWheels(4)
                                   .WithCylinders(cylinders)
                                   .Build(); 
            Console.WriteLine("Success");                                          
        }
    }

    public class Vehicle{

        public int NumberOfWheels {get; set;}

        public string BrandName {get; set;}

        public List<Cylinder> Cylinders {get; set;}
    }

    public class Cylinder{

        public string Specification {get; set;}

        public int CubicCapacity{get; set;}
    }
    
    public abstract class Builder<T>{
        public abstract T Build(); 
    }

    public abstract class VehicleBuilder : Builder<Vehicle>{

        protected int NumberOfWheels = 5;
        protected string BrandName = "Chevrolet";
        protected List<Cylinder> Cylinders = new List<Cylinder>();

        public abstract VehicleBuilder WithNumberOfWheels(int count);
        public abstract VehicleBuilder WithBrandName(string name);
        public abstract VehicleBuilder WithCylinders(List<Cylinder> cylinders);
    }

    public abstract class CylinderBuilder : Builder<Cylinder>{

        protected string Specification = "6th generation";
        protected int CubicCapacity = 4;

        public abstract CylinderBuilder WithSpecification(string specs);
        public abstract CylinderBuilder WithCubicCapacity(int cubicCapacity);
    }

    public class TataCylinderBuilder : CylinderBuilder
    {
        public override Cylinder Build() => new Cylinder()
        {
            Specification = this.Specification,
            CubicCapacity = this.CubicCapacity
        };

        public override CylinderBuilder WithCubicCapacity(int cubicCapacity)
        {
            this.CubicCapacity=cubicCapacity;
            return this;
        }

        public override CylinderBuilder WithSpecification(string specs)
        {
            this.Specification=specs;
            return this;
        }
    }

    public class CarBuilder: VehicleBuilder{
        
        public override VehicleBuilder WithNumberOfWheels(int count){
            this.NumberOfWheels= count;
            return this;
        }

        public override VehicleBuilder WithBrandName(string name){
            this.BrandName= name;
            return this;
        }

        public override VehicleBuilder WithCylinders(List<Cylinder> cylinders){
            this.Cylinders= cylinders;
            return this;
        }

        public override Vehicle Build(){
            
            return new Vehicle(){
                NumberOfWheels= this.NumberOfWheels,
                BrandName= this.BrandName,
                Cylinders= this.Cylinders
            }; 
        }
    }
}