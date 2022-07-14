namespace DesignPatterns.Structural.Proxy
{
    internal class DataServiceProxy : IDataService
    {
        private readonly IDataService _dataService;

        private string? _fetchedData;

        public DataServiceProxy(IDataService dataService)
        {
            _dataService = dataService;
        }

        public string GetEncryptedData()
        {
            if (_fetchedData is null)
                _fetchedData = _dataService.GetEncryptedData();

            return _fetchedData;
        }
    }
}
