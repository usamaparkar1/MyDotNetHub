namespace MyDotNetHub.Models
{
    public class AppSettings : IAppSettings
    {
        public required string BackgroundColor { get; set; }
    }

    public interface IAppSettings
    {
        string BackgroundColor { get; set; }
    }

    public abstract class SomeAbstractClass
    {
        public abstract string Name { get; set; }

        public abstract void SomeAbstractFunction();
    }

    public class SomeClass : SomeAbstractClass
    {
        public override string Name { get; set; }
        public override void SomeAbstractFunction()
        {
        }

        public SomeClass(SomeClass someClass)
        {
            Name = someClass.Name;
        }
    }
}