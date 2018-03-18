namespace DesignPatterns
{
    public class TataCylinderBuilder : CylinderBuilder
    {
        public override Cylinder Build() => new Cylinder()
        {
            Specification = this.Specification,
            CubicCapacity = this.CubicCapacity
        };

        public override CylinderBuilder WithCubicCapacity(int cubicCapacity)
        {
            this.CubicCapacity = cubicCapacity;
            return this;
        }

        public override CylinderBuilder WithSpecification(string specs)
        {
            this.Specification = specs;
            return this;
        }
    }
}