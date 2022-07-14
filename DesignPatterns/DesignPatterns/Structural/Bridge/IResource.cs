namespace DesignPatterns.Structural.Bridge
{
    public interface IResource
    {
        string GetInfo();

        string GetName();

        string GetComplement();
    }
}