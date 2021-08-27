namespace server
{
    public class PentagoGameHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public void NewMove(dynamic d)
        {
            Clients.All.SendCoreAsync("newMove", new[] {d});
        }
    }
}