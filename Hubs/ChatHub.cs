using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBarganhaWEB.Hubs
{
    public class ChatHub : Hub
    {
        // (nesse caso) => chave(id chat), valores(conexões do usuário) => um pra muitos
        private static Dictionary<string, List<string>> _chatMemory = new Dictionary<string, List<string>>();

        public async Task SendMessage(string chatId, string user, string message)
        {
            var connectionIds  = _chatMemory.GetValueOrDefault(chatId, new List<string>());
            foreach (var id in connectionIds)
            {
                await Clients.Client(id).SendAsync("ReceiveMessage", user, message); //pra cada conexão: enviar a mensagem
            }
        }

        public string Register(string chatId)
        {
            var connectionId = Context.ConnectionId; //conexão de um usuário

            var items = _chatMemory.GetValueOrDefault(chatId); //todas conexões que existem no id chat
            if(items == null) // se não haver conexões, é criada uma com o id do chat
            {
                _chatMemory.Add(chatId, new List<string>() { connectionId });
            } else // se haver, a conexão é inserida nessa lista
            {
                items.Add(connectionId);
            };

            return connectionId; //retorna o id da conexão de um usuário
        }
    }
}
