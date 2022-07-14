namespace DesignPatterns.Creational.Singleton
{
    internal class TokenProviderSingleton
    {
        private static TokenProviderSingleton? instance;

        public string Token;
        public DateTime ExpireTime;

        private TokenProviderSingleton()
        {
            Token = String.Empty;
            ExpireTime = DateTime.Now;
        }

        public static TokenProviderSingleton GetInstance()
        {
            if (instance is null)
                instance = new TokenProviderSingleton();

            return instance;
        }

        public string GetToken()
        {
            if (ExpireTime <= DateTime.Now)
                RenewToken();

            return Token;
        }

        private void RenewToken()
        {
            Token = "123" + DateTime.Now.Ticks;
            ExpireTime = DateTime.Now.AddMilliseconds(5);
        }
    }
}
