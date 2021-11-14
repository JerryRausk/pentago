using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace web_app
{
    public class PentagoGameHub : Hub
    {

        public async Task SendClick(string message)
        {
          await Clients.Others.SendAsync("ReceiveClick", message);
        }

        public async Task SendRotation(string message)
        {
          await Clients.Others.SendAsync("ReceiveRotation", message);
        }

        public async Task AnnounceClient(string id)
        {
          await Clients.Others.SendAsync("ReceiveAnnouncement", id);
        }
    }
}
