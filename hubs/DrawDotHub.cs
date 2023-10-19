using Microsoft.AspNetCore.SignalR;

namespace SignalrChat.hubs
{
    public class DrawDotHub : Hub
    {
        public async Task UpdateCanvas(int x, int y, string color)
        {
            await Clients.All.SendAsync("updateDot", x, y, color);
        }
        public async Task ClearCanvas()
        {
            await Clients.All.SendAsync("clearCanvas");
        }
    }
}