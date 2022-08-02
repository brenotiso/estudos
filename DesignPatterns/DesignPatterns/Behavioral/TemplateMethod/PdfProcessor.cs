namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal class PdfProcessor : DataProcessor
    {
        public override void GetData(string fileName)
        {
            Console.WriteLine($"Getting data from PDF {fileName}");
        }

        public override void Process()
        {
            Console.WriteLine("Processing data from PDF");
        }

        public override void FinalizeProcess()
        {
            Console.WriteLine($"Sending result of process via email\n");
        }
    }
}
