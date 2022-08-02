namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class DocProcessor : DataProcessor
    {
        public override void GetData(string fileName)
        {
            Console.WriteLine($"Getting data from DOC {fileName}");
        }

        public override void Process()
        {
            Console.WriteLine("Processing data from DOC");
        }

        public override void FinalizeProcess()
        {
            Console.WriteLine($"Logging result of process\n");
        }
    }
}
