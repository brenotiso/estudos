namespace DesignPatterns.Behavioral.TemplateMethod
{
    internal abstract class DataProcessor
    {
        public abstract void GetData(string fileName);
        public abstract void Process();
        public abstract void FinalizeProcess();

        // Template Method
        public void Run(string fileName)
        {
            GetData(fileName);
            Process();
            FinalizeProcess();
        }
    }
}
