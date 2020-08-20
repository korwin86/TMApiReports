using TmApiBL.Models;

namespace TmApiBL.Model
{
    public class ConnectionData
    {
        public string Port { get; }
        public string Ip { get; }
        public string Secret { get; }
        public string Url { get; }

        Request Request { get; }

        public ConnectionData()
        {
            
        }

    }
}
