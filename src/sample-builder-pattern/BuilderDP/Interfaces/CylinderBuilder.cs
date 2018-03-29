using DesignPatterns.BuilderDP.Entities;
namespace DesignPatterns.BuilderDP.Interfaces
{
    public abstract class CylinderBuilder : Builder<Cylinder>
    {

        protected string Specification = "6th generation";
        protected int CubicCapacity = 4;

        public abstract CylinderBuilder WithSpecification(string specs);
        public abstract CylinderBuilder WithCubicCapacity(int cubicCapacity);
    }
}