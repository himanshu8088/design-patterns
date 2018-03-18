using DesignPatterns.DecoratorDP;
namespace DesignPatterns
{
    public class DesignPatternConsole{

        public static void Main(string[] args){
            BuilderPattern builderPattern = new BuilderPattern();
            builderPattern.Run();

            DecoratorPattern decoratorPattern = new DecoratorPattern();
            decoratorPattern.Run();
        }
    }
}