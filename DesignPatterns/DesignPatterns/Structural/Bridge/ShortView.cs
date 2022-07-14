namespace DesignPatterns.Structural.Bridge
{
    internal class ShortView : View
    {
        public ShortView(IResource resource) : base(resource)
        {
        }

        public override string ShowInfo()
        {
            return _resource.GetInfo();
        }
    }
}
