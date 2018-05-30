using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace remoteteam.Hubs
{
    public class MessageHub : Hub
    {
        public void Send(string clientId, string message)
        {
            Clients.All.addNewMessageToPage(clientId, message);
        }
    }
}