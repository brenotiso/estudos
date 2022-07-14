namespace DesignPatterns.Structural.Bridge
{
    internal class CardView : View
    {
        public CardView(IResource resource) : base(resource)
        {
        }

        public override string ShowInfo()
        {
            return $"#{_resource.GetName()} \n" +
                $"{_resource.GetInfo()} \n" +
                _resource.GetComplement();
        }
    }
}
