namespace DesignPatterns.Behavioral.Memento
{
    internal interface IMemento
    {
        string GetName();
        object GetState();
        DateTime GetDate();
    }
}
