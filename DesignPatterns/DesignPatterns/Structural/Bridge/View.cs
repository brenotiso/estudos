namespace DesignPatterns.Structural.Bridge
{
    internal abstract class View
    {
        protected IResource _resource;

        public View(IResource resource) => _resource = resource;

        public void SetResource(IResource resource) => _resource = resource;

        public abstract string ShowInfo();
    }
}
