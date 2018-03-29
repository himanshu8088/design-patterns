using DesignPatterns.DecoratorDP;
using DesignPatterns.SingletonDP;
using DesignPatterns.BuilderDP;
using DesignPatterns.CommandDP;
namespace DesignPatterns
{
    public class DesignPatternConsole{

        public static void Main(string[] args){
            Pattern builderPattern = new BuilderPattern();
            builderPattern.Run();

            Pattern decoratorPattern = new DecoratorPattern();
            decoratorPattern.Run();

            Pattern singletonPattern = new SingletonPattern();
            singletonPattern.Run();

            Pattern commandPattern = new CommandPattern();
            commandPattern.Run();
        }
    }
}