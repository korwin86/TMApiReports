using System.Data;
using System.IO;
using System.Net;
using TmApiBL.Model;
using TmApiBL.Models;

namespace TmApiBL.Controller
{
    class ConnectionController
{
        public string Data { get;  }
    
        public ConnectionController(ConnectionData data, Request request)

        {
            WebClient client = new WebClient();
            client.Headers.Add("Signature", request.Signature);
            Stream stream = client.OpenRead(data.Url);
            StreamReader reader = new StreamReader(stream);
            Data = reader.ReadToEnd();
            stream.Close();
            reader.Close();
        }
    }
}
