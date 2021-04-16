using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBarganhaWEB.Hubs
{


    public class ChatHub : Hub
    {

        private static Dictionary<string, List<string>> _chatMemory = new Dictionary<string, List<string>>();

        public async Task SendMessage(string chatId, string user, string message)
        {
            var connectionIds  = _chatMemory.GetValueOrDefault(chatId, new List<string>());
            foreach (var id in connectionIds)
            {
                await Clients.Client(id).SendAsync("ReceiveMessage", user, message);
            }
        }

        public string Register(string chatId)
        {
            var connectionId = Context.ConnectionId;

            var items = _chatMemory.GetValueOrDefault(chatId);
            if(items == null)
            {
                _chatMemory.Add(chatId, new List<string>() { connectionId });
            } else
            {
                items.Add(connectionId);
            };

            return connectionId;
        }
    }
    
}
