using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace web_app
{
    public class PentagoGameHub : Hub
    {

        public async Task SendClick(string message, string id)
        {
          await Clients.Client(id).SendAsync("ReceiveClick", message);
        }

        public async Task SendRotation(string message, string opponentId)
        {
          await Clients.Client(opponentId).SendAsync("ReceiveRotation", message, Context.ConnectionId);
        }

        public async Task AnnounceClient(string id)
        {
          await Clients.Others.SendAsync("ReceiveAnnouncement", id);
        }

        public async Task DeclineOpponent(string opponentId)
        {
          await Clients.Client(opponentId).SendAsync("ReceiveDeclining", Context.ConnectionId);
        }

        public async Task ConfirmOpponent(string opponentId)
        {
          await Clients.Client(opponentId).SendAsync("ReceiveConfirmation", Context.ConnectionId);
        }
    }
}
