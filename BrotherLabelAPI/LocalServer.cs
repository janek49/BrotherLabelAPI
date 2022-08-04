using NetFrameworkServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BrotherLabelAPI
{
    internal class LocalServer : HttpServer
    {
        public LocalServer() : base("127.0.0.1", 31870)
        {
        }

        protected override TcpSession CreateSession()
        {
            return new Session(this);
        }


        class Session : HttpSession
        {
            public Session(HttpServer server) : base(server)
            {
            }

            protected override void OnReceivedRequest(HttpRequest request)
            {
                string[] split = request.Url.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

                if (split.Length == 2)
                {
                    string method = split[0];
                    string data = split[1];

                    if(method == "print")
                    {
                        SendResponseAsync(Response.MakeGetResponse(data));
                        MainForm.HandleRequest(data, data, data, data);
                        return;
                    }

                }

                SendResponseAsync(Response.MakeGetResponse("ERROR: Invalid request"));
            }
        }
    }
}
