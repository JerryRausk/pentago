using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace web_app
{
    public class PentagoGameHub : Hub
    {
        public async Task SendMove(string message)
        {
            await Clients.All.SendAsync("ReceiveMove", message);
        }
    }
}
